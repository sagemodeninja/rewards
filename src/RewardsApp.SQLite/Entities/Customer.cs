using Microsoft.EntityFrameworkCore;
using RewardsApp.SQLite.Data;
using RewardsApp.SQLite.Migrations;
using RewardsApp.SQLite.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace RewardsApp.SQLite.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        public int CardId { get; set; }

        public int? ReferrerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public string ContactNumber { get; set; }

        public string Email { get; set; }

        public DateTime? LastRedeemed { get; set; }

        public decimal LastRedeemedPoints { get; set; }

        public decimal Points { get; set; }

        public GenericEntityStatus Status { get; set; }

        #region NAVIGATION PROPERTIES

        public Card Card { get; set; }

        public Customer Referrer { get; set; }

        public List<Customer> ReferredCustomers { get; set; }

        public List<Transaction> Transactions { get; set; }

        #endregion NAVIGATION PROPERTIES

        public async Task Create()
        {
            await using RewardsAppContext context = new();
            context.Customers.Add(this);

            await context.SaveChangesAsync();
        }

        public async Task Update()
        {
            await using RewardsAppContext context = new();
            context.Customers.Update(this);
            await context.SaveChangesAsync();
        }

        public async Task Delete()
        {
            Status = GenericEntityStatus.Inactive;
            await Update();
        }

        public async Task Reset()
        {
            Points = 0;
            await Update();

            // Transaction
            await RecordResetTransaction();
        }

        public static async Task<List<Customer>> GetAll()
        {
            await using RewardsAppContext context = new();

            return await context.Customers.Include(c => c.Card)
                                          .Include(c => c.Referrer)
                                          .Where(c => c.Status == GenericEntityStatus.Active)
                                          .ToListAsync();
        }

        public async Task AddPoints(decimal points)
        {
            await using RewardsAppContext context = new();

            context.Attach(this);
            Points += points;

            // Transaction
            await RecordTransaction(TransactionType.EarnPoints, points, context);

            await context.SaveChangesAsync();
        }

        public static async Task AddPoints(int customerId, decimal points)
        {
            await using RewardsAppContext context = new();

            var customer = await context.Customers.FirstOrDefaultAsync(c => c.Id == customerId);
            customer.Points += points;
            
            // Transaction
            await customer.RecordTransaction(TransactionType.EarnPoints, points, context);

            await context.SaveChangesAsync();
        }

        public async Task RedeemPoints(decimal points)
        {
            await using RewardsAppContext context = new();

            context.Attach(this);
            Points -= points;
            LastRedeemed = DateTime.UtcNow;
            LastRedeemedPoints = points;
            
            // Transaction
            await RecordTransaction(TransactionType.RedeemPoints, points, context);

            await context.SaveChangesAsync();
        }

        private async Task RecordTransaction(TransactionType transactionType, decimal points, RewardsAppContext context)
        {
            var lastTransaction = await context.Transactions
                                               .OrderBy(trans => trans.Id)
                                               .LastOrDefaultAsync();

            var lastBalance = lastTransaction?.Balance ?? 0;
            var balance = transactionType switch
            {
                TransactionType.EarnPoints => lastBalance + points,
                _ => lastBalance - points
            };

            var transaction = new Transaction
            {
                CustomerId = Id,
                TransactionType = transactionType,
                Points = points,
                Balance = balance,
                Timestamp = DateTime.UtcNow
            };

            context.Transactions.Add(transaction);
        }

        private async Task RecordResetTransaction()
        {
            var transaction = new Transaction
            {
                CustomerId = Id,
                TransactionType = TransactionType.Reset,
                Points = 0,
                Balance = 0,
                Timestamp = DateTime.UtcNow
            };

            await using RewardsAppContext context = new();
            context.Transactions.Add(transaction);
            await context.SaveChangesAsync();
        }
    }
}

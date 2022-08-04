using Microsoft.EntityFrameworkCore;
using RewardsApp.SQLite.Data;
using RewardsApp.SQLite.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
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
            this.Status = GenericEntityStatus.Inactive;
            await this.Update();
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
            this.Points += points;

            await context.SaveChangesAsync();
        }

        public static async Task AddPoints(int customerId, decimal points)
        {
            await using RewardsAppContext context = new();

            var customer = await context.Customers.FirstOrDefaultAsync(c => c.Id == customerId);
            customer.Points += points;

            await context.SaveChangesAsync();
        }

        public async Task RedeemPoints(decimal points)
        {
            await using RewardsAppContext context = new();

            context.Attach(this);
            this.Points -= points;
            this.LastRedeemed = DateTime.Now;
            this.LastRedeemedPoints = points;

            await context.SaveChangesAsync();
        }
    }
}

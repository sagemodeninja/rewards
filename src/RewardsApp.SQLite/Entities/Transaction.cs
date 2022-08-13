using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RewardsApp.SQLite.Data;
using RewardsApp.SQLite.Interfaces;
using RewardsApp.SQLite.Utilities.Enums;

namespace RewardsApp.SQLite.Entities
{
    public class Transaction : ITransaction
    {
        /// <inheritdoc />
        public long Id { get; set; }

        /// <inheritdoc />
        public int CustomerId { get; set; }

        /// <inheritdoc />
        public DateTime Timestamp { get; set; }

        /// <inheritdoc />
        public TransactionType TransactionType { get; set; }

        /// <inheritdoc />
        public decimal Points { get; set; }

        /// <inheritdoc />
        public decimal Balance { get; set; }

        /// <inheritdoc />
        public GenericEntityStatus Status { get; set; }

        public static async Task<List<Transaction>> GetByCustomer(int customerId)
        {
            await using RewardsAppContext context = new();

            return await context.Transactions
                                .Where(transaction =>
                                    transaction.CustomerId == customerId &&
                                    transaction.Status == GenericEntityStatus.Active)
                                .ToListAsync();
        }
    }
}

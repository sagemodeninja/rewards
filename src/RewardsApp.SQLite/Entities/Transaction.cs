using System;
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
        public GenericEntityStatus Status { get; set; }
    }
}

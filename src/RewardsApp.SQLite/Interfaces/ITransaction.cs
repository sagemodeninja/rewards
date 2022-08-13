using System;
using RewardsApp.SQLite.Utilities.Enums;

namespace RewardsApp.SQLite.Interfaces
{
    public interface ITransaction
    {
        /// <summary>
        /// Primary identifier of transaction.
        /// </summary>
        long Id { get; set; }

        /// <summary>
        /// Primary identifier of customer.
        /// </summary>
        int CustomerId { get; set; }

        /// <summary>
        /// Date and time of transaction.
        /// </summary>
        DateTime Timestamp { get; set; }

        /// <summary>
        /// Type of transaction.
        /// </summary>
        TransactionType TransactionType { get; set; }

        /// <summary>
        /// Points earned of redeemed.
        /// </summary>
        decimal Points { get; set; }

        /// <summary>
        /// Balance after transaction.
        /// </summary>
        decimal Balance { get; set; }

        /// <summary>
        /// Status of transaction.
        /// </summary>
        GenericEntityStatus Status { get; set; }
    }
}
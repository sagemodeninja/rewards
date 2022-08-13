namespace RewardsApp.SQLite.Utilities.Enums
{
    /// <summary>
    /// Type of transaction
    /// </summary>
    public enum TransactionType
    {
        /// <summary>
        /// Customer earned points.
        /// </summary>
        EarnPoints,

        /// <summary>
        /// Customer redeemed their points.
        /// </summary>
        RedeemPoints,

        /// <summary>
        /// Customer's points were manually rest to 0.
        /// </summary>
        Reset
    }
}
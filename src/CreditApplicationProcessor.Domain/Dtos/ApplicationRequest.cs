namespace CreditApplicationProcessor.Domain.Dtos
{
    public class ApplicationRequest
    {
        /// <summary>
        /// Credit Amount
        /// </summary>
        public int Amount { get; init; }

        /// <summary>
        /// Repayment in months
        /// </summary>
        public int Term { get; init; }

        /// <summary>
        /// Current pre-existing credit amount
        /// </summary>
        public int PreAmount { get; init; }
    }
}

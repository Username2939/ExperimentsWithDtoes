namespace UsingConstructor
{
    public class BankAccount
    {
        public string? ID { get; set; } = null;
        public decimal? Amount { get; set; } = null;
        public DateTime? LastActivity { get; set; } = null;
        public BankAccount(string? id, decimal? amount, DateTime? lastActivity)
        {
            ID = id;
            Amount = amount;
            LastActivity = lastActivity;
        }
    }
}
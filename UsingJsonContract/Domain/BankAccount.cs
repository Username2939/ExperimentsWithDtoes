namespace UsingJsonContract.Domain
{
    public record BankAccount(
        int? ID = null,
        decimal? AmountDeposited = null,
        DateTime? DateLastActivity = null
        )
    {
        public BankAccount(BankAccount bankAccount)
        {
            ID = bankAccount.ID;
            AmountDeposited = bankAccount.AmountDeposited;
            DateLastActivity = bankAccount.DateLastActivity;
        }
    }
}
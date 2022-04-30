namespace UsingJsonContract.Domain
{
    public record BankAccount(
        int? ID = null,
        decimal? AmountDeposited = null,
        DateTime? DateLastActivity = null
        );
}
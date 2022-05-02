namespace UsingJsonContract.Domain
{
    public record Person(
        string? FirstName = null,
        string? LastName = null,
        int? Age = null,
        string? SocialSecurity = null,
        BankAccount? BankAccount = null
        );
}
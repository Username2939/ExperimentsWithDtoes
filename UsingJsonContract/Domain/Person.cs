namespace UsingJsonContract.Domain
{
    public record Person(
        string? FirstName = null,
        string? LastName = null,
        int? Age = null,
        string? SocialSecurity = null,
        BankAccount? BankAccount = null
        )
    {
        // public Person() { }
        public Person(Person person) // Redundant CTOR provided to optionally write by addition rather than subtraction
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            Age = person.Age;
            SocialSecurity = person.SocialSecurity;
            BankAccount = person.BankAccount;
        }
    }
}
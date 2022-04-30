using Microsoft.AspNetCore.Mvc;
using UsingJsonContract.Domain;

namespace UsingJsonContract.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonsController : ControllerBase
    {
        #region Some mock data
        private static readonly BankAccount BankAccount = new(
            21,                 // Unique Identifier
            1000.48m,           // Amount Deposited
            DateTime.Now        // Date Last Activity
            );

        private static readonly Person Person = new(
            "Mario",            // First Name
            "Rossi",            // Last Name
            21,                 // Age
            "SecretData",       // Social Security
            BankAccount         // Bank Account
            );
        #endregion

        [HttpGet("Name")]
        public Person GetName()
            => Person with
            {
                FirstName = Person.FirstName,
                LastName = Person.LastName,
                Age = null,
                SocialSecurity = null,
                BankAccount = null
            };

        [HttpGet("NameAndAge")]
        public Person GetNameAndAge()
            => Person with
            {
                FirstName = Person.FirstName,
                LastName = Person.LastName,
                Age = Person.Age,
                SocialSecurity = null,
                BankAccount = null
            };

        [HttpGet("SomeSensitiveData")]
        public Person GetSomeSensitiveData()
            => Person with
            {
                FirstName = null,
                LastName = null,
                Age = null,
                SocialSecurity = Person.SocialSecurity,
                BankAccount = Person.BankAccount with
                {
                    ID = Person.BankAccount.ID,
                    AmountDeposited = null,
                    DateLastActivity = null
                }
            };

        [HttpGet("AllSensitiveData")]
        public Person GetAllSensitiveData()
            => Person with
            {
                FirstName = null,
                LastName = null,
                Age = null,
                SocialSecurity = Person.SocialSecurity,
                BankAccount = Person.BankAccount with
                {
                    ID = Person.BankAccount.ID,
                    AmountDeposited = Person.BankAccount.AmountDeposited,
                    DateLastActivity = Person.BankAccount.DateLastActivity
                }
            };
    }
}
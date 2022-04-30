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

        [HttpGet("NameBySubtraction")]
        public Person GetNameBySubtraction()  // "Give me everything except for these things"
            => Person with
            {
                SocialSecurity = null,
                BankAccount = null
            };

        [HttpGet("NameByAddition")]
        public Person GetNameByAddition()     // "Give me these specific things" (requires a Constructor)
            => new Person(
                Person.FirstName,
                Person.LastName,
                Person.Age,
                null,
                null);

        [HttpGet("SomeSensitiveData")]
        public Person GetSomeSensitiveData()
            => new Person(
                Person.FirstName,
                Person.LastName,
                Person.Age,
                null,
                new BankAccount(
                    BankAccount.ID,
                    null,
                    null
                    )
                );

        [HttpGet("AllSensitiveData")]
        public Person GetAllSensitiveData()
            => new Person(
                Person.FirstName,
                Person.LastName,
                Person.Age,
                null,
                new BankAccount(
                    BankAccount.ID,
                    BankAccount.AmountDeposited,
                    BankAccount.DateLastActivity
                    )
                );

        [HttpPost("DoSomething")]
        public void PostDoSomething(Person person) // TODO Fix, currently breaks in Swagger
        {
            var cleanPerson = person with
            {
                SocialSecurity = null,
                BankAccount = null
            };

            // Do something here ...
        }
    }
}
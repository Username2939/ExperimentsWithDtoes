using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingConstructor
{
    public class Person
    {
        public string? FirstName { get; set; } = null;
        public string? LastName { get; set; } = null;
        public int? Age { get; set; } = null;
        public string? SocialSecurity { get; set; } = null;
        public BankAccount? BankAccount { get; set; } = null;
        public Person(string? firstName, string? lastName, int? age, string? socialSecurity, BankAccount? bankAccount)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            SocialSecurity = socialSecurity;
            BankAccount = bankAccount;
        }
    }
}
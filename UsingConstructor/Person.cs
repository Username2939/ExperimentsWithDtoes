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
        public string? BankAccountPassword { get; set; } = null;
        public Person(string? firstName, string? lastName, int? age, string? socialSecurity, string? bankAccountPassword)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            SocialSecurity = socialSecurity;
            BankAccountPassword = bankAccountPassword;
        }
        public Person(Person person, bool arg0, bool arg1, bool arg2, bool arg3, bool arg4)
        {
            if (arg0) FirstName = person.FirstName;
            if (arg1) LastName = person.LastName;
            if (arg2) Age = person.Age;
            if (arg3) SocialSecurity = person.SocialSecurity;
            if (arg4) BankAccountPassword = person.BankAccountPassword;
        }
    }
}
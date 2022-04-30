using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingExtensionMethod
{
    public static class ShaveClass
    {
        public static Person Shave(this Person person)
            => person with
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                Age = person.Age,
                SocialSecurity = null,
                BankAccountPassword = null
            };
    }
}

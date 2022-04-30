using HeyJsonSerializerIgnoreStuffWithThisCodeword;
using Newtonsoft.Json;

var person = new Person("Molly",              // First Name
                        "Mouk",               // Last Name
                        21,                   // Age
                        "SomeSensitiveData",  // Social Security Number
                        "MoreSensitiveData"   // Bank Account Password
                        );

// insert some work on the domain object here ...
// now sensitive data must be shaved off to send it to the presentation layer ...

person = person with { SocialSecurity = null, BankAccountPassword = null };

var settings = new JsonSerializerSettings // tell serializer to ignore null values
{
    DefaultValueHandling = DefaultValueHandling.Ignore,
    NullValueHandling = NullValueHandling.Ignore
};

Console.WriteLine(JsonConvert.SerializeObject(person, settings)); // returns a JSON with only FirstName, LastName, and Age
Console.ReadKey();
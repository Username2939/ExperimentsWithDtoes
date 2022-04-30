using UsingExtensionMethod;
using Newtonsoft.Json;

var person = new Person("Molly",              // First Name
                        "Mouk",               // Last Name
                        21,                   // Age
                        "SomeSensitiveData",  // Social Security Number
                        "MoreSensitiveData"   // Bank Account Password
                        );

var settings = new JsonSerializerSettings // tell serializer to ignore null values
{
    DefaultValueHandling = DefaultValueHandling.Ignore,
    NullValueHandling = NullValueHandling.Ignore
};

Console.WriteLine(JsonConvert.SerializeObject(person.Shave(), settings)); // returns a JSON with only FirstName, LastName, and Age
Console.ReadKey();
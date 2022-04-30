using Newtonsoft.Json;
using UsingConstructor;

var person = new Person("Molly",              // First Name
                        "Mouk",               // Last Name
                        21,                   // Age
                        "SomeSensitiveData",  // Social Security Number
                        "MoreSensitiveData"   // Bank Account Password
                        );

var NameSurname = new Person(person,
                             true,            // "Molly"
                             true,            // "Mouk"
                             false,           // null
                             false,           // null
                             false            // null
                             );

var NameSurnameAge = new Person(person,
                             true,            // "Molly"
                             true,            // "Mouk"
                             true,            // 21
                             false,           // null
                             false            // null
                             );

var SensitiveData = new Person(person,
                             false,           // null
                             false,           // null
                             false,           // null
                             true,            // "SomeSensitiveData"
                             true             // "MoreSensitiveData"
                             );

Console.ReadKey();
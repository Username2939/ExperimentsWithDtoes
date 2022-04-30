using UsingConstructor;

var person = new Person("Molly",              // First Name
                        "Mouk",               // Last Name
                        21,                   // Age
                        "SomeSensitiveData",  // Social Security Number
                        new BankAccount(
                            "SomeID",         // ID
                            10.10m,           // Amount
                            DateTime.Now      // LastActivity
                            )
                        );

var A = new Person(person.FirstName, person.LastName, person.Age, null, null);

var B = new Person(null, null, null, null, new BankAccount(null, null, DateTime.Now));

Console.ReadKey();
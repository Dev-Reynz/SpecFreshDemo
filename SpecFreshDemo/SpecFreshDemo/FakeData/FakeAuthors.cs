using SpecFreshDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFreshDemo.FakeData
{
    public static class FakeAuthors
    {
        public static IEnumerable<Author> Authors { get; set; }
        static FakeAuthors()
        {
            Init();
        }

        private static void Init()
        {
            Authors = new List<Author>
            {
                new Author
                {
                    ID = "AU001",
                    Name = new Name { First = "Reynaldo", FullMiddle = "Guillen", Last = "Monares", MiddleInitial = "G" },
                    Addresses = new List<Address>
                    {
                        new Address
                        {
                            ID = "CAD001",
                            City = "Mandaluyong",
                            Country = "Philippines",
                            State = "Philippines",
                            Street = "Pioneer Pointe, Pioneer St., Brgy. Highway Hills",
                            ZipCode = "1111",
                            Province = "Metro Manila",
                            Type = AddressType.City
                        },
                        new Address
                        {
                            ID = "PAD001",
                            City = "San Vicente",
                            Country = "Philippines",
                            State = "Philippines",
                            Street = "Brgy. Destacado",
                            Province = "Northern Samar",
                            Type = AddressType.Provincial,
                            ZipCode = "2408"
                        }
                    },
                    PhoneNumbers = new List<Phone>
                    {
                        new Phone { Number = "09308177945", Type = ContactType.Mobile },
                        new Phone{ Number = "09158446417", Type = ContactType.Mobile}
                    },
                    EmailAddresses = new List<Email>
                    {
                        new Email{ Address = "reynzmonares@gmail.com",Domain = "gmail", Type = EmailType.Primary},
                        new Email{ Address = "reynald.monares.haiyan@gmail.com", Domain = "gmail", Type = EmailType.Primary},
                        new Email{ Address = "reynzmonares@yahoo.com", Domain = "yahoo", Type = EmailType.Primary}
                    }
                },
                new Author
                {
                    ID = "AU002",
                    Name = new Name { First = "Renato", FullMiddle = "Javier", Last = "Monares", MiddleInitial = "J" },
                    Addresses = new List<Address>
                    {
                        new Address
                        {
                            ID = "CAD002",
                            City = "Mandaluyong",
                            Country = "Philippines",
                            State = "Philippines",
                            Street = "#4B Sto. Rosario St., Brgy. Plainview",
                            ZipCode = "1111",
                            Province = "Metro Manila",
                            Type = AddressType.City
                        },
                        new Address
                        {
                            ID = "PAD002",
                            City = "Catarman",
                            Country = "Philippines",
                            State = "Philippines",
                            Street = "University of Eastern Philippines Campus",
                            Province = "Northern Samar",
                            Type = AddressType.Provincial,
                            ZipCode = "2408"
                        }
                    },
                    PhoneNumbers = new List<Phone>
                    {
                        new Phone { Number = "09218167495", Type = ContactType.Mobile },
                        new Phone{ Number = "09178856983", Type = ContactType.Mobile }
                    },
                    EmailAddresses = new List<Email>
                    {
                        new Email{ Address = "renatojaviermonares@gmail.com",Domain = "gmail", Type = EmailType.Primary},
                        new Email{ Address = "renato.monares@gmail.com", Domain = "gmail", Type = EmailType.Primary},
                    }
                }
            };
        }
    }
}

using System;
using EntityFrameworkCoreSamples.Entities;

namespace EntityFrameworkCoreSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SampleContext())
            {
                var address = new Address
                {
                    Street = "1 Street",
                    Suburb = "Suburb"
                };

                var contact = new Contact
                {
                     EmailAddress = "test@test.com",
                    PhoneNumber = "1234567890"
                };

                var person = new Person
                {
                    Details = new PersonDetails
                    {
                        Addresses = new[] {address},
                        Contacts = new[] {contact}
                    }
                };

                db.People.Add(person);

                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All people in database:");

                foreach (var blog in db.People)
                {
                    Console.WriteLine(" - {0}", blog.Id);
                }
            }
        }
    }
}
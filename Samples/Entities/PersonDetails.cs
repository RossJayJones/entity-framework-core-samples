using System.Collections.Generic;

namespace Samples.Entities
{
    public class PersonDetails
    {
        public IReadOnlyCollection<Address> Addresses { get; set; }

        public IReadOnlyCollection<Contact> Contacts { get; set; }
    }
}

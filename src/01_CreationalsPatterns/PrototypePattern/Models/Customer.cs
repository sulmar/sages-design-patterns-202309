using System;

namespace PrototypePattern
{
    public class Customer : ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address HomeAddress { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public object Clone()
        {
            return MemberwiseClone(); // Shallow copy (płytka kopia)
        }

        // głęboka kopia
        // https://github.com/AlenToma/FastDeepCloner
    }

    public class Address
    {
        public string City { get; set; }
    }

}

using System;
namespace TechJobsOONS
{
    public class Location : JobField
    {
        //public int Id { get; }
        //private static int nextId = 1;
        //public string Value { get; set; }

        //public Location()
        //{
        //    Id = nextId;
        //    nextId++;
        //}

        // TODO: Add a second constructor to this class that uses the Location() constructor and sets the value of the value field.
        // Done.

        public Location(string value) : base(value)
        {

        }

        //public override bool Equals(object obj)
        //{
        //    return obj is Location location &&
        //           Id == location.Id;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Id);
        //}

        //public override string ToString()
        //{
        //    return Value;
        //}
    }
}

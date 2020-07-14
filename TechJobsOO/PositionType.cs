using System;
namespace TechJobsOONS
{
    public class PositionType : JobField
    {
        //public int Id { get; }
        //private static int nextId = 1;
        //public string Value { get; set; }

        //public PositionType()
        //{
        //    Id = nextId;
        //    nextId++;
        //}

        public PositionType(string value) : base(value)
        {

        }

        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.
        // Done.

        //public override bool Equals(object obj)
        //{
        //    return obj is PositionType position &&
        //           Id == position.Id;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Id);
        //}

        //public override string ToString() => Value;
    }
}

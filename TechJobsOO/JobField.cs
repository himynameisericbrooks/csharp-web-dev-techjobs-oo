using System;
namespace TechJobsOONS
{
    public abstract class JobField
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        //This assigns a unique ID
        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string value) : this()
        {
            Value = value;
        }


        public override bool Equals(object obj)
        {
            return obj is JobField jobField &&
                   Id == jobField.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}

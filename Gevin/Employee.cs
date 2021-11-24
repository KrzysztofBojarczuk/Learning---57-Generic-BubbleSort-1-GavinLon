using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gevin
{
    public  class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo([AllowNull] Employee other)
        {
            return this.Id.CompareTo(other.Id);
        }

        //public int CompareTo(object obj)
        //{
        //    return this.Id.CompareTo(((Employee)obj).Id);
        //}
        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}

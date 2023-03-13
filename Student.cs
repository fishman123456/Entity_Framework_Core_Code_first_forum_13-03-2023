using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Core_Code_first_forum_13_03_2023
{
    internal class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;    
        public string Fname { get; set; } = null!;

        public int Age { get; set; }

        public Student() { }
        public Student( string _name, string _fname, int _age)
        {
            this.Name = _name;
            this.Fname = _fname;
            this.Age = _age;    
        }

        public Student(string _name, string _fname)
        {
            this.Name = _name;
            this.Fname = _fname;
        }


        public int CompareTo(Student? other )
        {
            if ( other == null ) throw new NotImplementedException() ;
            return this.Name.CompareTo(other.Name);

        }
        public override string ToString()
        {
            return $"{this.Fname} {this.Name} {this.Age} ";
        }
    }
}

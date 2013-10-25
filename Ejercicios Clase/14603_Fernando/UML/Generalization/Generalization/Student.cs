using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generalization
{
    class Student : Person
    {
        public List<int> grades;

        public Student(List<int> _grades, string _name, int _age)
        {
            grades = _grades;
            name = _name;
            age = _age;
        }
    }
}

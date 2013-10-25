using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Teacher
    {
        public string name;
        public List<Student> students;

        public Teacher(string _name, List<Student> _students)
        {
            name = _name;
            students = _students;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generalization
{
    class Teacher : Person
    {
        List<Student> students;

        public Teacher(List<Student> _students, string _name, int _age)
        {
            students = _students;
            name = _name;
            age = _age;

            if (name == "turi")
                Fail();
        }

        void Fail()
        {
                foreach (Student S in students)
                {
                    S.grades.Add(0);
                }
        }

    }
}

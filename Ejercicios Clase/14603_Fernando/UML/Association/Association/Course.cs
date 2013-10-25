using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Course
    {
        string name;
        int id;
        Teacher teacher;

        public Course(string _name, int _id, Teacher _teacher)
        {
            name = _name;
            id = _id;
            teacher = _teacher;
        }

    }
}

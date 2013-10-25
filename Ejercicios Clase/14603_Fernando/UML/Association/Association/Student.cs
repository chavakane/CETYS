using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Student
    {
        List<Course> courses;
        string name;
        int id;

        public Student(List<Course> _courses, string _name, int _id)
        {
            courses = _courses;
            name = _name;
            id = _id;
        }

    }
}

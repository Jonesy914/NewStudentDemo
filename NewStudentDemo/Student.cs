using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewStudentDemo
{
    class Student
    {
        private int age;
        public Student(String name, int age)
        {
            Name = name;
            this.age = age;
        }

        public String Name
        {
            get;
        }

        public int Age
        {
            get { return this.Age; }
            set { age = value; }
        }

        public void changeAge()
        {
            age = age + 10;
        }
    }    
}

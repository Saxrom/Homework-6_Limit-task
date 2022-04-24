using System;
namespace Yoxlama
{
    public class Student
    {
        public string Name;
        public string Surname;

        public Student(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Fullname()
        {
            string Fullname = Name + " "+ Surname;
            return Fullname;
        }

    }

    


}

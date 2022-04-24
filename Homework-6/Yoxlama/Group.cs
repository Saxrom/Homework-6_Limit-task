using System;
namespace Yoxlama
{
    public class Group
    {
        public string No;
        public int Limit;
        public string[] Students;

        public Group(string no,int limit,string[]students)
        {
            No = no;
            Limit = limit;
            Students = students;
        }


        Student students;
        int i = 0;

        public  void    AddStudent(Student student)
        {
            Students[i] = student.Fullname();i++;
        }


        public  void GetStudent()
        {
            Console.WriteLine($"Group Namber: {No}");
            Console.WriteLine($"Group Limit: {Limit}");

            for (int i = 0; i < Limit; i++)
            {
                Console.WriteLine(Students[i]);
            }
        }
    }

    
}

using System;

namespace Yoxlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Limit");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter GroupName");
            string no = Console.ReadLine();
            string[] arr = new string[limit];

            Group group = new Group(no, limit, arr);
            int count = 0;

            do
            {
                Console.WriteLine("Please enter name");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter surname");
                string surname = Console.ReadLine();

                Student student = new Student(name, surname);
                group.AddStudent(student);
                count++;
            } while (count<limit);

            group.GetStudent();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nguyen_BT02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student(1, "Tran Van A", 15));
            students.Add(new Student(2, "Tran Van B", 16));
            students.Add(new Student(3, "Tran Van C", 17));
            students.Add(new Student(4, "Tran Van D", 18));
            students.Add(new Student(5, "Tran Van E", 19));

            Console.WriteLine("a ========================");
            print(students);
            Console.WriteLine("b ========================");

            From15to18(students);
            Console.WriteLine("c ========================");

            NameStartWithA(students);
            Console.WriteLine("d ========================");

            SumAge(students);
            Console.WriteLine("e ========================");

            FindAgeMax(students);
            Console.WriteLine("f ========================");

            OrderByAgeASC(students);
            Console.ReadLine();
        }


        public static void print(List<Student> list)
        {
            foreach (Student student in list)
            {
                Console.WriteLine(student.Id);
                Console.WriteLine(student.Name);
                Console.WriteLine(student.Age);
            }


        }


        public static void From15to18(List<Student> list)
        {
            List<Student> students = list.Where(student => student.Age >= 15 && student.Age <= 18).ToList();

            foreach (Student student in students)
            {
                Console.WriteLine(student.Id);
                Console.WriteLine(student.Name);
                Console.WriteLine(student.Age);
            }

        }

        public static void NameStartWithA(List<Student> list)
        {
            List<Student> students = list
                .Where(student =>
                    student.Name.Trim().Substring(student.Name.LastIndexOf(" ") + 1)
                        .StartsWith("A"))
                .ToList();

            foreach (Student student in students)
            {
                Console.WriteLine(student.Id);
                Console.WriteLine(student.Name);
                Console.WriteLine(student.Age);
            }
        }

        public static void SumAge(List<Student> list)
        {
            Console.WriteLine(list.Sum(stu => stu.Age));
        }

        public static void FindAgeMax(List<Student> list)
        {
            Student result = list.OrderByDescending(student => student.Age).FirstOrDefault();
            if (result != null)
            {
                Console.WriteLine(result.Id);
                Console.WriteLine(result.Name);
                Console.WriteLine(result.Age);
            }
        }

        public static void OrderByAgeASC(List<Student> list)
        {
            print(list.OrderBy(student => student.Age).ToList());

        }


    }


}

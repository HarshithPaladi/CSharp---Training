﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //delegate int add(int a,int b);
    class LamdaExp
    {
        public void Run()
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            var square = (int n) => { return n * n; };
            foreach (int n in nums)
            {
                Console.WriteLine(square(n));
            }
        }
        public void ARun()
        {
            List<int> L1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> DivisibleBy5 = L1.FindAll(n => n % 5 == 0);
            List<string> S1 = new List<string>() { "abc", "qef", "hai", "akl" };
            List<string> SortAlpha = S1.OrderBy(s => s).ToList();

            foreach (int n in DivisibleBy5)
            {
                Console.WriteLine(n);
            }
            foreach (string s in SortAlpha)
            {
                Console.WriteLine(s);
            }
        }
        public void BRun()
        {
            Dictionary<int, int[]> dict = new Dictionary<int, int[]>();
            dict.Add(1, new int[] { 2, 3 });
            dict.Add(3, new int[] { 2, 4 });
            dict.Add(7, new int[] { 3, 2 });
            dict.Add(2, new int[] { 1, 7 });
            dict.Add(9, new int[] { 4, 3 });

            foreach (var k in dict.OrderBy(x => x.Value[1] * -1).OrderBy(x => x.Value[0]))
            {
                Console.WriteLine($"[{k.Value[0]}, {k.Value[1]}]");
            }
        }
    }
    public class Student
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }
        public int Score { set; get; }
        public string Dept { set; get; }
        public void method()
        {
            List<Student> StudentList = new List<Student>();
            StudentList.Add(new Student() { Id = 1, Name = "Harshith", Age = 21, Dept = "CSE", Score = 90 });
            StudentList.Add(new Student() { Id = 2, Name = "Akshai", Age = 22, Dept = "EEE", Score = 92 });
            StudentList.Add(new Student() { Id = 3, Name = "Sravani", Age = 22, Dept = "CSBS", Score = 91 });
            StudentList.Add(new Student() { Id = 4, Name = "Deepthi", Age = 20, Dept = "ECE", Score = 88 });
            foreach (var student in StudentList)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Dept:{student.Dept}, Score: {student.Score}");
            }
            Console.WriteLine("-------------------------------------");
            List<Student> sortStudents = StudentList.OrderBy(x => x.Age).ToList();
            foreach (var student in sortStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Dept:{student.Dept}, Score: {student.Score}");
            }
        }

    }
}

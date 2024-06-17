using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_dec_5
{
    class Student
    {
        public static int ID;
        private string Name;
        private int rollNo;
        private int age;
        private int class1;
        private int percentage;



        public string UserName { get => Name; set => Name = value; }
        public int RollNo { get => rollNo; set => rollNo = value; }
        public int Age { get => age; set => age = value; }
        public int Class1 { get => class1; set => class1 = value; }
        public int Percentage { get => percentage; set => percentage = value; }

        Dictionary<int, Student> studentList = new Dictionary<int, Student>();


        public void StudentData()
        {
            //Write a program to store 5 students name and their corresponding data. Student data will comprise following info-
            //Roll No, Age, Class, Percentage
            //Accept a student name from user and display his data to user.
    
            for(int i = 0; i < 5; i++)
            {
                Student obj = new Student();

                Console.WriteLine("Enter student name");
                obj.UserName = Console.ReadLine().ToLower();

                Console.WriteLine("Enter roll number");
                obj.RollNo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter age");
                obj.Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter class");
                obj.Class1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter percentage");
                obj.Percentage = Convert.ToInt32(Console.ReadLine());

                UserData.ID = UserData.ID + 1;
                studentList.Add(UserData.ID, obj);

                Console.WriteLine("\n");
            }

            //foreach(var val in studentList)
            //{
            //    Console.WriteLine("ID: " + val.Key + " Name: " + val.Value.UserName + " Roll: " + val.Value.RollNo + " Age: " + val.Value.Age + " Class: " + val.Value.Class1 + " Percentage: " + val.Value.Percentage);
            //}

            Console.WriteLine("Enter name to know the details");

            string key = Console.ReadLine().ToLower();

            foreach (var val in studentList)
            {
                if (val.Value.UserName == key)
                {
                    Console.WriteLine("ID: " + val.Key + " Name: " + val.Value.UserName + " Roll: " + val.Value.RollNo + " Age: " + val.Value.Age + " Class: " + val.Value.Class1 + " Percentage: " + val.Value.Percentage);
                }
                else
                {
                    //print nothing
                }
            }

            Console.ReadKey();
        }
    }
}

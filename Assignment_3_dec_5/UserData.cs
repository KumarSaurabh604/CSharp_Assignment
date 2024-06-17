using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_dec_5
{

    //1.	Write a program to develop application where it will ask user to provide action in integer ranging from 1 to 4 which means as-
        //1: Add record       2: Get all records	3: Get a record		4: Delete record
    //Record consists of id(random number), list of salary amount for 3 months, average salary.
    //Rules:-
        //	Please use Enum to work with user action input.
        //	User should not be able to assign any value to id and avg.salary from test file.
        //	Application should continue working until user is not denying to continue.

    class UserData
    {
        enum variable
        {
            Add_Record = 1,
            Get_All_Record = 2,
            Get_A_Record = 3,
            Delete_A_Record= 4
        }

        public static int ID;
        private string Name;
        private int salary;
        private int averageSalary;


        public string UserName { get => Name; set => Name = value; }
        public int Salary { get => salary; set => salary = value; }
        public int AverageSalary { get => averageSalary; set => averageSalary = value; }

        Dictionary<int, UserData> userList = new Dictionary<int, UserData>();

        public void Data()
        {
            
            Console.WriteLine("Select an operation \n 1.Add record \n 2.Get all record \n 3.Get a record \n 4.Delete a record \n 5.Exit");
            int num;
            var number = int.TryParse(Console.ReadLine(),out num);

            if(number == true && (num>0 && num<6))
            {
                //Console.WriteLine("selected number is : " + num);
                switch (num)
                {
                    case (int)variable.Add_Record:

                        addUser();
                        break;

                    case (int)variable.Get_All_Record:

                        getAllUser();
                        break;

                    case (int)variable.Get_A_Record:
                        getARecord();
                        break;

                    case (int)variable.Delete_A_Record:

                        deleteARecord();
                        break;

                    default:
                        Console.ReadKey();
                            break;
                }
                Console.ReadKey();


            }
            else
            {
                Console.WriteLine("\n\nPlease select a valid operation\n\n");
                Data();
            }


        }

        public void addUser()
        {

            UserData obj = new UserData();

            Console.WriteLine("Enter user name");
            obj.UserName = Console.ReadLine().ToLower();

            Console.WriteLine("Enter salary of 3 months");
            obj.Salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter average salary");
            obj.AverageSalary = Convert.ToInt32(Console.ReadLine());

            UserData.ID = UserData.ID + 1;
            userList.Add(UserData.ID, obj);

            Data();
        } 

        public void getAllUser()
        {
            foreach (var val in userList)
            {

                Console.WriteLine("ID: " + val.Key + "\n User name  " + val.Value.UserName + "\n Three month salary  " + val.Value.Salary + "\n Average salary:  " + val.Value.AverageSalary);
            }

            Data();
        }

        public void getARecord()
        {
            Console.WriteLine("Please enter user name");
            string key = Console.ReadLine().ToLower();

            foreach (var val in userList)
            {
                if (val.Value.UserName == key)
                {

                    Console.WriteLine("ID: " + val.Key + "\n User name  " + val.Value.UserName + "\n Three month salary  " + val.Value.Salary + "\n Average salary:  " + val.Value.AverageSalary);

                }
                else
                {
                    //print nothing
                }

            }

            Data();
        }

        public void deleteARecord()
        {
            Console.WriteLine("Please enter User ID");
            int key1 = int.Parse(Console.ReadLine());

            if (userList.ContainsKey(key1))
            {
                userList.Remove(key1);
            }
            else
            {
                Console.WriteLine("Key not found\n");
            }

            Data();
        }
    }
}

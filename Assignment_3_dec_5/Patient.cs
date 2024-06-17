using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_dec_5
{

    //  Write a program to accept patient count inputs from user for multiple days(days count should be taken from user).
    //After getting all records, ask an input from user for following actions-
//	Maximum :- return maximum count of patient along with day number when maximum patients got admitted
//	Minimum :- return minimum count of patient along with day number when minimum patients got admitted
//	Average :- return average patient count for stored data of various days
//	Sum :- return total count of patients admitted along with number of days

    class Patient
    {
        public void PatientData()
        {
            Console.WriteLine("Enter number of days");
            int days;
            bool data = int.TryParse(Console.ReadLine(), out days);

           int[] array = new int[days];

            if(data == true)
            {
                for(int i = 0; i < days; i++)
                {
                    Console.WriteLine("Enter patients on day "+(i+1));
                    array[i] = int.Parse(Console.ReadLine());
                }

                tag1:
                Console.WriteLine("Select an operation \n '1' for Maximum \n '2' for Minimum \n '3' for Average \n '4' for Sum \n '5' for Exit");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        //Maximum
                        int mx = array[0];
                        int key=0;

                        for(int m = 0; m < array.Count(); m++)
                        {
                            if (array[m] > mx)
                            {
                                mx = array[m];
                                key = m;
                            }
                            else
                            {
                                //print nothing
                            }
                        }

                        Console.WriteLine("Maximum number of patients on " + (key+1) + " is " + mx+"\n");
                        goto tag1;
                        //break;

                    case 2:

                        //Minimum;
                        int mn = array[0];
                        int key1 = 0;

                        for (int n = 0; n < array.Count(); n++)
                        {
                            if (array[n] < mn)
                            {
                                mn = array[n];
                                key1 = n;
                            }
                            else
                            {
                                //print nothing
                            }
                        }

                        Console.WriteLine("Maximum number of patients on " + (key1 + 1) + " is " + mn+"\n");
                        goto tag1;
                        //break;

                    case 3:

                        //Average;
                        double average = 0;
                        int count = array.Count();

                        for(int j = 0; j < count; j++)
                        {
                            average += array[j];
                        }
                        Console.WriteLine("Average number of patients are: " + (average /(double) count)+"\n");
                        goto tag1;
                        //break;

                    case 4:

                        //Sum;
                        int sum=0;
                        for (int k = 0; k < array.Count(); k++)
                        {
                            sum += array[k];
                        }
                        Console.WriteLine("Total number of patients are: " + sum+" in "+array.Count()+" days\n");
                        goto tag1;
                        //break;

                    case 5:

                        Console.WriteLine("Thank you");
                        Console.ReadKey();
                        break;

                    default:

                        Console.WriteLine("Enter a valid operation \n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Data");
            }

            Console.ReadKey();
        }

    }
}

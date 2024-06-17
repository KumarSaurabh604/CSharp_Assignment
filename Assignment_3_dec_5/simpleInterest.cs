using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_dec_5
{
        //Write a program to accept principal amount from user.Then based on user input for CI or SI, 
        //calculate CI/SI and display to user. (Take time and yearly ROI from user and user should have 
        //option to provide time either in years or months)


    class simpleInterest
    {
        public void Interest()
        {
            Console.WriteLine("Select an operation i.e press '1' for Simple Interest \n press '2' for Compound Interest \n press 3 for exit");
            int num;
            bool variable = int.TryParse(Console.ReadLine(), out num);

            if(variable == true)
            {
                switch (num)
                {
                    case 1:
                        SimpleInterest();
                        break;
                    case 2:
                        CompoundInterest();
                        break;
                    case 3:
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Please select a valid operation");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please select correct operation\n\n");
                Interest();
            }
            Console.ReadKey();

        }

        public void SimpleInterest()//calculate simple interest
        {
            //simple interest SI = (p*r*t)/100
            //r= R/100
            
            double SI = 0.0;
            Console.WriteLine("Enter principle amount");
            double principalAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter rate of interest");
            double rate = double.Parse(Console.ReadLine());


            Console.WriteLine("Select time 'y' for year and 'm' for month");
            char check = char.Parse(Console.ReadLine().ToLower());

            if(check == 'y')
            {
                Console.WriteLine("Enter time in year");
                double time = double.Parse(Console.ReadLine());
                SI = (principalAmount * rate * time) / 100;
            }
            else if(check == 'm')
            {
                Console.WriteLine("Enter time in months");
                double time = double.Parse(Console.ReadLine());
                SI = (principalAmount * rate * time) / (100*12);
            }
            else
            {
                Console.Write("\nInvalid selection of time\n\n");
            }

            Console.WriteLine("\nSimple Interest is: "+ SI+"\n\n");
            Interest();
        }

        public void CompoundInterest()//calculate compund interest
        {
            //A	=   final amount
            //P	=	initial principal balance
            //r =   interest rate
            //n =   number of times interest applied per time period
            //t =   number of time periods elapsed
            //    compund interest A = P(1 +  (r/n))^(nt)

            double CI = 0;
            Console.WriteLine("Enter principle amount");
            double principalAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter rate of interest");
            double rate = double.Parse(Console.ReadLine());
            rate = rate / 100;

            Console.WriteLine("Enter number of times interest applied per time period");
            double numberOfTimes = double.Parse(Console.ReadLine());

            Console.WriteLine("Select time 'y' for year and 'm' for month");
            char check = char.Parse(Console.ReadLine().ToLower());

            if (check == 'y')
            {
                Console.WriteLine("Enter time in year");
                double time = double.Parse(Console.ReadLine());
                CI = principalAmount * Math.Pow((1+(rate/numberOfTimes)),(time*numberOfTimes));
            }
            else if (check == 'm')
            {
                Console.WriteLine("Enter time in months");
                double time = double.Parse(Console.ReadLine());
                //time = time / 12;
                CI = principalAmount * Math.Pow((1 + (rate / numberOfTimes)), ((time/12) * numberOfTimes));
            }
            else
            {
                Console.Write("\nInvalid selection of time\n\n");
            }

            Console.WriteLine("\nSimple Interest is: " +CI + "\n\n");
            Interest();
        }
    }
}

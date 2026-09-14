using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Topic_5___If_Statements
{
    internal class Program
    {
        public static void Problem1()
        {
            Console.WriteLine("Please input a degree and I'll tell you if it's North, East, South, or West.");
            int degree = Convert.ToInt32(Console.ReadLine());
            if (degree >= 0 && degree <= 45 || degree <= 360 && degree >= 315)
            {
                Console.WriteLine("That's North!");
            }
            else if (degree >= 46 && degree <= 135)
            {
                Console.WriteLine("This is East!");
            }
            else if (degree >= 136 && degree <= 225)
            {
                Console.WriteLine("That's South!");
            }
            else if (degree >= 226 && degree < 360)
            {
                Console.WriteLine("This is West!");
            }
            else
            {
                Console.WriteLine("Invalid degree. Please enter a value between 0 and 360.");
                Problem1();
            }
        }
        public static void Problem2()
        {
            int minParked;
            Console.WriteLine("Hey how long have you parked in the parking garage for in minutes.");
            minParked = Convert.ToInt32(Console.ReadLine());
            if (minParked <= 60)
                Console.WriteLine("You will have to pay $4.00.");
            else if (minParked <= 120)
                Console.WriteLine("You will have to pay $6.00.");
            else if (minParked <= 180)
                Console.WriteLine("You will have to pay $8.00.");
            else if (minParked <= 240)
                Console.WriteLine("You will have to pay $10.00.");
            else if (minParked <= 300)
                Console.WriteLine("You will have to pay $12.00.");
            else if (minParked <= 360)
                Console.WriteLine("You will have to pay $14.00.");
            else if (minParked <= 420)
                Console.WriteLine("You will have to pay $16.00.");
            else if (minParked <= 480)
                Console.WriteLine("You will have to pay $18.00.");
            else
                Console.WriteLine("You have reached our max charge of $20.00 for the day.");
        }
        public static void Problem3()
        {
            int category;
            string unit;
            Console.WriteLine("Please input a category number between 1 and 5.");
            category = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now please say if you would like the speed in mph, kt, or km/hr.");
            unit = Console.ReadLine();
            switch (category)
            {
                case 1:
                    if (unit == "kt")
                    {
                        Console.WriteLine("You have selected category 1. The wind speeds are 64-82kt");
                    }
                    else if (unit == "km/hr")
                    {
                        Console.WriteLine("You have selected category 1. The wind speeds are 119-153km/hr");
                    }
                    else
                        Console.WriteLine("You have selected category 1. The wind speeds are 74-95mph");
                    break;
                case 2:
                    if (unit == "kt")
                    {
                        Console.WriteLine("You have selected category 2. The wind speeds are 83-95kt");
                    }
                    else if (unit == "km/hr")
                    {
                        Console.WriteLine("You have selected category 2. The wind speeds are 154-177km/hr");
                    }
                    else
                        Console.WriteLine("You have selected category 2. The wind speeds are 96-110mph");
                    break;
                case 3:
                    if (unit == "kt")
                    {
                        Console.WriteLine("You have selected category 3. The wind speeds are 96-113kt");
                    }
                    else if (unit == "km/hr")
                    {
                        Console.WriteLine("You have selected category 3. The wind speeds are 178-209km/hr");
                    }
                    else
                        Console.WriteLine("You have selected category 3. The wind speeds are 111-130mph");
                    break;
                case 4:
                    if (unit == "kt")
                    {
                        Console.WriteLine("You have selected category 4. The wind speeds are 114-135kt");
                    }
                    else if (unit == "km/hr")
                    {
                        Console.WriteLine("You have selected category 4. The wind speeds are 210-249km/hr");
                    }
                    else
                        Console.WriteLine("You have selected category 4. The wind speeds are 131-155mph");
                    break;
                case 5:
                    if (unit == "kt")
                    {
                        Console.WriteLine("You have selected category 5. The wind speeds are 135kt or higher");
                    }
                    else if (unit == "km/hr")
                    {
                        Console.WriteLine("You have selected category 5. The wind speeds are 249km/hr or higher");
                    }
                    else
                        Console.WriteLine("You have selected category 5. The wind speeds are 155mph or higher");
                    break;
                default:
                    Console.WriteLine("This is an invalid answer.");
                    break;
            }
        }
        static void Main(string[] args)
        {
            int problem;
            Console.WriteLine("Please select a problem to run. 1, 2, or 3.");
            problem = Convert.ToInt32(Console.ReadLine());
            if (problem == 1)
            {
                Problem1();
            }
            else if (problem == 2)
            {
                Problem2();
            }
            else if (problem == 3)
            {
                Problem3();
            }
            else
            {
                Console.WriteLine("Invalid selection. Please select 1, 2, or 3.");
                Main(args);
            }
        }
    }
}

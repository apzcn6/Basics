using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {

            const int sample1 = 0x3A;
            int sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;
            const float acceleration = 9.800F;
            float mass = 14.6F;
            double distance = 129.763001;
            bool lost = true;
            bool expensive = true;
            int choice = 2;
            const char integral = '\u222B';
            const string greeting = "Hello";
            string name = "Karen";

            if(sample1 == sample2){
                Console.WriteLine("They are equal");
            }
            else
            {
                Console.WriteLine("They are not");
            }
            if(heartRate>=40 || heartRate <= 80)
            {
                Console.WriteLine("Heart Rate is normal");
            } else
            {
                Console.WriteLine("Heart Rate is not normal");
            }
            if(deposits > 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor");
            }

            float force = mass * acceleration;
            Console.WriteLine("force = " +force);
            Console.WriteLine(distance + " is the distance");
            if (lost == true || expensive == true)
            {
                Console.WriteLine("I am really sorry! I will get my manager");
            }
            if (lost == true || expensive == false)
            {
                Console.WriteLine("Here is coupon for 10% off");
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Your choice is 1");
                    break;
                case 2:
                    Console.WriteLine("Your choice is 2");
                    break;
                case 3:
                    Console.WriteLine("Your choice is 3");
                    break;
                default:
                    Console.WriteLine("You made an unkown choice");
                    break;
            }
            
            for(int i = 5; i <= 10; i++)
            {
                Console.WriteLine("i=" + i);
            }
            int age = 0;
            while (age < 6)
            {
                Console.WriteLine("age = " + age);
                age++;
            }
            Console.WriteLine(greeting + " " + name);
            Console.ReadKey(true);

        }

    }
}

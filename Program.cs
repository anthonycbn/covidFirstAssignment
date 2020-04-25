using System;
using System.Collections.Generic;
namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string gender;
            string name;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            if (name.ToLower() == "ali" || name.ToLower() == "bob")
            {
                Console.WriteLine("Welcome " + name);
            }

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Hello " + name + " you are of eligible age, you can drink if you want to");
            }

            else
            {
                Console.WriteLine("Hi " + name + " sorry, you are a minor, no drink for you ");
            }

            Console.Write("Enter your gender: ");
            gender = Console.ReadLine();

            Console.WriteLine("Hi " + name + " you are " + age + " years old. Your gender is " + gender + "." );

        }
       
    }


}

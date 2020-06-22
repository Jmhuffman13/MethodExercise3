using System;
using System.Security.Cryptography.X509Certificates;

namespace MethodExercise3
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }
        public static int Multiply(int num1, int num2, int num3)
        {
            var answer = num1 * num2 * num3;
            return answer;
        }

        public static int Divide(int num1, int num2)
        {
            var answer = num1 / num2;
            return answer;
        }
        static void Main(string[] args)
        {
          
            Console.WriteLine($"What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"What is your favorite color?");
            var favColor = Console.ReadLine();

            Console.WriteLine($"Where are you from?");
            var userLocation = Console.ReadLine();

            Console.WriteLine($"How old are you?");
            var userAge = Console.ReadLine();

            Console.WriteLine($"Hello my name is {userName}, I am {userAge}. My favorite color is {favColor} and I am from {userLocation}.");



            

            

             

            
            
        }
    }
}

using System;

namespace TassKK3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int number;
           
            Console.Write("Divided number 46  \n ");
            
            number = Convert.ToInt32(Console.ReadLine());
           
            Console.Write("\nAll Number  \n");
            
            for (int i = 3; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i + " ");
                }
            }





        }
    }
}

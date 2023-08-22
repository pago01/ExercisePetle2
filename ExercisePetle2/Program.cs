using System;
using System.ComponentModel.Design;

namespace ExercisePetle2
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Calculation

            int a = 0;

            do
            {
                a = a + 2;
                Console.WriteLine(a);
            }
            while (a < 1000);
        }
    }
}

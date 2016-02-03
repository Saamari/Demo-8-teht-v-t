using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //luodaan oli Dice luokassta
            Dice dice = new Dice();
            
            Console.WriteLine("How many times u want throw the dice? ");
            
            string line = Console.ReadLine();
            int total = int.Parse(line);
            double sum = 0;
            for (int i = 1; i <= total; i++)
            {
                int rng = dice.Throw();
                Console.WriteLine("Number is {0}", rng);
                sum = sum + rng;
           
                

            }

            double average;
            average = sum / total;
            Console.WriteLine("Average is {0}", average);





        }
    }
}

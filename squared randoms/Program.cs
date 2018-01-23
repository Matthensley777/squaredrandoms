using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squared_randoms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            var randomNumber = new List<int>();

            var squaredNumbers = new List<int>();

            var evenNumbers = new List<int>();

            for (int i = 0; i < 19; i++)
            {
                randomNumber.Add(random.Next());
            }

            foreach( var number in randomNumber)
            {
                squaredNumbers.Add(number * number);
            }
            foreach (var item in squaredNumbers)
            {
                if(item % 2 == 0 )
                {
                    evenNumbers.Add(item);
                }
            }
            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

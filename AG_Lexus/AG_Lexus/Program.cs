using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSets_02
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program prints all the odd numbers from 1-20");
            {
                for (int i = 0; i < 20; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i); 
                    }
                }
            }
        }
        
    }
}










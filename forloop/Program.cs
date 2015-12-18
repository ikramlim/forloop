using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for(i=1; i<=5; i++)
            {
                for(j=1; j<= i; j++)
                {
                    Console.Write(j); //or can replace this to ("*")
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
/*
    1
    12
    123
    1234
    12345


    or

    *
    **
    ***
    ****
    *****
*/
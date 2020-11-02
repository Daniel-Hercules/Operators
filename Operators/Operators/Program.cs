using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adds
            int Total1 = 2 + 1;
            //Subtracts
            int Total2 = 2 - 1;
            //Multiplies
            int Total3 = 2 * 1;
            //Divides
            int Total4 = 2 / 1;
            //Divides until number 
            //being divided by cannot
            //go into remainder, then 
            //returns remainder.
            int Total5 = 2 % 1;
            //Increments by 1 
            int Total6 = 1;

            Total6 ++;
            //Decrements by 1
            int Total7 = 2;

            Total7 --;

            Console.WriteLine("Total 1 : " + Total1);
            Console.WriteLine("Total 2 : " + Total2);
            Console.WriteLine("Total 3 : " + Total3);
            Console.WriteLine("Total 4 : " + Total4);
            Console.WriteLine("Total 5 : " + Total5);
            Console.WriteLine("Total 6 : " + Total6);
            Console.WriteLine("Total 7 : " + Total7);
        }
    }
}

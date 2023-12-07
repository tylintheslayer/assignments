using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Milksong
    { 
        public static string Lyrics() 
        {
            //int milk = 100;

            for (int i = 99; i > 0; i--)
            {
                if (i >= 3)
                {
                    Console.WriteLine($"{i} bottle of milk on the wall, {i} bottles of milk");
                    Console.WriteLine($"Take one down and pass it around, {i - 1} bottles of milk");
                }
                if (i == 1)
                {
                    Console.WriteLine($"{i} bottle of milk on the wall, {i} bottle of milk");
                    break;
                }
                
                if (i == 2)
                {
                    Console.WriteLine($"{i} bottle of milk on the wall, {i} bottles of milk");
                    Console.WriteLine($"Take one down and pass it around, {i - 1} bottle of milk");
                }
                //milk--;
            }
            return "";
        }
    }
}

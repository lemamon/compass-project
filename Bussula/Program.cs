using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussula
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string coordinates = Console.ReadLine();
            int position = 0;
            string direction = "NLSO";
            string accumulator = "";

           
            foreach(char c in coordinates)
            {
                if(c == 'D' || c == 'd')
                {
                    position = position >= 3 ? 0 : position + 1;
                    accumulator += direction[position];
                   
                }else if(c == 'E' || c == 'e')
                {
                    position = position <= 0 ? 3 : position - 1;
                    accumulator += direction[position];
                }
            }

            Console.WriteLine(accumulator);
            Console.ReadLine();

        }
    }
}

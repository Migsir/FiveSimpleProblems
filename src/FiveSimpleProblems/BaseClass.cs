using System;
using System.Collections.Generic;
using System.Text;

namespace FiveSimpleProblems
{
    public class BaseClass
    {

        private void PrintMark(int characters) 
        {
            for (int i = 0; i < characters; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("-");
        }

        public void PrintTitle(string title)
        {
            PrintMark(title.Length + 3);
            Console.WriteLine($"| {title} |");
            PrintMark(title.Length + 3);
        }

        public void PrintFooter() 
        {
            Console.WriteLine("");
            Console.WriteLine("------------------------------");
        }

    }
}

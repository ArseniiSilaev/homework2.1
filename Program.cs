using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            bool isWork = true;
            while (isWork)
            {
                string newUserString = Console.ReadLine();
                if (newUserString == "exit") 
                {
                    isWork = false;
                }
            }
        }
    }
}

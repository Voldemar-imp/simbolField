using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            char simbol;
            int stringLength;
            string simbolField = ""; 

            Console.WriteLine("Введите слово: ");
            userInput = Console.ReadLine();
            stringLength = userInput.Length;
            Console.WriteLine("Введите символ: ");
            simbol = Convert.ToChar(Console.ReadLine());
            
            for (int i = 0; i < stringLength; i++)
            {
                simbolField += simbol; 
            }
            Console.Clear ();
            Console.WriteLine("{0}{1}{0}", simbol, simbolField);
            Console.WriteLine("{0}{1}{0}", simbol, userInput);
            Console.WriteLine("{0}{1}{0}", simbol, simbolField);

        }
    }
}

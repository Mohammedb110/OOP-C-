using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_
{

    class Calculator {
        private int Resulte = 0;

        public  void Add (int number)
        {
            Resulte += number;
                        
        }
        public void Substract(int number)
        {
            Resulte -= number;

        }
        public void Divide(int number)
        {
            if (number == 0)
            {
                number = 1;
            }
            Resulte /= number;

        }
        public void Multiply(int number)
        {
            Resulte *= number;

        }
        public void PrintResult()
        {
           Console.WriteLine(Resulte);

        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {
        Calculator calculator1 = new Calculator();
            calculator1.Add(5);
            calculator1.Add(10);
            calculator1.PrintResult();
                calculator1.Substract(3);
            calculator1.PrintResult();
                calculator1.Multiply(2);
            calculator1.PrintResult();
                calculator1.Divide(4);
            calculator1.PrintResult();
        }
    }
}

using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Saida s = new Saida();

            string resultado = s.CompararIdades();
            Console.WriteLine(resultado);

        }
    }
}


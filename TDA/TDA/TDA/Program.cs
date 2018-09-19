using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDALibrary;

namespace TDA
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circle = new Circulo();
            Console.WriteLine("Escribir el radio que del circulo");
            circle.Radio = Convert.ToDecimal(Console.ReadLine());
            circle.CalcularRadio(circle.Radio);
        }
    }
}

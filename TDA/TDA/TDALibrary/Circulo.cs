using System;

namespace TDALibrary
{
    public class Circulo
    {
        public decimal Radio { get; set; }
    
        public Circulo()
        {

        }

        public void CalcularRadio(decimal radio)
        {
            
             Console.WriteLine("Este es el Radio "+radio);
            Console.ReadKey();
        }
    }
}

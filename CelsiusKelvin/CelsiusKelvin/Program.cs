using System;

namespace CelsiusKelvin
{
    public class Program
    {
        static void Main(string[] args)
        {
            Kelvin kelvin = new Kelvin(12.3);
            Celsius celsius = kelvin;
            Console.WriteLine(celsius.Cels);
            
        }
    }

    public class Celsius
    {
        public double Cels { get; set; }

        public Celsius(double cels)
        {
            Cels = cels;
        }
    }

    public class Kelvin
    {
        public double Kel { get; set; }

        public Kelvin(double kel)
        {

            Kel = kel;
        }

        public static implicit operator Celsius(Kelvin kelvin)
        {
            Celsius celsius = new Celsius(kelvin.Kel + 273);
            return celsius;
            
        }

    }
}

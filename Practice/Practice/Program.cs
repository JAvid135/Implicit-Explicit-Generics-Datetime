using System;

namespace Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Manat manat = new Manat(100);
            //Dollar dollar = manat;
            //Console.WriteLine(dollar.Usd);

            //DateTime dateTime = DateTime.Now;
            //Console.WriteLine(dateTime.ToString("MM-dd-yyyy"));

            //DateTime dateTime = DateTime.UtcNow;
            //Console.WriteLine(dateTime.ToString("MM-dd-yyyy"));



        }
    }

    public class StringList
    {
        private string[] _arr;

        public StringList()
        {
            _arr = new string[0];
        }

        public void Add(string str)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length + 1] = str;
        }

        int[] test = { 1, 2, 3 };
    }



    public class Dollar
    {
        public double Usd { get; set; }

        public Dollar(double usd)
        {
            Usd = usd;
        }
    }

    public class Manat
    {
        public double Azn { get; set; }

        public Manat(double azn)
        {
            Azn = azn;
        }

        public static implicit operator Dollar(Manat manat)
        {
            //Dollar dollar = new Dollar(manat.Azn / 1.7);
            return new Dollar(manat.Azn / 1.7);
        }
    }
}

using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("imie: ");
            Console.WriteLine("sfv: ");
            /*fgbbf
             * bdfgdfb
             * gfbdf
             */
            /*
             * #
             * ##
             * ###
             * ####
             */
            Console.WriteLine("#");
            Console.WriteLine("##");
            Console.WriteLine("###");
            Console.WriteLine("####");

            Console.WriteLine("#\n##\n###\n####");

            string name;
            name = "swf";
            Console.WriteLine("\nmasz na imie: " + name);

            Console.WriteLine("masz na imie: {0}",name);

            int wiek = 12;

            Console.WriteLine("masz na imie: {0} , Masz: {1} lat",name, wiek);

            sbyte wiek1 = 123;

            Console.WriteLine("\nmasz na imie: {0} , Masz: {1} lat", name, wiek1);

            //obliczanie pola
            Console.Write("\npodaj bok a: ");
            string a = Console.ReadLine();

           // Console.WriteLine("a= {0}",a);
            double result = double.Parse(a) * double.Parse(a);
            Console.WriteLine("po wynosi: {0}",result);
            //pole trojkata

            Console.WriteLine("podaj x: ");
            string x = Console.ReadLine();
             Console.WriteLine("podqaja wysokosc h: ");
             string h = Console.ReadLine();
            double wynik = 0.5 * double.Parse(x) * double.Parse(h);
            Console.WriteLine("pole trojkata: {0}",wynik);




















            Console.ReadKey();


            //fhngf

        }
    }
}

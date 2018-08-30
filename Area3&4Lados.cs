using System;

namespace _30_08_2018
{
    class Program
    {
        static double ACuatroLados(double b, double h=0) {
            return h == 0 ? (b*b) : (b*h);
        }
        static double ATresLados( double h, double b = 0)
        {
            return b != 0 ? (b * h)/2 : ((Math.Sqrt(3)/4)*(h*h));
        }

        static short CapturarOpcion() {
            short r=0;
            string _test;
            do
            {
                Console.WriteLine("Opciones:\n1.Area para figura de 4 lados\n2.Area para figura de 3 lados");
                _test = Console.ReadLine();
            } while (_test !="1" && _test!="2" && _test != "");
            short.TryParse(_test, out r);
            return r;
        }

        static void Main(string[] args){
            Console.WriteLine("Hello World!");
            short op = CapturarOpcion();
            if (op != 0)
            {
                string _baseEnString, _alturaEnString;
                Console.WriteLine("digite base");
                _baseEnString = Console.ReadLine();
                Console.WriteLine("digite altura");
                _alturaEnString = Console.ReadLine();
                double _base, _altura;
                double.TryParse(_baseEnString, out _base);
                double.TryParse(_alturaEnString, out _altura);

                if (op == 1)
                {
                    Console.WriteLine(ACuatroLados(_base, _altura));
                }
                else if (op == 2)
                {
                    Console.WriteLine(ATresLados(_altura, _base));
                }
            }

            
            
            
            

            Console.ReadKey();
        }
    }
}

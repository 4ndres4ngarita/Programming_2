using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*  
     *  nombre: 
     *  fecha:23/08/2018
     *  descripcion: 
     */
    class Program
    {
        static void Main(string[] args)
        {
            int in1, in2;
            in1 = in2 = 0;

            in1 = int.Parse(Console.ReadLine());
            in2 = int.Parse(Console.ReadLine());

            holaMano();
            Console.WriteLine(holaMano2());

            #region Metodos
            int sumarNumeros() {
                in1 = 7;
                in2 = 9;
                int inResultado;
                inResultado = in1 + in2;
                return inResultado;
            }

            double SumarDosNumeros(double dou1, double dou2) {
                double douResultado;
                douResultado = dou1 + dou2;
                return douResultado;
            }

            void holaMano() {
                Console.WriteLine("Hola Mano en la funcion");
            }
            string holaMano2() {
                return "HolaMano 2";
            }
            #endregion

            Console.ReadKey();

        }
    }
}

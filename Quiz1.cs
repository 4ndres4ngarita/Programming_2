using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Autor: Andres Angarita
 * Fecha: 06/09/2018
 * Descripcion: 4 vendedores de pizza, el que venda en el dia tiene una comision extra del 1% sobre ese dia, siempre le corresponde una comision del 10%
*/

namespace Quiz_6_9_2018
{
    class Program
    {
        static void Comision(int[,] p_Matrizventas)
        {
            for (short i = 0; i < 4; i++)
            {
                int _porcentajeComision = p_Matrizventas[ i, 5];
                int _comisionTotal = ((Totalventas(p_Matrizventas, i) * 10) / 100) + _porcentajeComision;
                Console.WriteLine("comision empleado #"+(i+1)+" = $"+_comisionTotal+"000 COP");
            }
            
        }

        static int Totalventas(int[,] p_Matrizventas, short p_Vendedor)
        {
            int _totalventas=0;
            for (short dia = 0; dia < 5; dia++)
            {
                _totalventas += p_Matrizventas[ p_Vendedor, dia];
            }
            return _totalventas;
        }

        static int MasVendio(int[,] p_Matrizventas, short p_dia)
        {
            int _mayorPosicion=0, _mayorVenta=p_Matrizventas[0, p_dia];short i;
            for (i = 0; i < 4; i++)
            {
                if (p_Matrizventas[i, p_dia] >= _mayorVenta)
                {
                    _mayorVenta = p_Matrizventas[i, p_dia];
                    _mayorPosicion = i;
                }
            }
            p_Matrizventas[_mayorPosicion, 5] += (p_Matrizventas[ _mayorPosicion, p_dia]*1)/100;
            return _mayorPosicion;
        }

        static void Llenarmatriz(int[,] p_Matrizventas)
        {
            for (short dia = 0; dia < 5; dia++)
            {
                Console.WriteLine("Para ventas del dia:"+(dia+1));

                for (short empleado = 0; empleado < 4; empleado++)
                {
                    Console.WriteLine("Digite venta del empleado #"+(empleado+1)+ "en miles de pesos");
                    p_Matrizventas[empleado, dia] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("mayor ventas vendedor#"+MasVendio(p_Matrizventas, dia));
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("bienbenido:");
            int[,] _Matrizventas = new int[4, 6];//4: vendedores, 6:entre semana y comision c/u
            for (short j = 0; j < 4; j++)
            {
                _Matrizventas[j, 5] = 0;
            }
            Llenarmatriz(_Matrizventas);
            Comision(_Matrizventas);

            Console.ReadKey();
            
        }
    }
}

using System;
					
public class Program
{
	public static void Main()
	{	
		int _nMajor, _nMinor;
		
		
		Console.WriteLine("Cuantos datos existen?");
		int _cantidadNumeros = Int32.Parse(Console.ReadLine());
		int[] _n = new int[_cantidadNumeros];
		Console.WriteLine("Dato #1:");
		_n[0] = Int32.Parse(Console.ReadLine());
		_nMajor = _nMinor = _n[0];
		
		for(int i=1; i<_cantidadNumeros; i++){
			Console.WriteLine("Dato #"+(i+1)+":");
			_n[i] = Int32.Parse(Console.ReadLine());
			if(_n[i] < _nMinor){
				_nMinor = _n[i];
				Console.WriteLine("nuevo valor mínimo: '"+_nMinor+"'");
			}
			if(_n[i] > _nMajor){
				_nMajor = _n[i];
				Console.WriteLine("nuevo valor máximo: '"+_nMajor+"'");
			}
			
		}
		Console.WriteLine("\n Recoleccion de datos terminado :D");
		
		double _k = 1+(3.322*Math.Log10((double)_cantidadNumeros));
		Console.WriteLine("valor de k: '"+_k+"'");
		
		int _rango = _nMajor - _nMinor;
		Console.WriteLine("valor del Rango: '"+_rango+"'");
		
		int _amplitud = _rango / Int32.Parse(String.Concat(Math.Round(_k)));
		Console.WriteLine("valor del amplitud: '"+_amplitud+"'");
		
		for(int j=_nMinor,i=0; i<_k; i++){
			Console.Write("["+j);
			j += (_amplitud-1);
			Console.Write(","+j+")\n");
			j++;
		}
		
	}
}

using System;
					
public class Program
{	
	

	public class triangulo
	{	
		public double _base;
		public double _altura;

		public triangulo(double p_base, double p_altura)
		{
			_base = p_base;
			_altura = p_altura;
		}

		public double CalcularArea()
		{
			return (this._base * this._altura) / 2;
		}
	}

	public class cuadrado
	{	
		public double _lado;

		public cuadrado(double p_lado)
		{
			this._lado = p_lado;
		}

		public double CalcularArea()
		{
			return (this._lado * this._lado);
		}
	}

	public class rectangulo
	{	
		public double _base;
		public double _altura;

		public rectangulo(double p_base, double p_altura)
		{
			this._base = p_base;
			this._altura = p_altura;
		}

		public double CalcularArea()
		{
			return (this._base * this._altura);
		}
	}

	public class circulo
	{	
		public double _radio;
		public const double _Pi = 3.1416;

		public circulo(double p_radio)
		{
			this._radio = p_radio;
		}

		public double CalcularArea()
		{
			return _Pi * (this._radio * this._radio);
		}
	}
	
	public class Calculadora
	{	
		public char _opcion;

		public Calculadora()
		{
			this._opcion = ' ';
		}
		
		public void Encender()
		{
			this.CapturarOpcion();
			if(this._opcion !='4')
			{
				this.CalcularArea();
			}
		}
		
		public void CapturarOpcion()
		{
			do{
				Console.WriteLine("Hello World \n escoja la figura a la cual quiere calcular el area:");
				Console.WriteLine
				(
					"\t 1. triangulo \n" +
					"\t 2. cuadrado \n" +
					"\t 3. circulo \n" +
					"\t 4. salir\n"
				);
				this._opcion = char.Parse(Console.ReadLine());
				if(!this.validarOpcion())
				{ 
					Console.WriteLine("Opcion no valida");
				}
			}while(!this.validarOpcion());
		}
		
		public bool validarOpcion()
		{ 
			return 
				this._opcion == '1' || 
				this._opcion == '2' ||
				this._opcion == '3' || 
				this._opcion == '4' ? true : false;
		}
		
		public void CalcularArea()
		{	
			double _base, _altura;//_base puede ser tambien lado o radio
			_base = _altura = 0;
			switch(this._opcion)
			{
				case '1':
					Console.WriteLine("Base del triangulo: ");
					_base = double.Parse(Console.ReadLine());
					Console.WriteLine("Altura del triangulo: ");
					_altura = double.Parse(Console.ReadLine());
					triangulo T = new triangulo( _base, _altura);
					Console.WriteLine("area del triangulo: " + T.CalcularArea());
					break;
				case '2':
					Console.WriteLine("Base del rectangulo: ");
					_base = double.Parse(Console.ReadLine());
					Console.WriteLine("Altura del rectangulo: ");
					_altura = double.Parse(Console.ReadLine());
					if(_base == _altura)
					{
						cuadrado S = new cuadrado( _base);
						Console.WriteLine("area del cuadrado: " + S.CalcularArea());
					}else
					{
						rectangulo R = new rectangulo( _base, _altura);
						Console.WriteLine("area del rectangulo: " + R.CalcularArea());
					}
					Console.WriteLine();
					break;
				case '3':
					Console.WriteLine("radio del circulo: ");
					_base = double.Parse(Console.ReadLine());
					circulo C = new circulo( _base);
					Console.WriteLine("area del circulo: " + C.CalcularArea());
					break;
			}
		}
		
	}

	public static void Main()
	{	
		Calculadora casio = new Calculadora();
		casio.Encender();
		
	}
}

/*
 * Created by SharpDevelop.
 * User: SaenX
 * Date: 16/03/2022
 * Time: 2:36 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace eje_programacion
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("☻");
			
			// Numeros Enteros
			byte num1 = 30; // Definicion y asignación
			ushort num2 = 20000;
			int num3 = 50000;
			long num4; // Definición
			num4 = 6000000; // Asignación
			
			Console.WriteLine("El numero 1 es: " + num1);
			Console.WriteLine("El numero 2 es: " + num2);
			Console.WriteLine("El numero 3 es: " + num3);
			Console.WriteLine("El numero 4 es: " + num4);
			
			// Números decimales
			float peso = (float)50.5;
			double altura = 1.75;
			decimal promedio = (decimal)5.89;
			
			Console.WriteLine("El numero(Float) es: " + peso);
			Console.WriteLine("El numero(Double) es: " + altura);
			Console.WriteLine("El numero(Decimal) es: " + promedio);
			
			// Caracteres
			char genero = 'M';
			bool esAprendiz = true;
			
			Console.WriteLine("Genero> " + genero);
			Console.WriteLine("Es Aprendiz> " + esAprendiz);
			
			// Strings
			string nombre = "Anaelsa Rodriguez";
			string direccion = "Calle 5 # 3 - 123";
			
			Console.WriteLine("Nombre> " + nombre);
			Console.WriteLine("Dirección> " + direccion);
			
			const double PI = 3.1415;
			Console.WriteLine("PI> " + PI);
			
			Console.ReadKey(true);
		}
	}
}
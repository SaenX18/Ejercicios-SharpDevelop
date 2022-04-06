/*
 * Creado por SharpDevelop.
 * Usuario: SENA
 * Fecha: 16/03/2022
 * Hora: 4:13 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace eje03_programacion
{
	class Program
	{
		public static void Main(string[] args)
		{
			// 06 - Hacer un algoritmo que lea el nombre del articulo, el valor unitario y muestre el nombre del articulo y el total a pagar.
			string articulo;
			double valorUnitario, TotalPagar;
			int cantidad;
			
			Console.WriteLine("Cual es el articulo a comprar?");
			articulo = Console.ReadLine();
			Console.WriteLine("Cual es la cantidad a comprar?");
			cantidad = int.Parse(Console.ReadLine());
			Console.WriteLine("Cual es el valor unitario?");
			valorUnitario = int.Parse(Console.ReadLine());
			
			TotalPagar = valorUnitario + cantidad;
			
			Console.WriteLine("El total a pagar de: {0} es {1}", articulo, totalPagar);
			
			Console.ReadKey();
		}
	}
}
/*
 * Creado por SharpDevelop.
 * Usuario: SaenX
 * Fecha: 16/03/2022
 * Hora: 4:12 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace eje02_programacion
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nombre; // Definir/Declarar la variable
			Console.WriteLine("Digite su nombre: "); // Se muestra mensaje al usuario
			nombre = Console.ReadLine(); // Se captura el dato del usuario
			
			Console.WriteLine("Su nombre es: {0}", nombre);
			//--------------------------------------------------------------------------
			//INT
			int edad;
			Console.WriteLine("Cual es su edad?:");
			edad = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Su edad es: {0}", edad);
			//--------------------------------------------------------------------------
			// Double
			Double peso;
			Console.WriteLine("Cual es su peso?:");
			peso = Double.Parse(Console.ReadLine());
			
			Console.WriteLine("Su peso es: {0}", peso);
			//--------------------------------------------------------------------------
			
			
		}
	}
}
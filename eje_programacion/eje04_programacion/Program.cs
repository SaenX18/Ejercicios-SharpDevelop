using System;

namespace eje04_programacion
{
	class Program
	{
		public static void Main(string[] args)
		{
			/* 06.Algoritmo que lea el nombre de un articulo,la cantidad a comprar, el valor unitario y muestre el nombre y el total a pagar */
			string articulo;
			int cantidad;
			double valor, total;

			Console.WriteLine("Que articulo va a comprar");
			articulo = Console.ReadLine();

			Console.WriteLine("Cuantos va a comprar");
			cantidad = int.Parse(Console.ReadLine());

			Console.WriteLine("Cual es el valor unitario de este articulo");
			valor = double.Parse(Console.ReadLine());

			total = valor * cantidad;

			Console.WriteLine("Usted va a comprar {0} y el total a pagar es {1}", articulo, total);

			/* 07.Hacer un algoritmo para sumar dos numeros, los cuales serán tecleados por el usuario, Mostrar el resultado. */
			double primerNumero, total;
			int segundoNumero;
			
			Console.WriteLine("Ingrese el primer numero:");
			primerNumero = Double.Parse(Console.ReadLine());
			Console.WriteLine("Ingresar el segundo numero:");
			segundoNumero = int.Parse(Console.ReadLine());
			
			total = primerNumero + segundoNumero;
			
			Console.WriteLine("El resultado es: {0}", total);

			/* 08.Hacer un algoritmo que lea el nombre de una persona y número de horas que estudia en la semana. */
			string nombre;
			int horas;

			Console.WriteLine("Digite su nombre: "); 
			nombre = Console.ReadLine();

			Console.WriteLine("Numero de horas que estudia:");
			horas = int.Parse(Console.ReadLine());

			Console.WriteLine("Su nombre es: {0}", nombre);
			Console.WriteLine("Numero de horas que estudia: {0}", horas);

			/* 09.Hacer un algoritmo que lea el nombre de un estudiante, la cantidad de materias perdidas y la cantidad de materias ganadas. */
			string nombre;
			int materiasP, materiasG;

			Console.WriteLine("Numero de materias perdidas: ");
			materiasP = int.Parse(Console.ReadLine());

			Console.WriteLine("Numero de materias ganadas: ");
			materiasG = int.Parse(Console.ReadLine());

			Console.WriteLine("Digite su nombre: ");
			nombre = Console.ReadLine();

			Console.WriteLine("Su nombre es: {0}", nombre);
			Console.WriteLine("Numero de materias ganadas: {0}", materiasG);
			Console.WriteLine("Numero de materias perdidas: {0}", materiasP);

			Console.ReadKey();
		}
	}
}
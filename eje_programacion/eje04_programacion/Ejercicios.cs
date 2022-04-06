using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_programacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10.Hacer un algoritmo que lea el alto y el ancho de un rect�ngulo y muestre su �rea y su per�metro. */
            double alto;
            double ancho;
            double area;
            double perimetro;

            Console.WriteLine("digite el valor para el alto del rectangulo");
            alto = double.Parse(Console.ReadLine());

            Console.WriteLine("digite el valor para el ancho del rectangulo");
            ancho = double.Parse(Console.ReadLine());

            area = ancho * alto;
            perimetro = (ancho + alto) * 2;

            Console.WriteLine("el area del rectangulo es {0}", area);
            Console.WriteLine("el perimetro del rectangulo es {0}", perimetro);

            /* 11.Hacer un algoritmo que lea dos n�meros enteros A y B y muestre su diferencia. */
            int num1, num2, diferencia;

            Console.WriteLine("Digite el valor del primer n�mero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor del segundo n�mero");
            num2 = int.Parse(Console.ReadLine());

            diferencia = num1 - num2;

            Console.WriteLine("La diferencia entre {0} y {1} es: ", num1, num2);

            /* 12.Hacer un algoritmo que lea el nombre de una persona, el valor de la hora trabajada y el n�mero de horas que trabaj�. Se debe mostrar el nombre y el pago de la persona. */
            string nombre;
            double val_hora, num_horas, pago;

            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el valor de la hora trabajada");
            val_hora = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el n�mero de horas que trabaj�");
            num_horas = double.Parse(Console.ReadLine());

            pago = num_horas * val_hora;

            Console.WriteLine("Su nombre es {0} y su pago es de: ${1} ", nombre, pago);

            /* 13.Pedir el radio de un c�rculo y calcular su �rea. A=PI*r^2. */
            double radio, area;

            Console.WriteLine("Digite el valor del radio de un circulo para calcular su �rea");
            radio = double.Parse(Console.ReadLine());

            area = Math.PI * radio ^ 2;

            Console.WriteLine("El �rea del circulo es {0} ", area);

            /* 14.Pedir el radio de una circunferencia y calcular su longitud. */
            double radio, longitud;

            Console.WriteLine("Digite el valor del radio de un circulo para calcular su longitud");
            radio = double.Parse(Console.ReadLine());

            longitud = 2 * Math.PI * radio;

            Console.WriteLine("La longitud del circulo es {0} ", longitud);

            /* 15.Pedir el lado de un cuadrado, mostrar su �rea y su per�metro. */
            double lado, area, perimetro;

            Console.WriteLine("Digite el valor del lado de un cuadrado");
            lado = double.Parse(Console.ReadLine());

            area = lado * lado;
            perimetro = lado * 4;

            Console.WriteLine("El �rea del cuadrado es {0} y el per�metro es {1}", area, perimetro);

            /* 16.Calcular el �rea de un rect�ngulo de lados X e Y. */
            double ladoX, ladoY, area;

            Console.WriteLine("Digite el valor del lado X de un rect�ngulo");
            ladoX = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor del lado Y de un rect�ngulo");
            ladoY = double.Parse(Console.ReadLine());

            area = ladoX * ladoY;

            Console.WriteLine("El �rea del rect�ngulo es {0}", area);

            /* 17.Pedir dos n�meros y decir si son iguales o no. */
            double num1, num2;

            Console.WriteLine("Digite un n�mero cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro n�mero cualquiera");
            num2 = double.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Estos n�meros son iguales");
            }
            else
            {
                Console.WriteLine("Estos n�meros son diferentes");
            }

            /* 18.Pedir un n�mero e indicar si es positivo o negativo. */
            double num;

            Console.WriteLine("Digite un n�mero cualquiera");
            num = double.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine("Este n�mero es positivo");
            }
            else
            {
                Console.WriteLine("Este n�mero es negativo");
            }

            /* 19.Pedir dos n�meros y decir si uno es m�ltiplo del otro. */
            double num1, num2, resultado;

            Console.WriteLine("Digite un numero cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro numero cualquiera");
            num2 = double.Parse(Console.ReadLine());

            resultado = num1 * num2;

            Console.WriteLine("{0} multiplicado {1} es {2}", num1, num2, resultado);

            if (resultado % num1 = 0)
            {
                Console.WriteLine("{0} es m�ltiplo de {1} y {2}", resultado, num1, num2);
            }
            else
            {
                Console.WriteLine("{0} no es m�ltiplo de {1} y {2}", resultado, num1, num2);
            }

            /* 20.Pedir dos n�meros y decir cu�l es el mayor. */
            double num1, num2;

            Console.WriteLine("Digite un n�mero cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro n�mero cualquiera");
            num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("{0} es mayor que {1}", num1, num2);
            }
            else if (num1 == num2)
            {
                Console.WriteLine("{0} y {1} son iguales", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} es mayor que {1}", num2, num1);
            }

            /* 21.Pedir dos n�meros y decir cu�l es el mayor o si son iguales. */
            double num1, num2;

            Console.WriteLine("Digite un n�mero cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro n�mero cualquiera");
            num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("{0} es mayor que {1}", num1, num2);
            }
            else if (num1 == num2)
            {
                Console.WriteLine("{0} y {1} son iguales", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} es mayor que {1}", num2, num1);
            }

            /* 22.Pedir dos n�meros y mostrarlos ordenados de mayor a menor. */
            double num1, num2;

            Console.WriteLine("Digite un n�mero cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro n�mero cualquiera");
            num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("El orden de mayor a menor es {0} , {1}", num1, num2);
            }
            else if (num1 == num2)
            {
                Console.WriteLine("{0} y {1} son iguales", num1, num2);
            }
            else
            {
                Console.WriteLine("El orden de mayor a menor es {0} , {1}", num2, num1);
            }

            /* 23.Pedir tres n�meros y mostrarlos ordenados de mayor a menor. */
            double num1, num2, num3;

            Console.WriteLine("Digite un n�mero cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro n�mero cualquiera");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro n�mero cualquiera");
            num3 = double.Parse(Console.ReadLine());

            if (num1 > num2 > num3)
            {
                Console.WriteLine("El orden de mayor a menor es {0} , {1} , {2}", num1, num2, num3);
            }
            else if (num1 == num2 == num3)
            {
                Console.WriteLine("{0} , {1} y {2} son iguales", num1, num2, num3);
            }
            else
            {
                Console.WriteLine("El orden de mayor a menor es {0} , {1} , {2}", num3, num2, num1);
            }

            Console.ReadKey();
        }
    }
}
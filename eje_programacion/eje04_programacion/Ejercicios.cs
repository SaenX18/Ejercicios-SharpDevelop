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
            /* 10.Hacer un algoritmo que lea el alto y el ancho de un rectángulo y muestre su área y su perímetro. */
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

            /* 11.Hacer un algoritmo que lea dos números enteros A y B y muestre su diferencia. */
            int num1, num2, diferencia;

            Console.WriteLine("Digite el valor del primer número");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor del segundo número");
            num2 = int.Parse(Console.ReadLine());

            diferencia = num1 - num2;

            Console.WriteLine("La diferencia entre {0} y {1} es: ", num1, num2);

            /* 12.Hacer un algoritmo que lea el nombre de una persona, el valor de la hora trabajada y el número de horas que trabajó. Se debe mostrar el nombre y el pago de la persona. */
            string nombre;
            double val_hora, num_horas, pago;

            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el valor de la hora trabajada");
            val_hora = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de horas que trabajó");
            num_horas = double.Parse(Console.ReadLine());

            pago = num_horas * val_hora;

            Console.WriteLine("Su nombre es {0} y su pago es de: ${1} ", nombre, pago);

            /* 13.Pedir el radio de un círculo y calcular su área. A=PI*r^2. */
            double radio, area;

            Console.WriteLine("Digite el valor del radio de un circulo para calcular su área");
            radio = double.Parse(Console.ReadLine());

            area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine("El área del circulo es: ", area);

            /* 14.Pedir el radio de una circunferencia y calcular su longitud. */
            double radio, longitud;

            Console.WriteLine("Digite el valor del radio de un circulo para calcular su longitud");
            radio = double.Parse(Console.ReadLine());

            longitud = 2 * Math.PI * radio;

            Console.WriteLine("La longitud del circulo es {0} ", longitud);

            /* 15.Pedir el lado de un cuadrado, mostrar su área y su perímetro. */
            double lado, area, perimetro;

            Console.WriteLine("Digite el valor del lado de un cuadrado");
            lado = double.Parse(Console.ReadLine());

            area = lado * lado;
            perimetro = lado * 4;

            Console.WriteLine("El área del cuadrado es {0} y el perímetro es {1}", area, perimetro);

            /* 16.Calcular el área de un rectángulo de lados X e Y. */
            double ladoX, ladoY, area;

            Console.WriteLine("Digite el valor del lado X de un rectángulo");
            ladoX = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor del lado Y de un rectángulo");
            ladoY = double.Parse(Console.ReadLine());

            area = ladoX * ladoY;

            Console.WriteLine("El área del rectángulo es {0}", area);

            /* 17.Pedir dos números y decir si son iguales o no. */
            double num1, num2;

            Console.WriteLine("Digite un número cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro número cualquiera");
            num2 = double.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Estos números son iguales");
            }
            else
            {
                Console.WriteLine("Estos números son diferentes");
            }

            /* 18.Pedir un número e indicar si es positivo o negativo. */
            double num;

            Console.WriteLine("Digite un número cualquiera");
            num = double.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine("Este número es positivo");
            }
            else
            {
                Console.WriteLine("Este número es negativo");
            }

            /* 19.Pedir dos números y decir si uno es múltiplo del otro. */
            double num1, num2, resultado;

            Console.WriteLine("Digite un numero cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro numero cualquiera");
            num2 = double.Parse(Console.ReadLine());

            resultado = num1 * num2;

            Console.WriteLine("{0} multiplicado {1} es {2}", num1, num2, resultado);

            if (resultado % num1 = 0)
            {
                Console.WriteLine("{0} es múltiplo de {1} y {2}", resultado, num1, num2);
            }
            else
            {
                Console.WriteLine("{0} no es múltiplo de {1} y {2}", resultado, num1, num2);
            }

            /* 20.Pedir dos números y decir cuál es el mayor. */
            double num1, num2;

            Console.WriteLine("Digite un número cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro número cualquiera");
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

            /* 21.Pedir dos números y decir cuál es el mayor o si son iguales. */
            double num1, num2;

            Console.WriteLine("Digite un número cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro número cualquiera");
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

            /* 22.Pedir dos números y mostrarlos ordenados de mayor a menor. */
            double num1, num2;

            Console.WriteLine("Digite un número cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro número cualquiera");
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

            /* 23.Pedir tres números y mostrarlos ordenados de mayor a menor. */
            double num1, num2, num3;

            Console.WriteLine("Digite un número cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro número cualquiera");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro número cualquiera");
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
            consola _ WriteLine(" ejercicio 24 ");

            Console.WriteLine("ejercicio 24");

            /* 24.Pedir un número entre 0 y 9.999 y decir cuántas cifras tiene. */
            double num1;

            Console.WriteLine("digite un numero entre 0 y 9.999");
            num1 = double.Parse(Console.ReadLine());

            if (num1 > 0 & num1 < 9)
            {
                Console.WriteLine("el numero tiene 1 cifra");
            }
            if (num1 > 10 & num1 < 99)
            {
                Console.WriteLine("el numero tiene 2 cifra");
            }
            if (num1 > 100 & num1 < 999)
            {
                Console.WriteLine("el numero tiene 3 cifra");
            }
            if (num1 > 1000 & num1 < 9999)
            {
                Console.WriteLine("el numero tiene 4 cifra");
            }
        }

            /* 25.Pedir una nota de 0 a 5 y mostrarla de la forma: Insuficiente (0 – 2,9), Suficiente (3 – 4,5) y Bien (4,6 – 5) */
            double num1;

                Console.WriteLine("digite su nota");
                num1 = double.Parse(Console.ReadLine());

                if(num1 >= 0 && num1< 3) {
                    Console.WriteLine("la nota es insuficiente");
                }else if(num1 >= 3 && num1< 4.6) {
                    Console.WriteLine("la nota es suficiente");
            }else if (num1 >= 4.6 && num1 <= 5)
            {
                Console.WriteLine("la nota es bien");
            }
            else
            {
                Console.WriteLine("Rando incorecto");
            }
        }
            /* 26.Pedir una nota numérica entera entre 0 y 10, y mostrar dicha nota de la forma: cero, uno, dos, tres. */

            bool validacion = double.TryParse(Console.ReadLine(), out nota);
            if (validacion == false)
            {
            (Console.WriteLine("La nota ingresada es incorrecta");
            }

            Console.WriteLine("digite su nota entre 0 y 10");
            num1 = int.Parse(Console.ReadLine());

            case 0: {
                Console.WriteLine("cero");
            }
            if(num1 == 1) {
                Console.WriteLine("uno");
            }
            if(num1 == 2) {
                Console.WriteLine("dos");
            }
            if(num1 == 3) {
                Console.WriteLine("tres");
            }
            default:
                Console.WriteLine("Nota incorrecta.")

            /* 27.Pedir un número y decir si es par o impar. */
            double num1;

            Console.WriteLine("digite su numero");
            num1 = double.Parse(Console.ReadLine());

            if((num1 % 2) == 0){
                Console.WriteLine("es un numero par");
            }else{
                Console.WriteLine("no es un numero par");
            }
        }

            /* 28.Un trabajador recibe su pago, según la cantidad de horas trabajadas y su valor. Si la cantidad de
            horas trabajadas es mayor que 40, éstas se consideran horas extra, y tienen un incremento de $10000
            (diez mil) sobre el valor de la hora. Calcular y mostrar el salario (pago) del trabajador. Nota: leer horas
            trabajadas y valor de la hora. */
            double horas_trabajadas, valor_hora, horas_extras;
                
            Console.WriteLine("Digite el valor de la hora");
            valor_hora = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite la cantidad de horas trabajadas:");
            bool validacion = double.TryParse(Console.ReadLine(), out horas_trabajadas);

            salario = horas_trabajadas * valor_hora;

            if (horas_trabajadas > 40)
            {
                horas_extras = horas_trabajadas - 40;
                salario = salario + horas_extras * 10000;
                Console.WriteLine("Tiene {0} horas extras", horas_extras);
            }

            Console.WriteLine("El salario es: {0}", salario);

    Console.ReadKey();
        }
    }
}
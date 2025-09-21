using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_T1
{
    internal class Program
    {
        static void Main(string[] args)
        {

                
                ejer1();
                Console.ReadKey();

                ejer2();
                Console.ReadKey();
            }

            // Ejercicio 1 
            static void ejer1()
            {
                // Declaramos Variables
                double precio = 0.0;
                double descuento = 0.0;
                double precioFinal = 0.0;
                int codigo = 0;

                Console.Write("Ingrese el precio del producto: ");
                precio = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el código de descuento (1=Estudiante, 2=Empleado, 3=Cliente frecuente): ");
                codigo = int.Parse(Console.ReadLine());

                //Descuento
                switch (codigo)
                {
                    case 1:
                        descuento = 0.10;
                        break;
                    case 2:
                        descuento = 0.15;
                        break;
                    case 3:
                        descuento = 0.20;
                        break;
                    default:
                        Console.WriteLine("Código inválido, no se aplica descuento.");
                        descuento = 0.0;
                        break;
                }

                // Aplicar descuento
                precioFinal = precio - (precio * descuento);

                // Descuento adicional 
                if (precio > 500)
                {
                    precioFinal = precioFinal - (precioFinal * 0.05);
                }

                Console.WriteLine("El precio final es: " + precioFinal.ToString("F2"));
            }

            // Ejercicio 2
            static void ejer2()
            {
                // Declaramos Variables
                int nota = 0;
                string clasificacion = "";

                Console.Write("Ingrese una nota (0-20): ");
                
                nota = int.Parse(Console.ReadLine());
                if (nota < 0 || nota > 20)
                {
                    Console.WriteLine("Ingrese una nota valida.");
                    Environment.Exit(0);
                }

                // Clasificamos
                if (nota >= 0 && nota <= 10)
                {
                    clasificacion = "Desaprobado";
                }
                else if (nota >= 11 && nota <= 13)
                {
                    clasificacion = "Regular";
                }
                else if (nota >= 14 && nota <= 17)
                {
                    clasificacion = "Bueno";
                }
                else // 18-20
                {
                    clasificacion = "Excelente";
                }

                Console.WriteLine("Clasificación: " + clasificacion);

                // Condicionales 
                if (nota >= 14 && nota % 2 == 0)
                {
                    Console.WriteLine("Buen desempeño con nota par");
                }

                if (nota % 2 != 0 || nota <= 11)
                {
                    Console.WriteLine("Necesita reforzar");
                }

                // Cálculos
                double raiz = Math.Sqrt(nota);
                double cubo = Math.Pow(nota, 3);

                Console.WriteLine("Raíz cuadrada: " + raiz.ToString("0.0"));
                Console.WriteLine("Cubo de la nota: " + cubo.ToString());
            }
}
    }


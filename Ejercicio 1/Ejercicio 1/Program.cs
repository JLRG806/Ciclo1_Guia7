using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;

                //Declaración de variables a usar.
                double x, y;
                string opcion,estado = "n";
                       

                do
                {
                    Console.Clear();
                    Console.WriteLine("\t**********************************************************");
                    Console.WriteLine("\t*                                                        *");
                    Console.WriteLine("\t*                          MENÚ                          *");
                    Console.WriteLine("\t*                                                        *");
                    Console.WriteLine("\t**********************************************************");
                    Console.WriteLine("\t* A- Seno de x.                                          *");
                    Console.WriteLine("\t* B- Coseno de x.                                        *");
                    Console.WriteLine("\t* C- Tangente de x.                                      *");
                    Console.WriteLine("\t* D- Raiz cuadrada de x.                                 *");
                    Console.WriteLine("\t* E- Potencia de Y^x                                     *");
                    Console.WriteLine("\t* F- Verificar si un número es par o impar.              *");
                    Console.WriteLine("\t* G- Salir del programa                                  *");
                    Console.WriteLine("\t*                                                        *");
                    Console.WriteLine("\t**********************************************************");
                    Console.WriteLine(" ");
                    Console.WriteLine("SELECCIONA LA LETRA CORREPONDIENTE AL PROCESO MATEMATICO DESEADO: ");
                    opcion = Console.ReadLine();
                    Console.Clear();
                    switch (opcion)
                    {
                        case "A":
                            //Seno de x.
                            Console.WriteLine("\nDigite el numero en x :");
                            //Entrada de datos x.
                            x = Double.Parse(Console.ReadLine());

                            Console.WriteLine("\nSeno de X = " + Math.Sin(x));
                            Console.ReadKey();
                            break;
                        case "B":
                            //Coseno de x.
                            Console.WriteLine("\nDigite el numero en x :");
                            //Entrada de datos x.
                            x = Double.Parse(Console.ReadLine());

                            Console.WriteLine("\nCoseno de X = " + Math.Cos(x));
                            Console.ReadKey();
                            break;
                        case "C":
                            //Tangente de x.
                            Console.WriteLine("\nDigite el numero en x :");
                            //Entrada de datos x.
                            x = Double.Parse(Console.ReadLine());

                            Console.WriteLine("\nTangente de X = " + Math.Cos(x));
                            Console.ReadKey();
                            break;
                        case "D":
                            //Raiz cuadrada de x.
                            Console.WriteLine("\nDigite el numero en x :");
                            //Entrada de datos x.
                            x = Double.Parse(Console.ReadLine());

                            Console.WriteLine("\nRaíz cuadrada de X = " + Math.Sqrt(x));
                            Console.ReadKey();
                            break;
                        case "E":
                            //Potencia de Y^x.
                            Console.WriteLine("\nDigite el numero en Y :");
                            //Entrada de datos x.
                            y = Double.Parse(Console.ReadLine());
                            Console.WriteLine("\nDigite laa potencia de x en el numero Y :");
                            //Entrada de datos Y.
                            x = Double.Parse(Console.ReadLine());

                            Console.WriteLine($"\nPotencia de {y}^{x}  = " + Math.Pow(y, x));
                            Console.ReadKey();
                            break;
                        case "F":
                            //Verificar si un número es par o impar.
                            Console.WriteLine("\nDigite el numero en x :");
                            //Entrada de datos x.
                            x = Double.Parse(Console.ReadLine());


                            if ((x % 2) == 0)
                            {
                                Console.WriteLine($"\nEl numero {x}  = Es par");

                            }
                            else
                            {
                                Console.WriteLine($"\nEl numero {x}  = Es impar");
                            }

                            Console.ReadKey();
                            break;
                        case "G":
                            Console.WriteLine("\n¿Desea salir del sistema?");
                            Console.WriteLine("\n[s]/[n]");
                            //Entrada de datos estado.
                            estado = Console.ReadLine();

                            if (estado == "n")
                            {
                                Console.WriteLine("\nPuede continuar con la sesión");
                                Console.ReadKey();
                            }
                        
                            break;

                        default:
                            Console.WriteLine("\nDigite una opción valida");
                            Console.ReadKey();
                            break;
                    }

                } while (estado == "n");
                Console.ReadKey();


        }
    }
}

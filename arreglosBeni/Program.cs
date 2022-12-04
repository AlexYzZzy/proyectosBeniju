using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglosBeni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO");
            Console.WriteLine("esto es un programa de vectores");
            int opcion = 0;
            while (opcion != 8)
                //este es el menu principal para realizar algun movimiento
            {
                Console.WriteLine("\n1. intercambio de elemento de vectores");
                Console.WriteLine("2. Averiguar si una lista de numeros esta ordenada de menor a mayor");
                Console.WriteLine("3. Averiguar si una lista de numeros esta ordenada de manera estrictamente creciente");
                Console.WriteLine("4. Averiguar si una lista de numeros tiene numeros repetidos");
                Console.WriteLine("5. Ordenar de menor a mayor una lista de numeros");
                Console.WriteLine("6. Buscar si esta un numero en especifico de una lista de numeros");
                Console.WriteLine("7. Hallar el promedio de elementos de un vector");
                Console.WriteLine("8. Salir");
                Console.WriteLine("seleccione 1 de las opciones");
                //en esta parte del codigo empezamos a meter el switch con su respectivo case
                //cabe decir que usamos try catch para algunas excepciones
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            {
                                try
                                {
                                    Console.WriteLine("Ingrese el tamaño del vector");
                                    int tam = Convert.ToInt32(Console.ReadLine());
                                    int[] vector = new int[tam];
                                    for (int i = 0; i < tam; i++)
                                    {
                                        Console.WriteLine("Ingrese un numero");
                                        vector[i] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    Console.WriteLine("El vector original es: ");
                                    for (int i = 0; i < tam; i++)
                                    {
                                        Console.Write(vector[i] + " ");
                                    }
                                    Console.WriteLine("\nEl vector invertido es: ");
                                    for (int i = tam - 1; i >= 0; i--)
                                    {
                                        Console.Write(vector[i] + " ");
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Valor no valido");
                                }
                            }
                            break;
                        case 2:
                            {
                                try
                                {
                                    Console.WriteLine("Ingrese el tamaño de la lista");
                                    int tam = Convert.ToInt32(Console.ReadLine());
                                    int[] vector = new int[tam];
                                    for (int i = 0; i < tam; i++)
                                    {
                                        Console.WriteLine("Ingrese un numero");
                                        vector[i] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    int cont = 0;
                                    for (int i = 0; i < tam - 1; i++)
                                    {
                                        if (vector[i] <= vector[i + 1])
                                        {
                                            cont++;
                                        }
                                    }
                                    Console.WriteLine("La lista de numeros ingresada es: ");
                                    for (int i = 0; i < tam; i++)
                                    {
                                        Console.Write(vector[i] + " ");
                                    }
                                    if (cont == tam - 1)
                                    {
                                        Console.WriteLine("\nLa lista esta ordenado de menor a mayor");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nLa lista no esta ordenado de menor a mayor");
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Valor no valido");
                                }
                            }
                            break;
                        case 3:
                            {
                                try
                                {
                                    Console.WriteLine("Ingrese el tamaño de la lista");
                                    int tam = Convert.ToInt32(Console.ReadLine());
                                    int[] vector = new int[tam];
                                    for (int i = 0; i < tam; i++)
                                    {
                                        Console.WriteLine("Ingrese un numero");
                                        vector[i] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    int cont = 0;
                                    for (int i = 0; i < tam - 1; i++)
                                    {
                                        if (vector[i] < vector[i + 1])
                                        {
                                            cont++;
                                        }
                                    }
                                    Console.WriteLine("La lista de numeros ingresada es: ");
                                    for (int i = 0; i < tam; i++)
                                    {
                                        Console.Write(vector[i] + " ");
                                    }
                                    if (cont == tam - 1)
                                    {
                                        Console.WriteLine("\nLa lista esta ordenado de manera estrictamente creciente");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nLa lista no esta ordenado de manera estrictamente creciente");
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Valor no valido");
                                }
                            }
                            break;
                        case 4:
                            //usamos los "for" para poder no tener muchos errores
                            {
                                try
                                {
                                    Console.WriteLine("Ingrese el tamaño de la lista");
                                    int tam = Convert.ToInt32(Console.ReadLine());
                                    int[] vector = new int[tam];
                                    for (int i = 0; i < tam; i++)
                                    {
                                        Console.WriteLine("Ingrese un numero");
                                        vector[i] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    int cont = 0;
                                    for (int i = 0; i < tam - 1; i++)
                                    {
                                        for (int j = i + 1; j < tam; j++)
                                        {
                                            if (vector[i] == vector[j])
                                            {
                                                cont++;
                                            }
                                        }
                                    }
                                    Console.WriteLine("La lista de numeros ingresada es: ");
                                    for (int i = 0; i < tam; i++)
                                    {
                                        Console.Write(vector[i] + " ");
                                    }
                                    if (cont > 0)
                                    {
                                        Console.WriteLine("\nLa lista tiene numeros repetidos,los cuales son: ");
                                        for (int i = 0; i < tam - 1; i++)
                                        {
                                            for (int j = i + 1; j < tam; j++)
                                            {
                                                if (vector[i] == vector[j])
                                                {
                                                    Console.Write(vector[i] + " ");
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nLa lista no tiene numeros repetidos");
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Valor no valido");
                                }
                            }
                            break;
                        case 5:
                            {
                                try
                                {
                                    Console.WriteLine("Ingrese el tamaño de la lista");
                                    int tam = Convert.ToInt32(Console.ReadLine());
                                    int[] vector = new int[tam];
                                    for (int i = 0; i < tam; i++)
                                    {
                                        Console.WriteLine("Ingrese un numero");
                                        vector[i] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    int aux;
                                    for (int i = 0; i < tam - 1; i++)
                                    {
                                        for (int j = i + 1; j < tam; j++)
                                        {
                                            if (vector[i] > vector[j])
                                            {
                                                aux = vector[i];
                                                vector[i] = vector[j];
                                                vector[j] = aux;
                                            }
                                        }
                                    }
                                    Console.WriteLine("\nLa lista ordenada de menor a mayor es: ");
                                    for (int i = 0; i < tam; i++)
                                    {
                                        Console.Write(vector[i] + " ");
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Valor no valido");
                                }
                            }
                            break;
                        case 6:
                            {
                                try
                                {
                                    Console.WriteLine("Ingrese el tamaño de la lista");
                                    int tam = Convert.ToInt32(Console.ReadLine());
                                    int[] vector = new int[tam];
                                    for (int i = 0; i < tam; i++)
                                    {
                                        Console.WriteLine("Ingrese un numero");
                                        vector[i] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    Console.WriteLine("Ingrese el numero que desea buscar");
                                    int num = Convert.ToInt32(Console.ReadLine());
                                    int cont = 0;
                                    for (int i = 0; i < tam; i++)
                                    {
                                        if (vector[i] == num)
                                        {
                                            cont++;
                                        }
                                    }
                                    Console.WriteLine("La lista de numeros ingresada es: ");
                                    for (int i = 0; i < tam; i++)
                                    {
                                        Console.Write(vector[i] + " ");
                                    }
                                    if (cont > 0)
                                    {
                                        Console.WriteLine("\nEl numero " + num + " si se encuentra en la lista y se repite " + cont + " veces");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nEl numero " + num + " no se encuentra en la lista");
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Valor no valido");
                                }
                            }
                            break;
                        case 7:
                            {
                                try
                                {
                                    Console.WriteLine("Ingrese el tamaño del vector");
                                    int tam = Convert.ToInt32(Console.ReadLine());
                                    int[] vector = new int[tam];
                                    for (int i = 0; i < tam; i++)
                                    {
                                        Console.WriteLine("Ingrese un numero");
                                        vector[i] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    int suma = 0;
                                    for (int i = 0; i < tam; i++)
                                    {
                                        suma = suma + vector[i];
                                    }
                                    int promedio = suma / tam;
                                    Console.WriteLine("La lista de numeros ingresada es: ");
                                    for (int i = 0; i < tam; i++)
                                    {
                                        Console.Write(vector[i] + " ");
                                    }
                                    Console.WriteLine("\nEl promedio de los numeros ingresados es: " + promedio);
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Valor no valido");
                                }
                            }
                            break;
                            //implementamos un case para cuando se quieran salir del programa
                        case 8:
                            Console.WriteLine("Que tenga buen dia!!!:)");
                            break;
                            //esta parte es para marcar un dato incorrcto que no se solicita
                        default:
                            Console.WriteLine("Esta opcion no es valida");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Opcion no valida");
                }
            }
            //finalizando el programa
            Console.ReadKey();
        }
    }
}
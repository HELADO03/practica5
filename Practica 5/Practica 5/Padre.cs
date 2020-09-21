using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Practica_5
{
    class Padre
    {
        public void showMessage()
        {
            Console.WriteLine("\n\tEjercicio numero 1 y 2");

            Console.WriteLine("\nhola desde la clase hija\n\n");
        }

        public void ejercicioNumeroDos()
        {
            Console.WriteLine("\n\tEjercicio numero 2");

            int[] notas = { 90, 88, 92, 79 };
            Console.WriteLine("\n\nEn este arreglo hay:\n");
            Console.WriteLine(notas.Count() + " elementos.\n");

            foreach (int num in notas)
            {
                Console.WriteLine("\n" + num);
            }
        }

        public void ejercicioNumeroTres()
        {
            int[] numeros = { 9, 15, 1, 14, 8, 7, 6, 5 };
            int SumaNumeros = 0, PromedioNumeros;

            Console.WriteLine("\n\tEjercicio numero 3");
            Array.Sort<int>(numeros);
            foreach (int num in numeros)
            {
                Console.WriteLine("\nLos numeros de este arreglo son: " + num);
            }


            for (int i = 0; i < numeros.Length; i++)
            {
                SumaNumeros = SumaNumeros + numeros[i];
            }
            PromedioNumeros = SumaNumeros / numeros.Length;
            Console.WriteLine("\nLa sumatoria de todos los numero es: {0}", SumaNumeros);
            Console.WriteLine("\nEl promedio de los numeros es: {0}", PromedioNumeros);
        }

        public void ejercicioNumeroCuatro()
        {
            List<int> numeros = new List<int>();

            


        }
        

        public void ejercicioNumeroCincoYSeis()
        {
            Console.WriteLine("\n\tEjericios numeros 5y6");
            Console.Write("Ingrese la longitud que deseaa tengan los vectores: ");
            string valor;
            valor = Console.ReadLine();
            int n = int.Parse(valor);
            int[] a = new int[n];
            int[] b = new int[n];
            int[] p = new int[n];
            


            for (int i = 0; i < a.Length; i++)
            {
            Console.Write("\nValores del vector A [" + (i + 1) + "]: ");
            valor = Console.ReadLine();
            a[i] = int.Parse(valor);
             }

             for (int j = 0; j < b.Length; j++)
            {
            Console.Write("\nvalores del vector B [" + (j + 1) + "]: ");
            valor = Console.ReadLine();
            b[j] = int.Parse(valor);
            }

             for (int i = 0; i < a.Length; i++)
            {
            p[i] = (a[i] *  b[i]);
                   
            }
            Console.WriteLine("\nEl producto de los vectores es: ");
            for (int i = 0; i < a.Length; i++)
            {
             Console.Write("[{0}]", p[i]);
            }

        }
    }
    }
    



    


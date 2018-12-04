using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3.Radix
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodo op = new Metodo(); //se llama a la clse metodo
            op.Menu(); //se ejecuta el menu
            Console.ReadKey();
        }
    }
    public class Metodo
    {
        public void Radix(int[] arr) //proceso donde se realiza el radix
        {
            int i, j;
            int[] tmp = new int[arr.Length];
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < arr.Length; ++i)
                {
                    bool move = (arr[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        arr[i - j] = arr[i];
                    else
                        tmp[j++] = arr[i];
                }
                Array.Copy(tmp, 0, arr, arr.Length - j, j); //copia un rango de elemento hacia otro arreglo
            }
        }
        public void Menu() //metodo menu
        {
            do
            {
                Console.Clear();
                int opc;
                Console.Write("Ingrese Numero de secuencia que desea ordenar (1/2/3/4/5): ");
                opc = int.Parse(Console.ReadLine()); //se ingresa cual es el ejercicio que se desea hacer

                switch (opc)
                {
                    case 1:
                        int[] Datos1 = new int[10] { 3, 6, 9, 5, 1, 4, 7, 2, 1, 3 }; //Arreglo con los datos
                        Console.WriteLine("\nSecuencia Deordenada:");
                        foreach (var item in Datos1) //foreach para mostar datos desordenados
                        {
                            Console.Write(" " + item);
                        }
                        Radix(Datos1); //mandamos el arreglo con los datos al metodo radix para su ejecucion.
                        Console.WriteLine("\n\nSecuencia ordenada:");
                        foreach (var item in Datos1) ////foreach para mostar datos ordenados
                        {
                            Console.Write(" " + item);
                        }
                        break;
                    case 2:
                        int[] Datos2 = new int[9] { 8, 3, 9, 3, 11, 7, 1, 27, 12 }; //Arreglo con los datos
                        Console.WriteLine("\nSecuencia Deordenada:"); 
                        foreach (var item in Datos2) //foreach para mostar datos desordenados
                        {
                            Console.Write(" " + item);
                        }
                        Radix(Datos2); //mandamos el arreglo con los datos al metodo radix para su ejecucion.
                        Console.WriteLine("\n\nSecuencia ordenada:"); 
                        foreach (var item in Datos2) //foreach para mostar datos ordenados
                        {
                            Console.Write(" " + item);
                        }
                        break;
                    case 3:
                        int[] Datos3 = new int[8] { 10, 40, 36, 5, 24, 2, 5, 8 }; //Arreglo con los datos
                        Console.WriteLine("\nSecuencia Deordenada:");
                        foreach (var item in Datos3) //foreach para mostar datos desordenados
                        {
                            Console.Write(" " + item);
                        }
                        Radix(Datos3); //mandamos el arreglo con los datos al metodo radix para su ejecucion.
                        Console.WriteLine("\n\nSecuencia ordenada:");
                        foreach (var item in Datos3) //foreach para mostar datos ordenados
                        {
                            Console.Write(" " + item);
                        }
                        break;
                    case 4:
                        int[] Datos4 = new int[9] { 55, 42, 0, 3, 0, 1, 2, 4, 7 }; //Arreglo con los datos
                        Console.WriteLine("\nSecuencia Deordenada:");
                        foreach (var item in Datos4) //foreach para mostar datos desordenados
                        {
                            Console.Write(" " + item);
                        }
                        Radix(Datos4); //mandamos el arreglo con los datos al metodo radix para su ejecucion.
                        Console.WriteLine("\n\nSecuencia ordenada:");
                        foreach (var item in Datos4) //foreach para mostar datos ordenados
                        {
                            Console.Write(" " + item);
                        }
                        break;
                    case 5:
                        int[] Datos5 = new int[7] { 25, 108, 1024, 12, 351, 251, 39 }; //Arreglo con los datos
                        Console.WriteLine("\nSecuencia Deordenada:");
                        foreach (var item in Datos5) //foreach para mostar datos desordenados
                        {
                            Console.Write(" " + item);
                        }
                        Radix(Datos5); //mandamos el arreglo con los datos al metodo radix para su ejecucion.
                        Console.WriteLine("\n\nSecuencia ordenada:");
                        foreach (var item in Datos5) //foreach para mostar datos ordenados
                        {
                            Console.Write(" " + item);
                        }
                        break;
                }
                Console.WriteLine("\nOprime cuialquier tecla...");
                Console.ReadKey();
            }
            while (true);
        }
    }
}
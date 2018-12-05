using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU5_2
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
            int num, num2;
            int[] Datos;
            Random aleatorio = new Random(); //se crea objeto para numeros aleatorios
            Console.Write("Ingrese cantidad de numeros que desea generar: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Ingrese numero maximo aleatorio: ");
            num2 = int.Parse(Console.ReadLine());
            int[] filtro = new int[num]; //Arreglo con los datos
            do
            {
                for (int i = 0; i < num; i++)
                {
                    filtro[i] = aleatorio.Next(0, num2) + 1; //se agregan numeros aleatorios al arreglo usando .next para definir numeros alt entre o y el max
                }
                Datos = filtro.Distinct().ToArray(); //se eliminan los datos repetidos
            }
            while (Datos.Length < num); //si la longitud del arreglo es menor a la cantidad de numeros, se repite el proceso

            Console.WriteLine("\nSecuencia Deordenada:");
            foreach (var item in Datos) //foreach para mostar datos desordenados
            {
                Console.Write(" " + item);
            }
            Radix(Datos); //mandamos el arreglo con los datos al metodo radix para su ejecucion.
            Console.WriteLine("\n\nSecuencia ordenada:");
            foreach (var item in Datos) ////foreach para mostar datos ordenados
            {
                Console.Write(" " + item);
            }
        }
    }
}
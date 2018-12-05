using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ShellSort op = new ShellSort(); //llamamos a la clase
            op.Ingresar();
            op.Imprimir(); 
            Console.ReadKey();
        
        }
    }
    public class ShellSort
    {
        private int[] arr;

        public void Ingresar()
        {
            int num;
            Console.Write("¿Cuantos numeros desea ingresar? ");
            num = Convert.ToInt32(Console.ReadLine());
            arr = new int[num]; //se pone la longitud del vector
            for (int contador = 0; contador < num; contador++) //for para meter los valores
            {
                Console.Write("Ingrese valor {0}: ", (contador + 1)); //ingresamos valor de cada uno en el vector
                arr[contador] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void Imprimir()
        {
            int n = arr.Length;

            Console.WriteLine("Elementos sin ordenar:");
            foreach (var element in arr) //foreach para imprimir arreglo
            {
                Console.Write(element + " ");
            }
            Console.Write("\n");
            Metodo(arr, n); //Mandamos variables al metodo
            Console.WriteLine("\nElementos ordenados:");
            for (int i = arr.Length - 1; i >= 0; i--) //for para ordenar al revez el arreglo ya arreglado
            {
                Console.Write(arr[i] + " ");

            }
            Console.Write("\n");
        }

        public void Metodo(int[] arr, int arraytamaño) //proceso de ordenamiento (shellsort)
        {
            int i, j, inc, temp;
            inc = 3;
            while (inc > 0) //si es mayor a 0
            {
                for (i = 0; i < arraytamaño; i++) //for menor al tamalo de arreglo
                {
                    j = i;
                    temp = arr[i]; //igualamos variables
                    while ((j >= inc) && (arr[j - inc] > temp)) //proceso macizo
                    {
                        arr[j] = arr[j - inc];
                        j = j - inc;
                    }
                    arr[j] = temp;
                }
                if (inc / 2 != 0) //if es diferente a 0
                {
                    inc = inc / 2; //se divide en 2
                }
                else if (inc == 1) //if es igual
                {
                    inc = 0; //vale 0
                }
                else
                    inc = 1; //else pos vale 1
            }
        }
    }
}

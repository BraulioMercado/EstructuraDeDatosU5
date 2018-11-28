using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2_QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu opc = new Menu();  //Se llama a la clase 
            opc.Desplegar();
        }
    }
    class Proceso
    {
        public void QuickSort(double[] array) //se llama al metodo quicksort y se reciben parametros
        {
            QuickSort(array, 0, array.Length - 1);
        }

        public void QuickSort(double[] array, int inicio, int final)   //metodo
        {
            if (inicio >= final)  //Si el valor de la izquierda es mayor/igual a la derecha, regresa el valor 
            {
                return;
            }
            double numero = array[inicio];  
            int i = inicio;
            int j = final;
            while (i < j)                         // Si inicio es menor a final procede
            {
                while (i < j && array[j] >= numero)
                {
                    j--;
                }                                     //se cambian de valores los numeros
                array[i] = array[j];                //se van ordenando
                while (i < j && array[i] < numero)
                {
                    i++;
                }
                array[j] = array[i];
            }
            array[i] = numero;
            QuickSort(array, inicio, i - 1);
            QuickSort(array, i + 1, final);
        }
        public void Ordenado(double[] arreglo, int n) //metodo para desplegar el metodo arreglado
        {
            Console.WriteLine("\nNumeros Ordenados:  ");
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arreglo[i] + " ");
            }
        }
    }
    class Menu
    {
        public void Desplegar()
        {
            string opc2;
            int opc;
            do
            {
                try
                {
                    double[] a = { 11, 2, 3, 14, 18, 45, -3, -1, 6, 9 };                             // Se le asignan los valores a cada uno de los arrays
                    double[] b = { 1, 3, 5, 7, 8, 3, 9, 0.7071, 16.5664, 12, 0, 10 };
                    double[] c = { 3, 7, 15, 4 / 3, 155, 100, 15, 1.7320, 5, 2, 3, 2 };
                    double[] d = { 8, 19, 7, 3, 15, 23, 34, 27, 89, 101 };

                    Console.Clear();
                    Console.Write("~~~~~~~~~~ QuickSort ~~~~~~~~~~\n1.-11, 2, 3, 14, 18, 45, -3, -1, 6, 9 \n2.-1, 3, 5, 7, 8, 3, 9, 0.7071, 16.5664, 12, 0, 10 \n3.-3, 7, 15, 4 / 3, 155, 100, 15, 1.7320, 5, 2, 3, 2 \n4.-8, 19, 7, 3, 15, 23, 34, 27, 89, 101 \nIngrese opcion: ");
                    opc = int.Parse(Console.ReadLine());

                    switch (opc)
                    {
                        case 1:
                            Proceso ordenara = new Proceso();                    
                            ordenara.QuickSort(a);          //se manda el arreglo donde estan los valores
                            ordenara.Ordenado(a, a.Length);    //se manda para impprimir
                            break;
                        case 2:
                            Proceso ordenarb = new Proceso();
                            ordenarb.QuickSort(b);
                            ordenarb.Ordenado(b, b.Length);
                            break;
                        case 3:
                            Proceso ordenarc = new Proceso();
                            ordenarc.QuickSort(c);
                            ordenarc.Ordenado(c, c.Length);
                            break;
                        case 4:
                            Proceso ordenard = new Proceso();
                            ordenard.QuickSort(d);
                            ordenard.Ordenado(d, d.Length);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error!!" + e.Message); //trycatch error
                }
                Console.Write("\n¿Desea ejecutar el programa otravez? Si=1 || No=Cualquier boton: "); //repetir programa
                opc2 = Console.ReadLine();
            }
            while (opc2 == "1"); //do while para ver si desea realizarse otravez
            Console.ReadKey();
        }
    }
}

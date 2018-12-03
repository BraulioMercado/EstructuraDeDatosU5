using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3_Radix
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodo op = new Metodo();
        }
    }
    public class Metodo
    {
        public void Radix(int[] Datos1)
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
                Array.Copy(tmp, 0, arr, arr.Length - j, j);
            }
        }
        public void Menu()
        {
            int opc;
            Console.WriteLine("Ingrese Numero de secuencia que desea ordenar: ");
            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    int[] Datos1 = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
                    Radix(Datos1);
                    Console.WriteLine("Secuencia ordenada:");
                    foreach (var item in Datos1)
                    {
                        Console.Write(" " + item);
                    }
                    break;
                case 2:
                    int[] Datos2 = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
                    Radix(Datos2);
                    Console.WriteLine("Secuencia ordenada:");
                    foreach (var item in Datos2)
                    {
                        Console.Write(" " + item);
                    }
                    break;
                case 3:
                    int[] Datos3 = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
                    Radix(Datos3);
                    Console.WriteLine("Secuencia ordenada:");
                    foreach (var item in Datos3)
                    {
                        Console.Write(" " + item);
                    }
                    break;
                case 4:
                    int[] Datos4 = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
                    Radix(Datos4);
                    Console.WriteLine("Secuencia ordenada:");
                    foreach (var item in Datos4)
                    {
                        Console.Write(" " + item);
                    }
                    break;
                case 5:
                    int[] Datos5 = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
                    Radix(Datos5);
                    Console.WriteLine("Secuencia ordenada:");
                    foreach (var item in Datos5)
                    {
                        Console.Write(" " + item);
                    }
                    break;
            }
        }
    }
}

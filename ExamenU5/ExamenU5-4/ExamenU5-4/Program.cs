using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU5_4
{
    class Proceso
    {
        //Se crean nuevos vectores, 1 para cada acomodo.
        string oracion = "lorem ipsum dolor sit amet, consectetur adipiscing elit. fusce varius, augue vitae tincidunt viverra, sem felis bibendum nisl, id cursus diam leo sit amet urna. duis ac massa est."; //palabra para acomodar
        public void Imprimir()
        {
            char[] A = oracion.ToCharArray();
            Console.WriteLine("Sin ordenar:");
            Desplegar(A); //se manda el arreglo la variable a para desplegar metodo
            Quicksort(A, 0, A.Length - 1); //se mandan variables al proceso
            Console.WriteLine("Ordenado");
            Desplegar(A); //se manda el arreglo la variable a para desplegar metodo
            Console.ReadKey();
        }
        public void Quicksort(char[] vector, int primero, int ultimo)
        {
            int i, j, central;
            char pivote;
            central = (primero + ultimo) / 2;
            pivote = vector[central];//este valor sera usado como pivote
            i = primero;//Se guadan los valores 
            j = ultimo;
            byte[] Compara;//Se genera un arreglo de bytes con los ascii por el cual mide el tamaño en bytes de las letras
            byte[] Compara2;
            do
            {
                while (vector[i] < pivote) i++; //el pivote incrementa 1
                while (vector[j] > pivote) j--;//el  pivote incrementa 2.
                Compara = Encoding.ASCII.GetBytes(vector[i].ToString());//arreglos de bytes con los ascii 
                Compara2 = Encoding.ASCII.GetBytes(vector[j].ToString());
                int IntCompara = Convert.ToInt32(Compara[0]);
                int IntCompara2 = Convert.ToInt32(Compara2[0]);
                if (i <= j)
                {
                    char temp;
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;
                }
            }
            while (i <= j);

            if (primero < j)
            {
                Quicksort(vector, primero, j);//Se manda a llamar el metodo por medio de recursividad.
            }
            if (i < ultimo)
            {
                Quicksort(vector, i, ultimo);//Se manda a llamar el metodo por medio de recursividad.
            }
        }

        public void Desplegar(char[] A) //metodo para depslegar
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("{0} ", A[i]);
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Proceso op = new Proceso();
            op.Imprimir();
        }
    }
}
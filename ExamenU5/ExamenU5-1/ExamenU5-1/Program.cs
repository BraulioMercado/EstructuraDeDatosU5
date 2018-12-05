using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Burbuja op = new Burbuja(); //lamamos a la clase del metodo
            op.Ingresar();
            op.Metodo();
            op.Imprimir();
        }
    }
    class Burbuja
    {
        private int[] vector; //variable que usaremos

        public void Ingresar()
        {
            int num;
            Console.Write("¿Cuantos numeros desea ingresar? ");
            num = Convert.ToInt32(Console.ReadLine());
            vector = new int[num]; //se pone la longitud del vector
            for (int contador = 0; contador < num; contador++) //for para meter los valores
            {
                Console.Write("Ingrese valor {0}: ", (contador + 1)); //ingresamos valor de cada uno en el vector
                vector[contador] = Convert.ToInt32(Console.ReadLine());
                if (vector[contador] == 0) //if el vector es igual a 0, continua el for
                {
                    continue;
                }
                else if (vector[contador] == 1)//if el vector es igual a 1, continua el for
                {
                    continue;
                }
                else if(vector[contador] == 2)//if el vector es igual a 2, continua el for
                {
                    continue;
                }
                else //si no es asi
                {
                    Console.WriteLine("Necesita ingresar un numero menor a 2"); 
                    vector[contador] = vector[contador] - vector[contador]; //se elimina el ultimo numero ingresado
                    contador--; //se resta uno al contador, para seguir pidiendo numeros ignorando el ultimo que salio mal
                }
            }
        }

        public void Metodo() //aqui se hace el metodo de la burbuja
        {
            int t;
            for (int a = 1; a < vector.Length; a++)
            {
                for (int b = vector.Length - 1; b >= a; b--)
                {
                    if (vector[b - 1] > vector[b])
                    {
                        t = vector[b - 1]; //proceso 
                        vector[b - 1] = vector[b];
                        vector[b] = t;
                    }
                }
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("Elementos ordenados");
            for (int f = 0; f < vector.Length; f++) //for con el vector y sus datos dentro ya acomodados
            {
                Console.Write(vector[f] + "  ");
            }
            Console.ReadKey();
        }
    }
}

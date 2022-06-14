using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certamen02
{
     class Program
    {
        static void Main(string[] args)
        {

            int[] matriz = new int[5];
            Console.WriteLine("------------------EJERCICIO 1---------------");
            Console.WriteLine("INGRESE NUMEROS:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matriz[i] = validacion("N " + (i + 1));
            }
            imprimematriz(matriz);
            Console.WriteLine();
            Console.WriteLine("INGRESE UN NUMERO PARA BUSCAR MAYORES AL INGRESADO:");
            int num = validacion("NUM:");
            Console.WriteLine("NUMEROS MAYORES AL INGRESADO:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int m = matriz[i];
                if (num < m)
                {
                    Console.Write(matriz[i] + " / ");
                }

            }
            Console.WriteLine();
            Console.WriteLine("------------------EJERCICIO 2---------------");

            string[,] matriz2 = new string[8, 8];

            int largo1 = (matriz2.GetLength(0) / 2);
            int largo2 = (matriz2.GetLength(0) / 2) - 1;
            int largo3 = (matriz2.GetLength(1) / 2);
            int largo4 = (matriz2.GetLength(1) / 2) - 1;

            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    if (i == largo1 || i == largo2 || j == largo3 || j == largo4)
                    {
                        matriz2[i, j] = "1";
                    }
                    else
                    {
                        matriz2[i, j] = "0";
                    }
                }
            }
            imprimir(matriz2);

            Console.WriteLine("------------------EJERCICIO 3---------------");

            var random = new Random();
            int[] vector = new int[10];

            int mayor = 0;
            int menor = 200;
            int PoMayor = 0;
            int PoMenor = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = random.Next(50, 200);
                if (mayor < vector[i])
                {
                    mayor = vector[i];
                    PoMayor = i;
                }
                if (menor > vector[i])
                {
                    menor = vector[i];
                    PoMenor = i;
                }
            }
            imprimematriz(vector);
            Console.WriteLine();
            Console.WriteLine("POCICION NUMERO MAYOR = " + PoMayor);
            Console.WriteLine("POCICIOM NUMERO MENOR = " + PoMenor);



            Console.ReadKey();

        }




        static void imprimematriz(int[] matriz)
        {
            Console.WriteLine();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write(matriz[i] + " | ");
            }
            Console.WriteLine();
        }


        static void imprimir(string[,] matriz)
        {
            Console.WriteLine();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();
        }
        static int validacion(string txt)
        {
            int num;
            bool val = false;
            do
            {
                Console.WriteLine("ingrese numero {0}", txt);
                val = int.TryParse(Console.ReadLine(), out num);
                if (num < 0)
                {
                    val = false;
                }

            } while (!val);
            return num;
        }
    }
 }


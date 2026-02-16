using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixok
{
    internal class Program
    {
        static int N = 10;
        static int M = 10;
        static int[,] matrix = new int[N, M];

        static void Feltolt()
        {
            Random sorszam = new Random();
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = sorszam.Next(-100,100);
                }
            }
        }
        static void Kiir()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write($"{matrix[i, j],4}");

                }
                Console.WriteLine();
            }
        }

        static void NegativSzamolo()
        {
            for (int j = 0; j < M; j++)
            { int db = 0;
                for (int i = 0; i < N; i++)
                {
                    if (matrix[i, j] < 0)
                    {
                        db++;
                    }

                }
                Console.WriteLine(db);
            }
        }

        static void Negyzetmatrix()
        {
            int sorok = 10;
            int[,] negyzet = new int[sorok, sorok];
            Random rnd = new Random();
            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < sorok; j++)
                {
                    int szam;
                    do
                    {
                        szam = rnd.Next(100, 1000);
                    }
                    while (szam % 2 == 1);
                    negyzet[i,j] = szam;
                }
            }

        }

        static void KiirAtlo(int[,] matrix)
        {
            int column = matrix.GetLength(1);
            int row = 0;
            column--;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write($"{matrix[i, column], 4}");
                row++;
                column--;
            }
        }


        static void Main(string[] args)
        {
            Feltolt();
            Kiir();
            NegativSzamolo();
            Console.WriteLine("__________________________");
            KiirAtlo(matrix);
        }
    }
}

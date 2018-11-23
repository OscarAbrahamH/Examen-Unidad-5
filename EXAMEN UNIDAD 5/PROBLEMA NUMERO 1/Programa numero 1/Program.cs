using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_numero_1
{
    class Clase
    {
        // Declaración de variables
        private int Rango = 0;
        private int[,] X;

        //Matriz
        private int[] X2;

        //Arreglo
        public int[] X3;
        
        //Distancia
        private int RangoX = 0;
       

        public Clase(int ParametroR, int[,] ParametroA)
        {
            X = new int[ParametroR, ParametroR];
            X2 = new int[ParametroR];
            X3 = new int[ParametroR];
            Rango = ParametroR;
            for (int i = 0; i < Rango; i++)
            {
                for (int j = 0; j < Rango; j++)
                {
                    X[i, j] = ParametroA[i, j];
                }
            }
            for (int i = 0; i < Rango; i++)
            {
                X2[i] = i;
            }
            X2[0] = -1;
            for (int i = 1; i < Rango; i++)
            {
                X3[i] = X[0, i];
            }
        }

        
        public void Valores() //SOLUCION
        {
            int MinimoV = Int32.MaxValue;
            int MinimoN = 0;
            for (int i = 0; i < Rango; i++)
            {
                if (X2[i] == -1)
                {
                    continue;
                }
                if (X3[i] > 0 && X3[i] < MinimoV)
                {
                    MinimoV = X3[i];
                    MinimoN = i;
                }
            }
            X2[MinimoN] = -1;
            for (int i = 0; i < Rango; i++)
            {
                if (X[MinimoN, i] < 0)
                    continue
                    ;
                if (X3[i] < 0)
                {
                    X3[i] = MinimoV + X[MinimoN, i];
                    continue;
                }
                if ((X3[MinimoN] + X[MinimoN, i]) < X3[i])
                    X3[i] = MinimoV + X[MinimoN, i];
            }
        }
        public void Ejecutar()
        {
            for (RangoX = 1; RangoX < Rango; RangoX++)
            {
                Valores();
                Console.WriteLine("Interaccion: " + RangoX);
                Console.WriteLine("Matriz: ");
                for
                 (int i = 0; i < Rango; i++)
                    Console.Write(i + "  "
                    );
                Console.WriteLine(" ");
                for (int i = 0; i < Rango; i++)
                    Console.Write(X3[i] + " ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
        }
        static void Main(string[] args)
        {
            
                int[,] X ={  
                {-1, 349, 957, 1855, -1, -1, -1, -1},
                {349, -1,   834, -1,  -1, -1, -1, 2451},
                {957, 834, -1,  908, -1, -1, -1, -1},
                {-1, -1,  908, -1, 860, 606, -1, -1},
                {-1, -1, -1,  860, -1, -1, -1, 191},   //Asignar valores establecidos en el problema
                {-1, -1, -1, 606, -1, -1, 595, 760},
                {-1, -1, -1, -1, -1,  595, 0, 1090},
                {2534, 2451, -1, 722, 191, 760, 1090, -1}
            };
            Clase Imprimir = new
            Clase((int)Math.Sqrt(X.Length), X);
            Imprimir.Ejecutar();
            Console.WriteLine("Solucion mas corta del nodo 1: ");
            int Nodito = 1;
            foreach (int i in Imprimir.X3)
            {
                Console.Write("Distancia Minima " + Nodito + " es: ");
                Console.WriteLine(i);
                Nodito++;
            }
            Console.ReadKey();
        }
    }
}

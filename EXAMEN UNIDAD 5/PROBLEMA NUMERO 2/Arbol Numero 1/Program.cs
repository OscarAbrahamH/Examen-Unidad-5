using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolNum2
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol figura1 = new Arbol(); //Declaracion objeto 1
            Arbol2 figura2 = new Arbol2(); //Declaracion objeto 2

            //Asignar valores al arbol
            figura1.Agregar('A'); 
            figura1.Agregar('B');
            figura1.Agregar('C');
            figura1.Agregar('D'); 
            figura1.Agregar('E');
            figura1.Agregar('F');
            figura1.Agregar('G');
            figura1.Agregar('H');
            figura1.Agregar('I');
            figura1.Agregar('J'); 
            figura1.Agregar('K');
            figura1.Agregar('L');
            figura1.Agregar('M');
            figura1.Agregar('N');
            figura1.Agregar('O');
            figura1.Agregar('P'); 
            figura1.Agregar('Q');
            figura1.Agregar('R');
            figura1.Agregar('S');

            Console.WriteLine("------------------------------");
            Console.Write("Recorrido en PreOrden: "); //Imprimir recorrido preorden
            figura1.PreOrden(ref figura1.Raiz);
            Console.WriteLine(" ");
            Console.WriteLine("------------------------------");
            Console.Write("Recorrido en PostOrden: "); //Imprimir recorrido postorden
            figura1.PostOrden(ref figura1.Raiz);
            Console.WriteLine(" ");
            Console.WriteLine("------------------------------");
            figura2.RealizarArbol(ref figura1.Raiz);
            Console.ReadKey();
        }
    }
}

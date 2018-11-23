using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolNum2
{
    class Arbol3
        {

        }
        public class Nodo
        {
            public char Letra; //Declaracion de "Letra"
            public Nodo Izquierda; //Declaracion de "Izquierda"
            public Nodo Derecha; //Declaracion de "Derecha

            public Nodo(char Letra1)
            {
                this.Letra = Letra1;
                Derecha = null; //Derecha igual a nulo
                Izquierda = null; //Izquierda igual a nulo

            }
        }

        public class Arbol
        {
            public Nodo Raiz; //Public Nodo raiz

            public Arbol()
            {
                Raiz = null;
            }

            public void Agregar(char Nuevo) 
            {
                Agregar(ref Raiz, Nuevo);
            }

            public void Agregar(ref Nodo aux, char Valor)
            {
                if (aux == null)
                {
                    aux = new Nodo(Valor);
                }
                else if (Valor.CompareTo(aux.Letra) < 0)
                {
                    Agregar(ref aux.Izquierda, Valor);
                }
                else if (Valor.CompareTo(aux.Letra) > 0)
                {
                    Agregar(ref aux.Derecha, Valor);
                }
            }

            public void PreOrden(ref Nodo aux)
            {
                if (aux != null)
                {
                    Console.Write(aux.Letra + " ");
                    PreOrden(ref aux.Izquierda);
                    PreOrden(ref aux.Derecha);
                }
            }

            public void PostOrden(ref Nodo aux)
            {
                if (aux != null)
                {
                    PostOrden(ref aux.Izquierda);
                    PostOrden(ref aux.Derecha);
                    Console.Write(aux.Letra + " ");
                }
            }

        }
    }


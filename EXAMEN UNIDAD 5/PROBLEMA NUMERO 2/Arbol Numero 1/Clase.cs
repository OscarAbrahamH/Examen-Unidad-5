using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolNum2
{
    class Arbol2
    {
        public void RealizarArbol(ref Nodo ARaiz) //Se realiza el arbol
        {
            string aux = "digraph G{\n";
            if (ARaiz != null)
            {
                aux += ARaiz.Letra + ";\n";
                DiseñarAbb(ARaiz, ref aux);
            }
            aux += "\n}\n";
        }

        public void DiseñarAbb(Nodo Actual, ref string aux) //Recorre las letras en orden
        {
            if (Actual != null)
            {
                if (Actual.Izquierda != null)
                {
                    aux += Actual.Letra + "->" + Actual.Izquierda.Letra + ";\n";

                }
                if (Actual.Derecha !=null)
                {
                    aux += Actual.Letra + "->" + Actual.Derecha.Letra + ";\n";
                }
            }
        }
    }
}

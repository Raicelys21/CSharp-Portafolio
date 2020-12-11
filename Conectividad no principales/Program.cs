//Raicelys Suero
/* Operaciones que puedes utilizar como ejemplo:
 * (r^s)*(pvq)>(pvq)v(r*s)^(p>q)
 * (p>q)*(r^s)>(pvq)>(p^q)v(r^s)
 * (p^s)v(r^s)v(pvq)*(p^q)v(r^s)
 */
using System;
using System.Collections.Generic;
using ConsoleApp1;

namespace ConectivasNOPrincipales
{
    class Program
    {
        static void Main()
        {
            // Parentesis de apertura y cierre, y sus contadores
            char a = '(';
            int abiertos = 0;
            char b = ')';
            int cerrados = 0;

            //Variables de posición, operación y formulación
            int r = 0;
            int cantdesimb = 0;
            char simbolo;
            string NotaPrefij = "";

            //Titulo del programa 
            Console.WriteLine("\r\n" + "Notación prefija - Raicelys Suero");

            //Imprimir tabla de signos
            Console.WriteLine("\r\n" + "Tabla de formula: (→ = →); (↔ = *); (¬ = ¬); (V = v); (^ = ^)" + "\r\n");

            //Introducir y almacenar la operación
            Console.Write("Introduce su operacion: ");
            string operacion = Console.ReadLine();
            Console.Write("\r\n" +"La notación prefija es: ");

            //Buscar la conectividad principal
            for (int i = 1; i < operacion.Length; i++)
            {
                if (operacion[r] == a) {
                    abiertos++;}

                if (operacion[r] == b){
                    cerrados++;}

                if (abiertos == cerrados) {
                    if (operacion[r + 1] != '(') {
                        simbolo = operacion[r + 1];
                        cantdesimb++;
                    }
                } r++;
            }

            List<string> Subform = new List<string>();
            SubformulaDetermination rai = new SubformulaDetermination();
            Subform = rai.Subform(operacion);
            List<string> ExpresF1 = rai.note(Subform);
            foreach (var o in ExpresF1) NotaPrefij += o.ToString() ;
            Console.Write(NotaPrefij);
            Console.WriteLine("\r\n");
        }
    }
}

/* Operaciones que puedes utilizar como ejemplo:
 * (r^s)*(pvq)→(p^q)v(r^s)^(p→q)
 * (p→q)*(r^s)→(pvq)→(p^q)v(r^s)
 * (p^s)v(r^s)v(pvq)*(p^q)v(r^s)
 */
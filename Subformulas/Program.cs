using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class SubformulaDetermination
    {
        public List<char> ConectPrincipal(string operaciones, List<char> Valor)
        {
            //Construcción de Array para buscar posiciones en el string operacion_dada
            char[] CharArray;
            CharArray = operaciones.ToCharArray();
            int Num = 0;

            //Signos de conectividad principal
            char ConectPrincipal;

            //Identificación si la operacion es correcta y de las conectivas principales
            for (int r = 0; r < operaciones.Length - 1; r++)
            {
               if (CharArray[Num + 1] != '('){
                      ConectPrincipal = operaciones[Num + 1];
                      Valor.Add(ConectPrincipal);
                } Num++;
            } return Valor;
        }

        //Identificación e impresión de las expresiones
        public List<string> Subfor_determinate(string operacion_dada)
        {
            //Listas de variables
            List<string> Subfordeterminate = new List<string>();
            List<int> Posicions = new List<int>();

            //Busqueda de la expresion dentro del parentesis
            for (int i = 0; i < operacion_dada.Length; i++){
                if (operacion_dada[i] == '(' || operacion_dada[i] == ')') {
                    Posicions.Add(i);
                }
            }
            //Impresión de los parentesis sin 
            for (int t = 0; t < Posicions.Count; t++){
                if (operacion_dada[Posicions[t]] == '('){
                    if (operacion_dada[Posicions[t + 1]] == ')'){
                        Subfordeterminate.Add(operacion_dada.Substring(Posicions[t], Posicions[t + 1] - Posicions[t] + 1));
                    }
                } else continue;
            } return Subfordeterminate;
        }

        static void Main(string[] args){
            //Imprimir tablas de conectores
            Console.WriteLine("\r\n" + "Tabla de formula: (→ = →); (↔ = *); (¬ = ¬); (V = v); (disyución = ^)" + "\r\n");

            //Intoducir expresión
            Console.Write("Introduce tu expresión: ");
            string operacion_dada = Console.ReadLine();

            //Proceso de determinación de operación dada
            Console.WriteLine("\r\n" + "Las subformulas son las siguientes:");
            List<string> Subfor_determinate = new List<string>();
            SubformulaDetermination s = new SubformulaDetermination();
            Subfor_determinate = s.Subfor_determinate(operacion_dada);
            foreach (string expresion in Subfor_determinate) 
                Console.WriteLine(expresion);
        }
    }
}
/* Operaciones que puedes utilizar como ejemplo:
 * (q)^(r^s)*(pvq)→(p^q)
 * (p->q)*(r^s)→(pvq)→(p^q)
 * (p)v(r^s)v(pvq)*(p^q)
 */


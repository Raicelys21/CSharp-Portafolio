using System.Collections.Generic;

namespace ConsoleApp1
{
    class SubformulaDetermination
    {
        public List<string> Subform(string operacion)
        {
            List<string> Subform = new List<string>();
            List<int> indices = new List<int>();

            for (int i = 0; i < operacion.Length; i++) {
                if (operacion[i] == '(' || operacion[i] == ')'){
                    indices.Add(i);
                }
            }
            for (int i = 0; i < indices.Count; i++){
                if (operacion[indices[i]] == '(') {
                    if (operacion[indices[i + 1]] == ')'){
                        Subform.Add(operacion.Substring(indices[i], indices[i + 1] - indices[i] + 1));
                    }
                } else continue;
            } return Subform;
        }
        public List<string> note(List<string> Subform)
        {
            List<string> NotaPrefij = new List<string>();
            foreach (string formula in Subform){
                for (int i = 0; i < formula.Length; i++){
                    if (formula[i] == '^' || formula[i] == 'v' || formula[i] == '>'){
                        NotaPrefij.Add(formula[i].ToString());

                        if (formula[i - 2] == '-') NotaPrefij.Add("-" + formula[i - 1].ToString());
                        else NotaPrefij.Add(formula[i - 1].ToString());

                        if (formula[i + 1] == '-') NotaPrefij.Add("-" + formula[i + 2].ToString());
                        else NotaPrefij.Add(formula[i + 1].ToString());
                    }
                }
            }  return NotaPrefij;
        }
    }
}



/*
Duke pasur parasysh variablen formula - e tipit string, që përfaqëson një formulë kimike,
ktheni numrin e secilit atom. Elementi atomik gjithmonë fillon me një karakter të madh,
pastaj zero ose më shumë shkronja të vogla, që përfaqësojnë emrin. Një ose më shumë
shifra që përfaqësojnë numërimin e atij elementi mund të pasojnë nëse numërimi është
më i madh se 1. Nëse numërimi është 1, nuk do të ketë asnjë shifër.
*Për shembull, "H2O" dhe "H2O2" janë të mundshme, ndërsa "H1O2" jo.
Dy formula janë të lidhura së bashku për të prodhuar një formulë tjetër.
*Për shembull, "H2O2He3Mg4" është gjithashtu formulë.
Një formulë e vendosur në kllapa dhe një numërim (i shtuar opsionalisht) është gjithashtu
një formulë.
*Për shembull, "(H2O2)" and "(H2O2)3" are formulas.
Ktheni numrin e të gjithë elementëve si string në formën e mëposhtme: emrin e parë (i
sortuar), i ndjekur nga numri i tij (nëse ai numër është më i madh se 1), i ndjekur nga
emri i dytë (i sortuar), i ndjekur nga numërimi (count) i tij (nëse ai numër është më i
madh se 1), e kështu me radhë.
 
Shembulli 1:
Hyrja: formula = "H2O"
Dalja: "H2O"
Shpjegim: Numri i elementeve është: {'H': 2, 'O': 1}.
Shembulli 2:
Hyrja: formula = "Mg(OH)2"
Dalja: "H2MgO2"
Shpjegim: Numri i elementeve është: {'H': 2, 'Mg': 1, 'O': 2}.
 
Shembulli 3:
Hyrja: formula = "K4(ON(SO3)2)2"
Dalja: "K4N2O14S4"
Shpjegim: Numri i elementeve është: {'K': 4, 'N': 2, 'O': 14, 'S': 4}.
Kufizimet:
- 1 <= formula.length <= 1000
- formula përbëhet nga shkronja, numra, '(', dhe ')'.
- Formula është gjithmonë valide.
*/

using System.Text;
public class Detyra11{
    public static void Main(string[] args){
        Console.WriteLine(CountOfAtoms("K4(ON(SO3)2)2"));   
    }

    public static string CountOfAtoms(string formula){
        Stack<Dictionary<string, int>> stack =  new Stack<Dictionary<string, int>>();
        Dictionary<string, int> current = new Dictionary<string, int>();
        int i = 0;
        while(i< formula.Length){
            if(formula[i] == '('){
                stack.Push(current);
                current = new Dictionary<string, int>();
                i++;
            }
            else if(formula[i] == ')'){
                i++;
                int start = i;
                while( i< formula.Length && char.IsDigit(formula[i])) i++;
                int multiplier = (i > start) ? int.Parse(formula.Substring(start, i - start)) : 1;
                Dictionary<string, int> prev = stack.Pop();
                foreach(var element in current){
                    if(!prev.ContainsKey(element.Key)){
                        prev[element.Key] = 0;
                    }
                    prev[element.Key] += element.Value * multiplier;
                } 
                current = prev;
            }
            else{
                int start = i++;
                while(i < formula.Length && char.IsLower(formula[i])) i++;
                string element = formula.Substring(start, i - start);

                start = i;
                while(i < formula.Length && char.IsDigit(formula[i])) i++;
                int count = (i > start) ? int.Parse(formula.Substring(start, i - start)) : 1;
                if(!current.ContainsKey(element)){
                    current.Add(element, 0);
                }
                current[element] += count;
            }   
        }
        StringBuilder result = new StringBuilder();
        foreach(var element in current.OrderBy(e => e.Key)){
            result.Append(element.Key);
            if(element.Value > 1){
                result.Append(element.Value);
            }
        }
        return result.ToString();
    }
}
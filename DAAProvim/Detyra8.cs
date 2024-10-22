/* Duke pasur parasysh nje varg numrash te plote, shkruani nje funksion qe gjen gjatesine e nenrenditjes
me te gjate ne rritje. Nje nensekuence eshte nje sekuence elementesh qe shfaqen ne te njejtin rend ne vargun
origjinal, por jo domosdosmerisht ne menyre te njepasnjeshme. Funksioni duhet te ktheje gjatesine e nensekuences
me te gjate ne rritje. Per shembull, per vargun [10,9,2,5,3,7,101,18], nensekuenca me e gjate ne rritje eshte
[2,3,7,101] dhe gjatesia e saj eshte 4.
*/

// public class Detyra8{
//     public static void Main(string[] args){
//         int[] sequence = {10, 9, 2, 5, 3, 7, 101, 18};
//         List<int> result = SubSequenceInGrowth(sequence);
//         foreach(var item in result){
//             Console.Write(item.ToString() + ", ");
//         }
//     }

//     public static List<int> SubSequenceInGrowth(int[] sequence)
//     {
//         List<int> subSequence = new List<int>(); // Nënrenditja më e gjatë në rritje
//         for(int i =0; i< sequence.Length; i++){
//             if(subSequence.Count == 0 || sequence[i] > subSequence[subSequence.Count - 1]){
//                 subSequence.Add(sequence[i]);
//             }
//             else{
//                 for(int j = 0; j < subSequence.Count; j++){
//                     if(subSequence[j] >= sequence[i]){
//                         subSequence[j] = sequence[i];
//                         break;
//                     }
//                 }
//             }
//         }
//         return subSequence;
//     }
// }
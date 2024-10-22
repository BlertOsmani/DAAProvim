/*
Kemi një hotel me n dhoma (rooms). Dhomat pëfaqësohen nga një varg 2D i tipit integer me emrin rooms ku 
rooms[i] = [roomIdi, sizei] tregon se ka një dhomë me numrin e
dhomës roomIdi dhe madhësinë e barabartë me sizei. Secila roomIdi është unike.
Gjithashtu kemi k pyetje/kerkesa (en. queries) në një varg 2D me emrin queries ku
queries[j] = [preferredj, minSizej]. Përgjigjja për kërkesen/pyetjen (en.query) e jth
është numri i dhomës id të një dhome të tillë që:
Dhoma ka një madhësi prej të paktën minSizej, dhe abs(id - preferredj) është
minimizuar, ku abs(x) është vlera absolute e x. Nëse ka një barazim në diferencën
absolute, atëherë përdorni dhomën me më të voglën id. Nëse nuk ka dhomë të tillë,
përgjigjja është -1.
Ktheni një varg answer të gjatësisë k ku answer[j] ka/përmban pëgjigjjen e pyetjes
(query) jth.
*/

// public class Detyra7{
//     public static void Main(string[] args){
//         int[,] rooms = {
//             {1, 30},
//             {2, 45},
//             {3, 20},
//             {4, 40}
//         };
//         int[,] queries = {
//             {2, 25}, // Preferred ID, Minimum Size
//             {1, 45},
//             {3, 15}
//         };
//         List<(int id, int size)> answers = FindBestRoom(rooms, queries);
//         foreach(var answer in answers){
//             Console.WriteLine(answer);
//         }
//     }
//     public static List<(int id, int size)> FindBestRoom(int[,] rooms, int[,] queries){
//         var answers = new List<(int id, int size)>();
//         int bestRoom = 0;
//         int roomId = 0;
//         int maxValue = int.MaxValue;
//         for(int i = 0; i < queries.GetLength(0); i++){
//             int preferredRoom = queries[i, 0];
//             for(int j = 0; j < rooms.GetLength(0); j++){
//                 if(rooms[j, 1] >= queries[i,1]){
//                     int closestRoom = Math.Abs(rooms[j, 0] - preferredRoom);
//                     if(closestRoom < maxValue || 
//                     (closestRoom == maxValue && rooms[j, 0] < bestRoom)){
//                         bestRoom = rooms[j,1];
//                         maxValue = closestRoom;
//                         roomId = rooms[j, 0];
//                     }
//                 }
//             }
//             answers.Add((roomId, bestRoom));
//         }
//         return answers;
//     }
// }
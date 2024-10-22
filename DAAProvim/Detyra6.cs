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
// using System.Collections;

// public class Detyra6{
//     public static void Main(string[] args){
//         int[,] rooms = {
//             {1, 30}, // Room ID, Size
//             {2, 45},
//             {3, 20},
//             {4, 40}
//         };
//         int[,] queries = {
//             {2, 25}, // Preferred ID, Minimum Size
//             {1, 45},
//             {3, 15}
//         };
//         var answers = FindRooms(rooms, queries);
        
//         // Print the results
//         Console.WriteLine("Answers: ");
//         foreach (var answer in answers)
//         {
//             Console.WriteLine($"Room ID: {answer.roomId}, Size: {answer.size}");
//         }
//     }

//     public static (int roomId, int size)[] FindRooms(int[,] rooms, int[,] queries){
//         int n = rooms.GetLength(0);
//         int k = queries.GetLength(0);

//         var roomList = new List<(int id, int size)>();
//         for(int i = 0; i < n; i++){
//             roomList.Add((rooms[i, 0], rooms[i, 1]));
//         }
//         var results = new (int roomId, int size)[k];
//         for(int j = 0; j < k; j ++){
//             int preferred = queries[j, 0];
//             int minSize = queries[j, 1];

//             (int roomId, int size) bestRoom = (-1, -1);
//             int minDifference = int.MaxValue;
//             foreach(var room in roomList){
//                 if(room.size >= minSize){
//                     int difference = Math.Abs(room.id - preferred);
//                     if(difference < minDifference || (difference == minDifference && room.id < bestRoom.roomId)){
//                         minDifference = difference;
//                         bestRoom = room;
//                     }
//                 }
//             }
//             results[j] = bestRoom;
//         }
//         return results;
//     }
// }
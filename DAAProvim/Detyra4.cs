/*
Duke pasur parasysh një sërë intervalesh kohore takimesh që përbëhen nga orët e 
fillimit dhe të përfundimit [ [s1 , e1 ] , [ s2 , e2 ] ,... ] (si< ei), gjeni numrin minimal të sallave të 
konferencave të nevojshme.
*/

// public class Detyra4{
//     public static void Main(string[] args){
//         int[,] rooms = {
//             {1, 2},
//             {2,3},
//             {2,3},
//             {2,4}
//         };
//         int result =  MinMeetingRooms(rooms);
//         Console.WriteLine(result);
//     }

//     public static int MinMeetingRooms(int[,] rooms){
//         int rows = rooms.GetLength(0);
//         int cols = rooms.GetLength(1);

//         int[] startTimes = new int[rows];
//         int[] endTimes = new int[rows];

//         for(int i =0; i< rows; i++){
//             startTimes[i] = rooms[i, 0];
//             endTimes[i] = rooms[i, 1];
//         }

//         Array.Sort(startTimes);
//         Array.Sort(endTimes);

//         int startPointer = 0, endPointer = 0;
//         int roomsNeeded = 0, maxRooms = 0;

//         while(startPointer < rows){
//             if(startTimes[startPointer] < endTimes[endPointer]){
//                 roomsNeeded++;
//                 startPointer++;
//             }
//             else{
//                 roomsNeeded--;
//                 endPointer++;
//             }
//             maxRooms = Math.Max(maxRooms, roomsNeeded);
//         }

//         return maxRooms;
//     }
// }
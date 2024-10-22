/*
Të shkruhet kodi i cili përmes inputit të userit krijon vargun vargu me n elemente numra të plotë. 
Të kontrollohet nëse ekziston modeli (ang. Pattern) 132 i tre numrave të plotëvargu[i], vargu[j] dhe vargu[k], 
ashtu që të vlej kushti: i<j<k dhe vargu[i]<vargu[k]<vargu[j]. 
Shfaq true nëse ekziston 132 modeli ne atë varg, përndryshe shfaq false.
Shembull:
a)
Hyrja: vargu[3,1,4,2]
Dalja: true
b)
Hyrja: vargu[1,2,3,4]
Dalja: false
*/

// public class Detyra5 {
//     public static void Main(string[] args){
//         int[] array = {1,2,3,4};
//         bool hasPattern132 = Pattern132(array);
//         Console.WriteLine(hasPattern132);
//     }

//     public static bool Pattern132(int[] array){
//         for(int i = 0; i < array.Length - 2; i++){
//             for(int j = i + 1; j < array.Length - 1; j++){
//                 for(int k =  j + 1; k < array.Length; k++){
//                     if(array[i] < array[k] && array[k] < array[j]){
//                         return true;
//                     }
//                 }
//             }
//         }
//         return false;
//     }

// }
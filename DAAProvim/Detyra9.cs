/*
Duke pasur parasysh një varg numrash të plotë, shkruani një funksion që gjen nënvargun e ngjitur me shumën më të madhe.
Nënvargu duhet të jetë i ngjitur, që do të thotë se elementët duhet të jenë në një sekuencë dhe nuk mund të ndahen. 
Funksioni duhet të kthejë shumën e nënvargut. Për shembull, për vargun [-2, 1, -3, 4, -1, 2, 1, -5, 4], s
huma maksimale e nënvargut është 6 (nënvargu është [4, -1, 2, 1] ).
*/

// public class Detyra9{
//     public static void Main(string[] args){
//         int[] array = {-2, 1, -3, 4, -1, 2, 1, -5 , 4};
//         int result = SubArrayMaxSum(array);
//         Console.WriteLine(result);
//     }

//     public static int SubArrayMaxSum(int[] array){
//         int currentSum = array[0];
//         int maxSum = array[0];
//         for(int i = 1; i < array.Length - 1; i++){
//             currentSum  = Math.Max(array[i], currentSum + array[i]);
//             maxSum = Math.Max(maxSum, currentSum);
//         }
//         return maxSum;
//     }
// }
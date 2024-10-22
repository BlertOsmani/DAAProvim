/* 
Ju jepet një matricë e vlerave boolean MxN që përfaqëson një tabelë fushash të lira (True) ose të zëna (False). 
Gjeni madhësinë e katrorit më të madh të fushave të lira. 		
*/

// public class Detyra3 {
//     public static void Main(string[] args){
//         bool[,] tables = {
//             { true, false, true, true },
//             { true, true, true, true },
//             { true, true, true, false },
//             { true, false, false, true }
//         };
//         int maxSquare = LargestSquare(tables);
//         Console.WriteLine(maxSquare);
//     }

//     public static int LargestSquare(bool[,] matrix){
//         int rows = matrix.GetLength(0);
//         int cols = matrix.GetLength(1);
//         if(rows == 0 || cols == 0){
//             return 0;
//         }
//         int[,] dp = new int[rows, cols];
//         int size = 0;
//         for(int i = 0; i < rows; i++){
//             for(int j = 0; j < cols; j++){
//                 if(matrix[i, j]){
//                     if(i == 0 || j == 0){
//                         dp[i,j] = 1;
//                     }
//                     else{
//                         dp[i,j] = Math.Min(Math.Min(dp[i - 1, j], dp[i, j - 1]), dp[i - 1, j - 1]) + 1;
//                     }

//                     size = Math.Max(size, dp[i,j]);
//                 }
//             }
//         }
//         return size;
//     }
// }
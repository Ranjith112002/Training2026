using System;

public class MagicSquare {
   public static bool IsMagicSquare (int[][] mat) {
      if (mat.Length != 3 || mat[0].Length != 3) {
         return false;
      }
      int expectedSum = 0;
      for (int i = 0; i < mat[0].Length; i++) {
         expectedSum += mat[0][i];
      }

      for (int row = 0; row < mat[0].Length; row++) {
         int rowSum = 0;
         for (int col = 0; col < mat[0].Length; col++) {
            rowSum += mat[row][col];
         }

         if (rowSum != expectedSum)
            return false;
      }

      for (int col = 0; col < mat[0].Length; col++) {
         int colSum = 0;
         for (int row = 0; row < mat[0].Length; row++) {
            colSum += mat[row][col];
         }

         if (colSum != expectedSum)
            return false;
      }

      int diagonal1 = mat[0][0] + mat[1][1] + mat[2][2];
      int diagonal2 = mat[0][2] + mat[1][1] + mat[2][0];

      return diagonal1 == expectedSum && diagonal2 == expectedSum;
   }

   public static void Main () {
      int[][][] input =
      {
            new[] { new[] { 8, 1, 6 }, new[] { 3, 5, 7 }, new[] { 4, 9, 2 } },
            new[] { new[] { 2, 7, 6 }, new[] { 9, 5, 1 }, new[] { 4, 3, 8 } },
            new[] { new[] { 8, 1, 6 }, new[] { 3, 5, 7 }, new[] { 4, 2, 9 } }
        };

      foreach (var test in input) {
         Console.WriteLine (IsMagicSquare (test));

      }
   }
}
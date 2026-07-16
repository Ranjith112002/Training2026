using System;
using System.Collections.Generic;

class Program {
   static int[] DaysUntilCooler (int[] temps) {
      int n = temps.Length;
      int[] res = new int[n];
      var stack = new Stack<int> ();
      for (int i = 0; i < n; i++) {
         while (stack.Count > 0 && temps[i] < temps[stack.Peek ()]) {
            int index = stack.Pop ();
            res[index] = i-index;
         }
         stack.Push (i);
      }
      return res;
   }
   static void Main () {
      int[] temperatures = { 30, 31, 29, 32, 28, 27, 30, 25 };
      int result[] = DaysUntilCooler (temperatures);
      for(int i = 0; i < result.length; i++) {
         Console.WriteLine (result[i]);
      }
   }
}
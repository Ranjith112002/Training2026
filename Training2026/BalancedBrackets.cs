using System;
using System.Collections.Generic;

public class Program 
   {
   public static bool BalancedBrackets (string str) {
      Stack<char> stack = new Stack<char> ();
      Dictionary<char, char> pairs = new Dictionary<char, char>
      {
         { ')', '(' },
            { ']', '[' }
        };

      foreach (char ch in str) {
         if (ch == '(' || ch == '[') {
            stack.Push (ch);
         } else if (ch == ')' || ch == ']') {
            if (stack.Count == 0 || stack.Pop () != pairs[ch]) {
               return false;
            }
         }
      }

      return stack.Count == 0;
   }

   public static void Main () {
      Console.WriteLine (BalancedBrackets ("([])"));
      Console.WriteLine (BalancedBrackets ("(]"));
   }
}


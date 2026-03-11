using System;
using System.Collections.Generic;

namespace ListTest
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Option 1: Explicit type
      List<int> numset1 = new List<int>();

      // Option 2: Using 'var' (preferred in modern C#)
      var numset2 = new List<int>();

      // Initializing with values
      List<int> numset3 = new List<int> { 1 };
      var numset4 = new List<int> { 1, 2, 3 }; // Preferred: less repetition of type

      Console.WriteLine(numset3[0]);

      var numset5 = new List<int> { 1, 2, 4, 5, -1 };

      // Reasons to prefer 'var':
      // - Cleaner code, avoids repeating the type
      // - Type is clear from the right side
      // - Widely used in modern C# codebases

      // Explicit type is also correct if extra clarity is needed

      foreach (int x in numset4)
      {
        Console.Write(x + " ");
      }

      // Cannot use: int numset2 = new List<int>();

      for (int i = 0; i < numset5.Count; i++)
      {
        Console.Write($"\n{numset5[i]} ");
      }
    }
  }
}

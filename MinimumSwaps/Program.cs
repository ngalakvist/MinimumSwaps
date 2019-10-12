using System;
using System.Linq;

namespace MinimumSwaps
{
  class Program
  {
    static void Main(string[] args)
    {
     

      /*You are given an unordered array consisting of consecutive integers  [1, 2, 3, ..., n] without any duplicates. You are allowed to swap any two elements. You need to find the minimum number of swaps required to sort the array in ascending order.
         
         For example, given the array  we perform the following steps:
         
         i   arr                         swap (indices)
         0   [7, 1, 3, 2, 4, 5, 6]   swap (0,3)
         1   [2, 1, 3, 7, 4, 5, 6]   swap (0,1)
         2   [1, 2, 3, 7, 4, 5, 6]   swap (3,4)
         3   [1, 2, 3, 4, 7, 5, 6]   swap (4,5)
         4   [1, 2, 3, 4, 5, 7, 6]   swap (5,6)
         5   [1, 2, 3, 4, 5, 6, 7]
         It took  swaps to sort the array. */

      //My notes on important considerations
      //Unordered
      //no duplicates
      //swap
      // conservative integers    
      // find minimun Number os swasps


      var arr = new int[] { 7, 1, 3, 2, 4, 5, 6 };
      var min = int.MaxValue;
      int count = 0;
      int find = 0;
      for (int i = 0; i < arr.Length; i++)
      {
        if (i + 1 != arr[i])
        {
          for (int j = i + 1; j < arr.Length; j++)
          {
            if (arr[j] == i + 1)
            {
              find = j;
              break;
            }
          }
          Swap(arr, i, find);
          count++;
        }

      }

      Console.WriteLine("total swaps :" + count);
      Console.ReadLine();
    }


    private static void Swap(int[] arr, int i, int j)
    {
      Console.WriteLine($"swap({i} , {j})");

      var temp = arr[i];
      arr[i] = arr[j];
      arr[j] = temp;
      arr.ToList().ForEach(n => Console.Write(n + " "));
      Console.WriteLine("");

    }
  }
}

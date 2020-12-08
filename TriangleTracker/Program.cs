using System;
using System.Collections.Generic;
using TriangleTracker;

namespace TriangleTracker
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter the first side of the triangle: ");
      int sideOne = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter the second side of the triangle: ");
      int sideTwo = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter the third side of the triangle: ");
      int sideThree = int.Parse(Console.ReadLine());
      
      int[] nums = {sideOne, sideTwo, sideThree};
    }
  }
}

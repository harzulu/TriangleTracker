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

      Triangle givenTriangle = new Triangle();

      if (givenTriangle.SumOfSmallest(nums) > givenTriangle.LargestNum(nums))
      {
        if(givenTriangle.HowManyDuplicates(nums) == 3)
        {
          Console.WriteLine("Your triangle is an Equilateral!");
        } else if (givenTriangle.HowManyDuplicates(nums) == 2)
        {
          Console.WriteLine("Your triangle is an Iosceles!");
        } else if (givenTriangle.HowManyDuplicates(nums) == 0)
        {
          Console.WriteLine("Your triangle is a Scalene!");
        } else
        {
          Console.WriteLine(givenTriangle.HowManyDuplicates(nums));
        }
      } else
      {
        Console.WriteLine("You entered an invalid triangle....");
        Console.WriteLine(givenTriangle.HowManyDuplicates(nums));
        Console.WriteLine(givenTriangle.SumOfSmallest(nums));
        Console.WriteLine(givenTriangle.LargestNum(nums));
      }


    }
  }
  public class Triangle
  {
    public int ReturnNums(int[] arr)
    {
      return arr[0];
    }

    public bool AnyDuplicates(int[] arr)
    {
      if (arr[0] == arr[1] || arr[0] == arr[2])
      {
        return true;
      } else 
      {
        if (arr[1] == arr[2])
        {
          return true;
        } else
        {
          return false;
        }
      }
    }

    public int HowManyDuplicates(int[] arr)
    {
      if (arr[0] == arr[1])
      {
        if (arr[0] == arr[2])
        {
          return 3;
        } else
        {
          return 2;
        }
      } else 
      {
        if (arr[1] == arr[2])
        {
          return 2;
        } else
        {
          return 0;
        }
      }
    }

    public int LargestNum(int[] arr)
    {
      int largest = 0;
      for (int i = 0; i < arr.Length; i++)
      {
        if (arr[i] > largest)
        {
          largest = arr[i];
        } else
        {
          largest += 0;
        }
      }
      return largest;
    }

    public int SumOfSmallest(int[] arr)
    {
      int largest = LargestNum(arr);
      int sum = 0;

      for (int i = 0; i < arr.Length; i++)
      {
        if (arr[i] == largest)
        {
          sum += 0;
        } else
        {
          sum += arr[i];
        }
      }
      return sum;
    }
  }
}

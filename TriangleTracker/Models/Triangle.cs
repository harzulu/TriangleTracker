namespace TriangleTracker
{
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
  }
}

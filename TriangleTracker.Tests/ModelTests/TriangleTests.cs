using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void ReturnNums_ReturnTheFirstGivenNumber_Num1()
    {
      int[] sides = {3, 7, 8};
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(3, testTriangle.ReturnNums(sides));
    }

    [TestMethod]
    public void AnyDuplicates_ReturnIfThereAreDuplicates_True()
    {
      int[] sides = {3, 7, 8};
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(false, testTriangle.AnyDuplicates(sides));
    }

    [TestMethod]
    public void HowManyDuplicates_ReturnHowManyDuplicates_0()
    {
      int[] sides = {3, 7, 8};
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(0, testTriangle.HowManyDuplicates(sides));
    }

    [TestMethod]
    public void LargestNum_ReturnTheLargestNumber_8()
    {
      int[] sides = {3, 7, 8};
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(8, testTriangle.LargestNum(sides));
    }

    [TestMethod]
    public void SumOfSmallest_ReturnTheSumOfTheSmallestNumbers_7()
    {
      int[] sides = {3, 7, 8};
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(10, testTriangle.SumOfSmallest(sides));
    }
  }
}
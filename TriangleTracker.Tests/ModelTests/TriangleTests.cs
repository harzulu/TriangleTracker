using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void ReturnNums_ReturnTheGivenNumbers_Num1Num2Num3()
    {
      int[] sides = {3, 4, 8};
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(7, testTriangle.ReturnNums(sides));
    }
  }
}
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
      int[] sides = {3, 4, 8};
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(3, testTriangle.ReturnNums(sides));
    }

    [TestMethod]
    public void AnyDuplicates_ReturnIfThereAreDuplicates_True()
    {
      int[] sides = {3, 4, 8};
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.AnyDuplicates(sides));
    }
  }
}
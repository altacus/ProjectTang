using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void FirstTests()
        {
            int[] records = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int result = SumArray(records);
            Assert.AreEqual(45, result);

            /* Note this test fails, but I want you to make 
               it pass by modifying the SumArray2 method*/
            result = SumArray2(records);
            Assert.AreEqual(45, result);
        }

        int SumArray(int[] arrayToSum)
        {
            int totalSum;
            totalSum = 0;

            foreach(int x in arrayToSum)
            {
                totalSum = totalSum + x;
            }
            return totalSum;
        }

        /// <summary>
        /// Please implement the SumArray function, but instead of using a foreach loop,
        /// use a for loop.
        /// https://msdn.microsoft.com/en-us/library/ch45axte.aspx
        /// http://www.dotnetperls.com/for
        /// </summary>
        /// <param name="arrayToSum"></param>
        /// <returns></returns>
        int SumArray2(int[] arrayToSum)
        {
            return 0;
        }
    }
}

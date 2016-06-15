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

        [TestMethod]
        public void TestDate()
        {
            var c = new DateTime(2016, 5, 12);
            var startOfThird = c.AddDays(196);
            Assert.AreEqual(DateTime.Parse("11/24/2016"), startOfThird);

            var expectedDate = c.AddDays(280);
            Assert.AreEqual(DateTime.Parse("02/16/2017"), expectedDate);
        }

        [TestMethod]
        public void TestSwitch() {
            string result1 = SwtichLogic("hll");
            Assert.AreEqual("", result1);

            result1 = SwtichLogic("hello");
            Assert.AreEqual("eo", result1);
            result1 = SwtichLogic("we are at starbucks");
            Assert.AreEqual("eaeaau", result1);

            result1 = SwtichLogic("HELLO");
            Assert.AreEqual("eo", result1);

            result1 = SwtichLogic("AeIoU");
            Assert.AreEqual("aeiou", result1);

            result1 = SwtichLogic("AeIoU 3123");
            Assert.AreEqual("aeiou", result1);
        }

        string SwtichLogic(string input)
        {
            string temp = input.ToLower();
            string result = "";
            for (int i = 0; i < temp.Length; i++)
            {
                switch (temp[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        result = result+ temp[i];
                        break;
                }
            }
            return result;
        }


        [TestMethod]
        public void TestChar()
        {
            char c = '0';
            int x = (int)c;
            Assert.AreEqual(48, x);

            x = ((int)c) - '0';
            Assert.AreEqual(0, x);

            x = ((int)c) - 48;
            Assert.AreEqual(0, x);
        }

        [TestMethod]
        public void TestIsBetween()
        {
            bool result = IsBetween(0, 100, 99);
            Assert.IsTrue(result);

            result = IsBetween(0, 10, 0);
            Assert.IsTrue(result);
        }

        bool IsBetween(int start, int end, int value)
        {
            if (value >= start &&
                value <= end)
                return true;
            return false;
        }

        [TestMethod]
        public void TestSwitchNum()
        {
            string result1 = SwtichLogicNum("");
            Assert.AreEqual("", result1);

            result1 = SwtichLogicNum("hel 127 lo 129");
            Assert.AreEqual("127129", result1);
        }


        // Simplify switch statement with math
        string SwtichLogicNum(string input)
        {
            string temp = input.ToLower();
            string result = "";
            for (int i = 0; i < temp.Length; i++)
            {
            }
            return result;
        }
    } 
}

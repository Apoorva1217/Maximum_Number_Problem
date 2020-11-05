using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Find_Maximum_Number_Problem;


namespace Find_Maximum_Number_Tests
{
    [TestClass]
    public class Test
    {
        [TestClass]
        public class MaximumNumberTest
        {
            /// <summary>
            /// TC 1.1 Given Max Number at 1st Position return the Same Number
            /// </summary>
            [TestMethod]
            public void GivenMaxNumberAtFirstPosition_ShouldReturnSameNumber()
            {
                int expected = 22;
                int result = MaximumNumberCheck.MaximumNumber(22, 17, 12);
                Assert.AreEqual(expected, result);
            }

            /// <summary>
            /// TC 1.2 Given Max Number at 2nd Position return the Same Number
            /// </summary>
            [TestMethod]
            public void GivenMaxNumberAtSecondPostion_ShouldReturnSameNumber()
            {
                int expected = 22;
                int result = MaximumNumberCheck.MaximumNumber(12, 22, 11);
                Assert.AreEqual(expected, result);
            }

            /// <summary>
            /// TC 1.3 Given Max Number at 3rd Position return the Same Number
            /// </summary>
            [TestMethod]
            public void GivenMaxNumberAtThirdPosition_ShouldReturnSameNumber()
            {
                int expected = 22;
                int result = MaximumNumberCheck.MaximumNumber(11, 17, 22);
                Assert.AreEqual(expected, result);
            }

            /// <summary>
            /// TC 2.1 Given Max float Number at 1st Position return the Same Number
            /// </summary>
            [TestMethod]
            public void GivenMaxFloatNumberAtFirstPosition_ShouldReturnSameNumber()
            {
                double expected = 22.5;
                double result = MaximumNumberCheck.MaximumFloatNumber(22.5, 17.2, 12.6);
                Assert.AreEqual(expected, result);
            }

            /// <summary>
            /// TC 2.2 Given Max float Number at 2nd Position return the Same Number
            /// </summary>
            [TestMethod]
            public void GivenMaxFloatNumberAtSecondPostion_ShouldReturnSameNumber()
            {
                double expected = 22.5;
                double result = MaximumNumberCheck.MaximumFloatNumber(12.6, 22.5, 11.2);
                Assert.AreEqual(expected, result);
            }

            /// <summary>
            /// TC 2.3 Given Max float Number at 3rd Position return the Same Number
            /// </summary>
            [TestMethod]
            public void GivenMaxFloatNumberAtThirdPosition_ShouldReturnSameNumber()
            {
                double expected = 22.5;
                double result = MaximumNumberCheck.MaximumFloatNumber(11.2, 17.2, 22.5);
                Assert.AreEqual(expected, result);
            }

            /// <summary>
            /// TC 3.1 Given Max string at 1st Position return the Same string
            /// </summary>
            [TestMethod]
            public void GivenMaxStringAtFirstPosition_ShouldReturnSameString()
            {
                string expected = "Peach";
                string result = MaximumNumberCheck.MaximumString("Peach", "Apple", "Banana");
                Assert.AreEqual(expected, result);
            }

            /// <summary>
            /// TC 3.2 Given Max string at 2nd Position return the Same string
            /// </summary>
            [TestMethod]
            public void GivenMaxStringAtSecondPostion_ShouldReturnSameString()
            {
                string expected = "Peach";
                string result = MaximumNumberCheck.MaximumString("Apple", "Peach", "Banana");
                Assert.AreEqual(expected, result);
            }

            /// <summary>
            /// TC 3.3 Given Max string at 3rd Position return the Same string
            /// </summary>
            [TestMethod]
            public void GivenMaxStringAtThirdPosition_ShouldReturnSameStringr()
            {
                string expected = "Peach";
                string result = MaximumNumberCheck.MaximumString("Apple", "Banana", "Peach");
                Assert.AreEqual(expected, result);
            }
        }
    }
}

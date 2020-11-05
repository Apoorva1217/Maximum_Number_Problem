using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        }
    }
}

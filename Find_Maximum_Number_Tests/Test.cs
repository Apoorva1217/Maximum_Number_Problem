using Find_Maximum_Number_Problem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Find_Maximum_Number_Tests
{
    [TestClass]
    public class Test
    {
        /// <summary>
        /// Given IntArray Should Return Maximum Number
        /// </summary>
        [TestMethod]
        public void GivenIntArray_ShouldReturnMaximumNumber()
        {
            int[] intArray = { 12, 22, 11, 17 };
            int expected = 22;
            MaximumNumberCheck<int> maximumNumberCheck = new MaximumNumberCheck<int>(intArray);
            int result = maximumNumberCheck.MaxMethod();
            Assert.AreEqual(expected, result);
        }
        /// <summary>
        /// Given FloatArray Should Return Maximum Float Number
        /// </summary>
        [TestMethod]
        public void GivenFloatArray_ShouldReturnMaximumFloatNumber()
        {
            float[] floatArray = { 12.4f, 22.6f, 17.4f, 11.9f };
            float expected = 22.6f;
            MaximumNumberCheck<float> maximumNumberCheck = new MaximumNumberCheck<float>(floatArray);
            float result = maximumNumberCheck.MaxMethod();
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Given StringArray Should Return Maximum String
        /// </summary>
        [TestMethod]
        public void GivenStringArray_ShouldReturnMaximumString()
        {
            string[] stringArray = {"Apple","Peach","Banana","Cherry" };
            string expected = "Peach";
            MaximumNumberCheck<string> maximumNumberCheck = new MaximumNumberCheck<string>(stringArray);
            string result = maximumNumberCheck.MaxMethod();
            Assert.AreEqual(expected, result);
        }
    }
}

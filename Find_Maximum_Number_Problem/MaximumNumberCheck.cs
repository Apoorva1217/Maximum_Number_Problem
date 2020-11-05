using System;
using System.Collections.Generic;
using System.Text;

namespace Find_Maximum_Number_Problem
{
    public class MaximumNumberCheck
    {
        public class GenericMaximum<T> where T : IComparable
        {
            public T firstValue, secondValue, thirdValue;

            /// <summary>
            /// Initialize instance of class
            /// </summary>
            /// <param name="firstValue"></param>
            /// <param name="secondValue"></param>
            /// <param name="thirdValue"></param>
            public GenericMaximum(T firstValue, T secondValue, T thirdValue)
            {
                this.firstValue = firstValue;
                this.secondValue = secondValue;
                this.thirdValue = thirdValue;
            }
            /// <summary>
            /// MaxValue method to find maximum number
            /// </summary>
            /// <param name="firstValue"></param>
            /// <param name="secondValue"></param>
            /// <param name="thirdValue"></param>
            /// <returns></returns>
            public static T MaxValue(T firstValue, T secondValue, T thirdValue)
            {
                if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                {
                    return firstValue;
                }
                if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                {
                    return secondValue;
                }
                if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
                {
                    return thirdValue;
                }

                throw new Exception("firstValue,secondValue,thirdValue are same");
            }

            /// <summary>
            /// Method to return maximum number
            /// </summary>
            /// <returns></returns>
            public T MaxMethod()
            {
                T max = GenericMaximum<T>.MaxValue(this.firstValue, this.secondValue, this.thirdValue);
                return max;
            }
        }
    }
}

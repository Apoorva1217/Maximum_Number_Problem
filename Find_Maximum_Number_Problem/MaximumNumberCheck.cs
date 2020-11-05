using System;
using System.Collections.Generic;
using System.Text;

namespace Find_Maximum_Number_Problem
{
    public class MaximumNumberCheck<T> where T : IComparable
    {
        public T[] value;

        /// <summary>
        /// Initializes instance of the class
        /// </summary>
        /// <param name="value">The value.</param>
        public MaximumNumberCheck(T[] value)
        {
            this.value = value;
        }

        /// <summary>
        /// Sorts the values
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        public T MaxValue(params T[] values)
        {
            var sorted_Values = Sort(values);
            return sorted_Values[^1];
        }

        /// <summary>
        /// Maximums the method.
        /// </summary>
        /// <returns></returns>
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }

        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is: " + max);
        }
    }
}

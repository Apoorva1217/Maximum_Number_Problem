﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Find_Maximum_Number_Problem
{
    public class MaximumNumberCheck
    {
        /// <summary>
        /// UC1- Given 3 Integers find the maximum number
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <param name="thirdValue"></param>
        /// <returns></returns>
        public static int MaximumNumber(int firstValue, int secondValue, int thirdValue)
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
        /// UC2- Given 3 float find the maximum number
        /// </summary>
        /// <param name="firstFloatValue"></param>
        /// <param name="secondFloatValue"></param>
        /// <param name="thirdFloatValue"></param>
        /// <returns></returns>
        public static double MaximumFloatNumber(double firstFloatValue, double secondFloatValue, double thirdFloatValue)
        {
            if (firstFloatValue.CompareTo(secondFloatValue) > 0 && firstFloatValue.CompareTo(thirdFloatValue) > 0)
            {
                return firstFloatValue;
            }
            if (secondFloatValue.CompareTo(firstFloatValue) > 0 && secondFloatValue.CompareTo(thirdFloatValue) > 0)
            {
                return secondFloatValue;
            }
            if (thirdFloatValue.CompareTo(firstFloatValue) > 0 && thirdFloatValue.CompareTo(secondFloatValue) > 0)
            {
                return thirdFloatValue;
            }
            throw new Exception("firstFloatValue,secondFloatValue,thirdFloatValue are same");
        }

        /// <summary>
        /// UC3- Given 3 string find the maximum 
        /// </summary>
        /// <param name="firstStringValue"></param>
        /// <param name="secondStringValue"></param>
        /// <param name="thirdStringValue"></param>
        /// <returns></returns>
        public static string MaximumString(string firstStringValue, string secondStringValue, string thirdStringValue)
        {
            if (firstStringValue.CompareTo(secondStringValue) > 0 && firstStringValue.CompareTo(thirdStringValue) > 0)
            {
                return firstStringValue;
            }
            if (secondStringValue.CompareTo(firstStringValue) > 0 && secondStringValue.CompareTo(thirdStringValue) > 0)
            {
                return secondStringValue;
            }
            if (thirdStringValue.CompareTo(firstStringValue) > 0 && thirdStringValue.CompareTo(secondStringValue) > 0)
            {
                return thirdStringValue;
            }
            throw new Exception("firstStringValue,secondStringValue,thirdStringValue are same");
        }
    }
}

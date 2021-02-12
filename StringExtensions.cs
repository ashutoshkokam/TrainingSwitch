using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingSwitch
{
    public static class StringExtensions
    {
        /// <summary>
        /// Returns Trimmed Desc
        /// </summary>
        /// <param name="item"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string TrimDesc(this string item, int value)
        {
            return item.Substring(0, value)+"...";
        }
        /// <summary>
        /// Returns Word Count
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static int GetWordCount(this string item)
        {
            return item.Length;
        }
    }
}

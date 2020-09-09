using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Insert spaces before each capital leter in a string.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
        {
            StringBuilder result = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(source))
            {
                foreach(char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result.Append(" ");
                    }
                    result.Append(letter);
                }
            }

            return result.ToString();
        }
    }
}

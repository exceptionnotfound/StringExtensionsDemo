using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringExtensionsDemo
{
    public static class Extensions
    {
        public static string RemoveLastOccuranceOf(this string input, string toMatch)
        {
            if (input.Contains(toMatch))
            {
                int lastIndex = input.LastIndexOf(toMatch);
                return input.Substring(0, lastIndex);
            }
            else return input;
        }

        public static string RemoveLastOccuranceOf(this string input, char toMatch)
        {
            if (input.Contains(toMatch))
            {
                int lastIndex = input.LastIndexOf(toMatch);
                return input.Substring(0, lastIndex);
            }
            else return input;
        }

        public static string ToDelimitedList(this List<string> items, char delimiter = ',')
        {
            if (!items.Any()) return string.Empty;

            string result = "";

            foreach(var item in items)
            {
                result += item + delimiter;
            }

            return result.RemoveLastOccuranceOf(delimiter);
        }

        public static List<string> ToCollection(this string input, char delimiter = ',')
        {
            if(!input.Contains(delimiter))
            {
                return new List<string> { input };
            }
            return input.Split(delimiter).ToList();
        }

        public static string RemoveCharacters(this string input, List<char> chars)
        {
            string result = input;
            foreach(var c in chars)
            {
                result = result.Replace(c.ToString(), string.Empty);
            }

            return result;
        }

        public static string Excerpt(this string input, int characters)
        {
            if (input.Length <= characters)
                return input;
            else return input.Substring(0, characters) + "...";
        }
    }
}

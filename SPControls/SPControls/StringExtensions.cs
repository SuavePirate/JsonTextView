using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SPControls
{
    public static class StringExtensions
    {
        public static string SplitCamelCase(this string str)
        {
            return Regex.Replace(
                Regex.Replace(
                    str,
                    @"(\P{Ll})(\P{Ll}\p{Ll})",
                    "$1 $2"
                ),
                @"(\p{Ll})(\P{Ll})",
                "$1 $2"
            );
        }
        public static string ToTitleCase(this string str)
        {
            return string.Join(" ", str.Split(' ').Select(i => $"{i.Substring(0, 1).ToUpper()}{i.Substring(1).ToLower()}").ToArray());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ToDoWebApp.Components
{
    public static class StringUtils
    {
        /// <summary>
        /// Convert words to camel case
        /// </summary>
        /// <param name="text">input text</param>
        /// <returns>converted text</returns>
        public static string ToCamel(string text)
        {
            return Regex.Replace(
                text,
                @"(\b[^\s]+\b)",
                m => (m.Value.First().ToString().ToUpper() + String.Join("", m.Value.Skip(1)).ToLower()));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Valuto.Infrastructure.Extensions
{
    public static class StringExtensions
    {
        public static string ToUpperSnakeCase(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            var snake = Regex.Replace(input, @"([a-z0-9])([A-Z])", "$1_$2");

            snake = snake.Replace("-", "_").Replace("__", "_");

            return snake.ToUpperInvariant();
        }
    }
}

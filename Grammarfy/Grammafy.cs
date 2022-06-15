using Grammarfy.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Grammarfy
{
    public static class Grammafy
    {
        /// <summary>
        /// Should Grammafy use contractions? Defaults to false. e.g would not => wouldn't etc.
        /// </summary>
        public static bool UseContractions { get; set; } = false;

        /// <summary>
        /// Should Grammafy apply casing to string? Defaults to Retain.
        /// </summary>
        public static Case Case { get; set; } = Case.Retain;

        /// <summary>
        /// This uses the type name of the entity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity">The object Grammafy uses to get the type name from.</param>
        /// <param name="total">Used to concatinate 's' on the end of the type name.</param>
        /// <param name="case">Upper, Lower or Retain.</param>
        /// <returns></returns>
        public static string Plural<T>(this T entity, int total, Case? @case = null) where T : class
        {
            return Generate(total, entity.GetType().Name, @case);
        }

        /// <summary>
        /// This will generate the correct grammar, extending from the total.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="entityName"></param>
        /// <returns></returns>
        public static string Plural(this int total, string entityName, Case? @case = null)
        {
            return Generate(total, $"{total} {entityName}", @case);
        }

        private static string Generate(int total, string value, Case? @case = null)
        {
            if (!@case.HasValue)
                @case = Case;

            switch (@case)
            {
                case Case.Retain:
                    break;

                case Case.Lower:
                    value = value.ToLowerInvariant();
                    break;

                case Case.Upper:
                    value = value.ToUpperInvariant();
                    break;
            }

            if (value.EndsWith('s'))
                value = value.Substring(0, value.Length - 1);

            if (total > 1)
                return $"{value}s";

            return value;
        }
    }
}

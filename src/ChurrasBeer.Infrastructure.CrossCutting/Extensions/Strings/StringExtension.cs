using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ChurrasBeer.Infrastructure.CrossCutting.Extensions.Strings
{
    public static class StringExtension
    {
        public static string WithMaxLength(this string value, int maxLength)
        {
            return value.Substring(0, Math.Min(value.Length, maxLength));
        }

        public static string ToOnlyNumbers(this string value)
        {
            string OnlyNumbersPattern = @"[^\d]";

            return Regex.Replace(value, OnlyNumbersPattern, string.Empty);
        }

        public static string RemoveAccents(this string value)
        {
            string normalized = value.Normalize(NormalizationForm.FormKD);
            Encoding removal = Encoding.GetEncoding(Encoding.ASCII.CodePage,
                                                    new EncoderReplacementFallback(""),
                                                    new DecoderReplacementFallback(""));
            byte[] bytes = removal.GetBytes(normalized);
            return Encoding.ASCII.GetString(bytes);
        }

        public static string ToTitleCase(this string value)
        {
            var textInfo = CultureInfo.CurrentCulture.TextInfo;

            return textInfo.ToTitleCase(value.ToLower());
        }

        public static bool ContainsLetters(this string value)
        {
            return Regex.Matches(value, @"[a-zA-Z]").Count > 0;
        }
    }
}

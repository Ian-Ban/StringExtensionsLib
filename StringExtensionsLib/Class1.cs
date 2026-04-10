namespace StringExtensionsLib
{
    public static class StringExtensions
    {
        public static bool StartsWithUppercase(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            return char.IsUpper(input[0]);
        }
    }
}
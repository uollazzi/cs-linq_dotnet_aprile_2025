public static class StringExtensions
{
    public static string ToZigZag(this string str)
    {
        var result = string.Empty;

        var virtualIndex = 0;
        foreach (var c in str)
        {
            if (virtualIndex % 2 == 0)
            {
                result += c.ToString().ToUpper();
            }
            else
            {
                result += c.ToString().ToLower();
            }

            if (c.ToString() != " ")
                virtualIndex++;
        }

        return result;
    }
}
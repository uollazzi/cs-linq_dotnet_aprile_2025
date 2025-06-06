using System.Text.RegularExpressions;

namespace cs_linq;

public class IgnoraNumeriComparer : IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        if (!string.IsNullOrEmpty(x))
        {
            x = Regex.Replace(x, @"\d", string.Empty).Trim();
        }

        if (!string.IsNullOrEmpty(y))
        {
            y = Regex.Replace(y, @"\d", string.Empty).Trim();
        }

        return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
    }
}
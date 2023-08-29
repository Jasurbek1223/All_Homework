using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace N32_T5;

public static class CustomValidator
{
    public static string? IsValidEmailAddress(string? emailAddress)
    {
        if (string.IsNullOrWhiteSpace(emailAddress))
            return "Email address is required.";

        if (emailAddress.Length < 5 && !Regex.IsMatch(emailAddress, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            return "Minimum length is 5";

        return null;
    }
}
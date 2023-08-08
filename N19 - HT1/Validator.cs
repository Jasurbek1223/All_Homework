using System.Globalization;
using System.Text.RegularExpressions;

namespace N19___HT1;

internal static class Validator
{
    public static bool IsValidName(string name, out string formattedName)
    {
        Regex regex = new Regex(@"^[A-Za-z\s]+$");

        if(regex.IsMatch(name))
        {
            formattedName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower()).Trim();
            return true;
        }
        else
        {
            formattedName = null;
            return false;
        }
    }

    public static bool IsValidEmailAddress(string emailAddress, out string formattedEmailAddress)
    {
        Regex regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

        if(regex.IsMatch(emailAddress))
        {
            formattedEmailAddress = emailAddress.Trim();
            return true;
        }
        else
        {
            formattedEmailAddress = null;
            return false;
        }
    }


    public static bool IsValidAge(int age)
    {
        return age > 0 && age < 120;
    }

    public static bool IsValidPhoneNumber(string phoneNumber, out string formattedPhoneNumber)
    {
        Regex regex = new Regex(@"^\d{10}$");

        if (regex.IsMatch(phoneNumber))
        {
            formattedPhoneNumber = phoneNumber.Trim();
            return true;
        }
        else
        {
            formattedPhoneNumber = null;
            return false;
        }
    }


}

using System;
using System.Text.RegularExpressions;
namespace ChapterOne{
class Password
{
    static void Main()
    {
        Console.WriteLine("Enter your password:");
        string password = Console.ReadLine();

        if (IsStrongPassword(password))
        {
            Console.WriteLine("Strong");
        }
        else
        {
            Console.WriteLine("Weak");
        }
    }

    static bool IsStrongPassword(string password)
    {
        if (password.Length < 8)
            return false;

        bool hasUppercase = false;
        bool hasLowercase = false;
        bool hasDigit = false;
        bool hasSpecialChar = false;

        foreach (char c in password)
        {
            if (char.IsUpper(c))
                hasUppercase = true;
            else if (char.IsLower(c))
                hasLowercase = true;
            else if (char.IsDigit(c))
                hasDigit = true;
            else if (IsSpecialCharacter(c))
                hasSpecialChar = true;

            // If all conditions are met, return true
            if (hasUppercase && hasLowercase && hasDigit && hasSpecialChar)
                return true;
        }

        return false;
    }

    static bool IsSpecialCharacter(char c)
    {
        string specialChars = "!@#$%^&*()_+{}|:<>?-=[]\\;',./`~\"";
        return specialChars.Contains(c);
    }
}
}
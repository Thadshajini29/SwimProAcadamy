using System;
using System.Security.Cryptography;
using System.Text;

public static class PasswordHelper
{
    // This stores a one-way SHA-256 value instead of plain-text passwords.
    public static string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder result = new StringBuilder();

            foreach (byte value in bytes)
            {
                result.Append(value.ToString("x2"));
            }

            return result.ToString();
        }
    }
}

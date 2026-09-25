using System.Security.Cryptography;
using System.Text;

namespace SwimProAcadamy;

/// <summary>
/// Keeps password conversion in one place. Passwords are not stored as plain text.
/// </summary>
public static class PasswordHelper
{
    public static string HashPassword(string password)
    {
        byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
        byte[] hashBytes = SHA256.HashData(passwordBytes);
        return Convert.ToHexString(hashBytes);
    }
}

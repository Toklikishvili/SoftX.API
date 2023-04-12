namespace SoftX.WEB.Exceptions;

public static class AppException
{

    public static string HashPassword(this string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password); 
    }

    public static bool VerifyHashPassword(this string password, string hash)
    {
        if (BCrypt.Net.BCrypt.Verify(password, hash))
            return true;
        return false;
    }
}

namespace TechLibrary.Api.Infraestructure.Security.Cryptography
{
    using BCrypt;
    public class BCryptAlgorithm
    {
        public string HasPaswword(string password) => BCrypt.Net.BCrypt.HashPassword(password);
    }
}

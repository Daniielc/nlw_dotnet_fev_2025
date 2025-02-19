namespace TechLibrary.Api.Infraestructure.Security.Cryptography
{
    using BCrypt;
    using TechLibrary.Api.Domain.Entities;

    public class BCryptAlgorithm
    {
        public string HasPaswword(string password) => BCrypt.Net.BCrypt.HashPassword(password);
        public bool Verify(string password, User user) => BCrypt.Net.BCrypt.Verify(password, user.Password);
    }
}

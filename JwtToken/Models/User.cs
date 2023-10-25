namespace JwtToken.Models
{
    public class User
    {
        public string Username { get; set; } = default!;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}

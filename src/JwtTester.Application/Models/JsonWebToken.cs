namespace JwtTester.Application.Models
{
    public class JsonWebToken
    {
        public string AccessToken { get; set; }
        public RefreshToken RefreshToken { get; set; }
        public string TokenType { get; set; }
        public long ExpiresIn { get; set; }
    }
}

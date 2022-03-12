namespace API.DTOs
{
    public class UserDto
    {
        public string DisplayName { get; set; }
        public string Token { get; set; } //Autenticaçao API
        public string Username { get; set; }
        public string Image { get; set; }
        public string? Bio { get; set; }
    }
}
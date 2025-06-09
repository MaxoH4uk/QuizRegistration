using Newtonsoft.Json;

namespace QuizRegistration.Models
{
    public class UserCredentials
    {
        [JsonProperty("email")] public string Email { get; set; }

        [JsonProperty("password")] public string Password { get; set; }

        public UserCredentials(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}

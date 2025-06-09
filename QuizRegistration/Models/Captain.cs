using Newtonsoft.Json;

namespace QuizRegistration.Models
{
    public class Captain
    {
        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("email")] public string Email { get; set; }

        [JsonProperty("phone")] public string Phone { get; set; }
    }
}

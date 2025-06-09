using System.Collections.Generic;
using Newtonsoft.Json;

namespace QuizRegistration.Models
{
    public class UserInfo
    {
        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("email")] public string Email { get; set; }

        [JsonProperty("phone")] public string Phone { get; set; }

        [JsonProperty("teams")] public List<Team> Teams { get; set; }
    }
}

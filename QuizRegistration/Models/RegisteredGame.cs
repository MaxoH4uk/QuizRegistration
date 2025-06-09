using Newtonsoft.Json;

namespace QuizRegistration.Models
{
    public class RegisteredGame
    {
        [JsonProperty("id")] public uint Id { get; set; }

        [JsonProperty("player_count")] public string PlayerCount { get; set; }

        [JsonProperty("place")] public string Place { get; set; }

        [JsonProperty("game_name")] public string GameName { get; set; }

        [JsonProperty("address")] public string Address { get; set; }
        
        [JsonProperty("created_at")] public string RegistrationAt { get; set; }

        [JsonProperty("played_at")] public string PlayedAt { get; set; }
    }
}

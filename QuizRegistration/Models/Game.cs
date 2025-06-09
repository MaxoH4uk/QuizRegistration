using Newtonsoft.Json;

namespace QuizRegistration.Models
{
    public class Game
    {
        [JsonProperty("uuid")] public string Uuid { get; set; }

        [JsonProperty("event_record_id")] public string EventRecordId { get; set; }

        [JsonProperty("place")] public string Place { get; set; }

        [JsonProperty("game_name")] public string GameName { get; set; }

        [JsonProperty("address")] public string Address { get; set; }
        
        [JsonProperty("registration_at")] public string RegistrationAt { get; set; }

        [JsonProperty("played_at")] public string PlayedAt { get; set; }
        
        [JsonProperty("media_banner")] public MediaItem MediaBanner { get; set; }
    }
    
    public class MediaItem
    {
        public string Head { get; set; }
    }
}

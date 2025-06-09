using Newtonsoft.Json;

namespace QuizRegistration.Models
{
    public class Team
    {
        [JsonProperty("id")] public uint Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("city_id")] public uint CityId { get; set; }

        [JsonProperty("captain")] public Captain Captain { get; set; }
    }
}

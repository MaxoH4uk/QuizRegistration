using Newtonsoft.Json;

namespace QuizRegistration.Models
{
    public class Activation
    {
        [JsonProperty("active")] public bool IsActive { get; set; }
    }
}

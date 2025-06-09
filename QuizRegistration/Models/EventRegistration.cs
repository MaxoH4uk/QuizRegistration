using System.Collections.Generic;
using Newtonsoft.Json;

namespace QuizRegistration.Models;

public class EventRegistration
{
    [JsonProperty("event_day_id")] public string EventDayId { get; set; }
    [JsonProperty("team_id")] public uint TeamId { get; set; }
    [JsonProperty("captain_phone")] public string CaptainPhone { get; set; }
    [JsonProperty("comment")] public string Comment { get; set; }
    [JsonProperty("email")] public string Email { get; set; }
    [JsonProperty("player_count")] public byte PlayerCount { get; set; }
    [JsonProperty("captain_name")] public string CaptainName { get; set; }
    [JsonProperty("team_name")] public string TeamName { get; set; }
    [JsonProperty("team_names")] public string TeamNames { get; set; }
    [JsonProperty("promocode")] public string Promocode { get; set; }
    [JsonProperty("play_for_first_time")] public bool PlayForFirstTime { get; set; }

    [JsonProperty("takes_other_participants")]
    public bool TakesOtherParticipants { get; set; }

    [JsonProperty("has_birthday")] public bool HasBirthday { get; set; }
    [JsonProperty("birth_date")] public string BirthDate { get; set; }
    [JsonProperty("celebrant")] public string Celebrant { get; set; }
    [JsonProperty("sms")] public string Sms { get; set; }
    [JsonProperty("company_comment")] public string CompanyComment { get; set; }
    [JsonProperty("company_name")] public string CompanyName { get; set; }
    [JsonProperty("company_files")] public List<string> CompanyFiles { get; set; }
    
    public EventRegistration(Game game, Team team, byte playersCount)
    {
        EventDayId = game.Uuid;
        TeamId = team.Id;
        CaptainPhone = team.Captain.Phone;
        Comment = "";
        Email = team.Captain.Email;
        PlayerCount = playersCount;
        CaptainName = team.Captain.Name;
        TeamName = team.Name;
        TeamNames = "";
        Promocode = "";
        PlayForFirstTime = false;
        TakesOtherParticipants = false;
        HasBirthday = false;
        BirthDate = "";
        Celebrant = "";
        Sms = "";
        CompanyComment = "";
        CompanyName = "";
        CompanyFiles = new List<string>();
    }
}

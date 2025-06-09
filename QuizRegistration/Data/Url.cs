namespace QuizRegistration.Data
{
    public static class Url
    {
        public const string BaseUrl = "https://api.rudagames.com";
        public const string Login = "/login";
        public const string GamesList = "events/dates/160";
        public const string RegisteredGamesList = "players/applications?city_id=160";
        public const string UserInfo = "players/me";
        public const string Registration = "players/applications";
        public const string CancelRegistration = "players/applications/{0}";
        public const string YandexDownload = "https://cloud-api.yandex.net/v1/disk/public/resources/download?";
        public const string YandexPublicKey = "https://disk.yandex.ru/d/I6wzQoVzxUqJkA";
    }
}

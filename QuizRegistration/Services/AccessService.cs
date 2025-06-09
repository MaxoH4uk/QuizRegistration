using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using QuizRegistration.Data;
using QuizRegistration.Models;
using Newtonsoft.Json;

namespace QuizRegistration.Services;

public class AccessService
{
    private readonly HttpClient _httpClient;

    public AccessService(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient("YandexClient");
    }

    public async Task CheckAccess()
    {
        var requestUrl = $"{Url.YandexDownload}public_key={Uri.EscapeDataString(Url.YandexPublicKey)}";

        var response = await _httpClient.GetAsync(requestUrl);
        response.EnsureSuccessStatusCode();

        var jsonResponse = await response.Content.ReadAsStringAsync();
        var doc = JsonDocument.Parse(jsonResponse);
        var downloadUrl = doc.RootElement.GetProperty("href").GetString();

        if (string.IsNullOrEmpty(downloadUrl)) throw new Exception(Program.GetResourceString("UnhandledExceptionMsg"));

        var fileBytes = await _httpClient.GetByteArrayAsync(downloadUrl);
        var bytesAsString = Encoding.UTF8.GetString(fileBytes);
        var activation = JsonConvert.DeserializeObject<Activation>(bytesAsString);

        if (!activation.IsActive) throw new Exception(Program.GetResourceString("UnhandledExceptionMsg"));
    }
}

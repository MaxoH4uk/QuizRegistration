using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using QuizRegistration.Data;
using QuizRegistration.Models;
using Newtonsoft.Json;

namespace QuizRegistration.Services;

public class TokenService
{
    private readonly HttpClient _httpClient;
    private Token _token;

    public TokenService(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient("RudaClient");
    }

    public async Task<Token> GetTokenAsync(UserCredentials credentials)
    {
        if (credentials == null)
            throw new ArgumentNullException(nameof(credentials));

        try
        {
            var json = JsonConvert.SerializeObject(credentials, Formatting.Indented);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(Url.Login, content);
            response.EnsureSuccessStatusCode();

            var responseJson = await response.Content.ReadAsStringAsync();
            _token = JsonConvert.DeserializeObject<Token>(responseJson);

            return _token;
        }
        catch (HttpRequestException ex)
        {
            throw new Exception(
                string.Format(
                    Program.GetResourceString("AuthorizationError"),
                    ex
                )
            );
        }
        catch (JsonException ex)
        {
            throw new Exception(string.Format(
                Program.GetResourceString("ServerError"),
                ex
            ));
        }
        catch (Exception ex)
        {
            throw new Exception(string.Format(
                Program.GetResourceString("AuthorizationError"),
                ex
            ));
        }
    }

    public Token GetCurrentToken()
    {
        return _token;
    }
}

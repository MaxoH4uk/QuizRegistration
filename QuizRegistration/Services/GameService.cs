using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using QuizRegistration.Data;
using QuizRegistration.Models;
using Newtonsoft.Json;

namespace QuizRegistration.Services;

public class GameService
{
    private readonly HttpClient _httpClient;
    private readonly TokenService _tokenService;

    public GameService(TokenService tokenService, IHttpClientFactory factory)
    {
        _tokenService = tokenService;
        _httpClient = factory.CreateClient("RudaClient");
    }

    public async Task<IReadOnlyList<Game>> GetQuizesData()
    {
        var response = await _httpClient.GetAsync(Url.GamesList);
        response.EnsureSuccessStatusCode();

        var jsonResponse = await response.Content.ReadAsStringAsync();

        return JsonConvert.DeserializeObject<List<Game>>(jsonResponse) ??
               throw new InvalidOperationException(
                   Program.GetResourceString("GetGamesListError")
               );
    }

    private void AddAuthHeader()
    {
        var token = _tokenService.GetCurrentToken();
        _httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", token.AccessToken);
    }

    public async Task<List<Team>> GetUserData()
    {
        try
        {
            AddAuthHeader();

            var response = await _httpClient.GetAsync(Url.UserInfo);
            response.EnsureSuccessStatusCode();

            var responseJson = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<UserInfo>(responseJson).Teams
                   ?? throw new InvalidOperationException(
                       string.Format(
                           Program.GetResourceString("GetUserDataError"),
                           response.StatusCode
                       )
                   );
        }
        catch (HttpRequestException ex)
        {
            throw new Exception(
                string.Format(
                    Program.GetResourceString("NetworkError"),
                    ex.Message
                )
            );
        }
        catch (JsonException ex)
        {
            throw new Exception(
                string.Format(
                    Program.GetResourceString("UserDataFormatError"),
                    ex.Message
                )
            );
        }
        catch (Exception ex)
        {
            throw new Exception(
                string.Format(
                    Program.GetResourceString("GetUserDataError"),
                    ex.Message
                )
            );
        }
    }

    public async Task<HttpResponseMessage> RegisterToQuiz(StringContent content)
    {
        try
        {
            AddAuthHeader();

            var response = await _httpClient.PostAsync(Url.Registration, content);

            return response;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<List<RegisteredGame>> GetActualGamesRegistrations()
    {
        try
        {
            var response = await _httpClient.GetAsync(Url.RegisteredGamesList);

            response.EnsureSuccessStatusCode();

            var responseJson = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<RegisteredGame>>(responseJson) ??
                   throw new InvalidOperationException(Program.GetResourceString("GetGamesListError"));
        }
        catch (HttpRequestException ex)
        {
            throw new Exception(
                string.Format(
                    Program.GetResourceString("NetworkError"),
                    ex.Message
                )
            );
        }
        catch (JsonException ex)
        {
            throw new Exception(
                string.Format(
                    Program.GetResourceString("UserDataFormatError"),
                    ex.Message
                )
            );
        }
        catch (Exception ex)
        {
            throw new Exception(
                string.Format(
                    Program.GetResourceString("GetUserDataError"),
                    ex.Message
                )
            );
        }
    }

    public async Task<HttpResponseMessage> CancelRegistration(uint id)
    {
        try
        {
            var uri = string.Format(Url.CancelRegistration, id);

            var response = await _httpClient.DeleteAsync(uri);

            return response;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<Image> LoadImageFromUrlAsync(string url)
    {
        try
        {
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            using var stream = await response.Content.ReadAsStreamAsync();

            return Image.FromStream(stream);
        }
        catch
        {
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QuizRegistration.Data;
using QuizRegistration.Resources;
using QuizRegistration.Services;

namespace QuizRegistration
{
    internal static class Program
    {
        internal static IServiceProvider ServiceProvider { get; private set; }

        private static ResourceManager ResourceManager { get; } = new(
            "QuizRegistration.Resources.Messages",
            typeof(Messages).Assembly);

        [STAThread]
        private static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            try
            {
                var accessService = ServiceProvider.GetRequiredService<AccessService>();
                await accessService.CheckAccess().ConfigureAwait(false);
                Application.Run(ServiceProvider.GetRequiredService<Form1>());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    GetResourceString("RunApplicationErrorTitle"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                Environment.Exit(1);
            }
        }

        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((config) =>
                {
                    config
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                        .AddEnvironmentVariables();
                })
                .ConfigureServices((services) =>
                {
                    services.AddHttpClient("RudaClient", client =>
                    {
                        client.BaseAddress = new Uri(Url.BaseUrl);
                        client.DefaultRequestHeaders.Accept.Add(
                            new MediaTypeWithQualityHeaderValue("application/json"));
                        client.Timeout = TimeSpan.FromSeconds(30);
                    });

                    services.AddHttpClient("YandexClient", client =>
                    {
                        client.BaseAddress = new Uri(Url.YandexDownload);
                        client.DefaultRequestHeaders.Accept.Add(
                            new MediaTypeWithQualityHeaderValue("application/json"));
                        client.Timeout = TimeSpan.FromSeconds(30);
                    });

                    services.AddSingleton<TokenService>();
                    services.AddSingleton<AccessService>();
                    services.AddSingleton<GameService>();
                    services.AddTransient<Form1>();
                    services.AddTransient<Form2>();
                });
        }

        public static string GetResourceString(string key)
        {
            return ResourceManager.GetString(key)
                   ?? throw new KeyNotFoundException($"Ресурс '{key}' не найден в {nameof(Messages)}.");
        }
    }
}

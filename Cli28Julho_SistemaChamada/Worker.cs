using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Vip.Printer;
using Vip.Printer.Enums;

namespace Cli28Julho_SistemaChamada
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly ServiceConfigurations _serviceConfigurations;
        private static readonly HttpClient client = new HttpClient();

        public Worker(ILogger<Worker> logger, IConfiguration configuration)
        {
            _logger = logger;
            _serviceConfigurations = new ServiceConfigurations();
            new ConfigureFromConfigurationOptions<ServiceConfigurations>(
                configuration.GetSection("ServiceConfigurations")).Configure(_serviceConfigurations);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            API_SenhaImpresa Empresa;

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    string Link;

                    Link = _serviceConfigurations.Api_SenhaPendenteImpressao.Replace("[EMPRESA]", _serviceConfigurations.Empresa.ToString());
                    var streamTask = client.GetStreamAsync(Link);

                    List<API_SenhaPendenteImpressao> repositories = await System.Text.Json.JsonSerializer.DeserializeAsync<List<API_SenhaPendenteImpressao>>(await streamTask);

                    if (repositories != null)
                    {
                        foreach (API_SenhaPendenteImpressao Item in repositories)
                        {
                            var printer = new Printer(_serviceConfigurations.Impresora, PrinterType.Epson);
                            printer.WriteLine("Meu texto aqui!");
                            printer.WriteLine(Item.sQ_CLINICA_SENHA.ToString());
                            printer.PartialPaperCut();
                            printer.PrintDocument();

                            Empresa = new API_SenhaImpresa();
                            Empresa.iSQ_CLINICA_SENHA = Item.sQ_CLINICA_SENHA;

                            StringContent content = new StringContent(JsonConvert.SerializeObject(Empresa), Encoding.UTF8, "application/json");

                            Link = _serviceConfigurations.Api_SenhaImpressa.Replace("[SENHA]", Item.sQ_CLINICA_SENHA.ToString());
                            var resposta = await client.PostAsync(Link, content);
                        }
                    }
                }
                catch (HttpRequestException ExHttp)
                {
                    _logger.LogError(ExHttp.Message);
                }
                catch (System.Exception ExSys)
                {
                    _logger.LogError(ExSys.Message);
                }

                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}

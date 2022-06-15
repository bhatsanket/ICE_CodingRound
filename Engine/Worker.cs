using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Engine;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Engine
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly ITickerSource tickerSource;

        public Worker(ILogger<Worker> logger, ITickerSource tickerSource)
        {
            _logger = logger;
            this.tickerSource = tickerSource;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation($"{MethodBase.GetCurrentMethod().DeclaringType} running at: {DateTimeOffset.Now}");
                tickerSource.UpdateTicker();
                await Task.Delay(1000, stoppingToken);
            }
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            return base.StopAsync(cancellationToken);
        }
    }
}
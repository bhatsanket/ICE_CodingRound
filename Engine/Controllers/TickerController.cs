using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Engine;

namespace Engine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TickerController : ControllerBase
    {
        private readonly ILogger<TickerController> _logger;
        private readonly Worker worker;
        private readonly ITickerSource tickerSource;

        public TickerController(ILogger<TickerController> logger, Worker worker, ITickerSource tickerSource)
        {
            _logger = logger;
            this.worker = worker;
            this.tickerSource = tickerSource;
        }

        [HttpGet]
        public Dictionary<string, double> Get()
        {
            return tickerSource.getTickers();
        }

        [HttpGet]
        [Route("StartEngine")]
        public async Task StartEngine(string source)
        {
            if (source == "Engine 1")
            {
                System.Threading.CancellationToken cancellationToken = new System.Threading.CancellationToken();
                await worker.StartAsync(cancellationToken);
            }
            if (source == "Engine 2")
            {
                System.Threading.CancellationToken cancellationToken = new System.Threading.CancellationToken();
                await worker.StartAsync(cancellationToken);
            }
            return;
        }

        [HttpGet]
        [Route("StopEngine")]
        public async Task StopEngine()
        {
            System.Threading.CancellationToken cancellationToken = new System.Threading.CancellationToken();
            await worker.StopAsync(cancellationToken);
            return;
        }

        [HttpGet]
        [Route("Subscribe")]
        public void Subscribe(string tickr)
        {
            tickerSource.addTicker(tickr);
            return;
        }
    }
}


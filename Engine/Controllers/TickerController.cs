using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Engine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TickerController : ControllerBase
    {
        private readonly Worker worker;
        private readonly ITickerSource tickerSource;

        public TickerController(Worker worker, ITickerSource tickerSource)
        {
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
            //if (source == "Engine 1")
            //{
                System.Threading.CancellationToken cancellationToken = new System.Threading.CancellationToken();
                await worker.StartAsync(cancellationToken);
            //}
            //if (source == "Engine 2")
            //{
            //    System.Threading.CancellationToken cancellationToken = new System.Threading.CancellationToken();
            //    await worker.StartAsync(cancellationToken);
            //}
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

        [HttpPost]
        [Route("Subscribe")]
        public void Subscribe([FromBody] string tickr)
        {
            tickerSource.addTicker(tickr);
            return;
        }
    }
}


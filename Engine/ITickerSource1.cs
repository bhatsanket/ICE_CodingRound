using System.Collections.Generic;

namespace Engine
{
    public interface ITickerSource
    {
        public void addTicker(string tikr);
        public Dictionary<string, double> getTickers();
        public void UpdateTicker();
    }
}
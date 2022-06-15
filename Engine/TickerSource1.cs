using System;
using System.Collections.Generic;

namespace Engine
{
    public class TickerSource1 : ITickerSource
    {
        private readonly Dictionary<string, double> Ticker = new();
        private readonly Random random = new();

        public TickerSource1()
        {
            var seedData = new string[] { "ice", "aapl", "fti" };
            foreach (var seed in seedData)
            {
                addTicker(seed);
            }
        }

        public void addTicker(string tikr)
        {
            if (!Ticker.ContainsKey(tikr))
            {
                Ticker.Add(tikr, CalcNextRandomValue());
            }
        }

        public void RemoveTicker(string tikr)
        {
            if (Ticker.ContainsKey(tikr))
            {
                Ticker.Remove(tikr);
            }
        }

        public Dictionary<string, double> getTickers()
        {
            return Ticker;
        }
        public void UpdateTicker()
        {
            foreach (var kv in Ticker)
            {
                Ticker[kv.Key] = CalcNextRandomValue();
            }
        }

        private double CalcNextRandomValue()
        {
            //this will give a value between 90 and 110 randomly.
            return random.NextDouble() * 20 + 90;
        }
    }
}
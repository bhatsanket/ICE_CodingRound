using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui
{
    public partial class frm_TickerForm : Form
    {
        readonly BindingList<TickerObj> tickerList = new();
        readonly BindingList<Engine> engines = new();
        static readonly HttpClient client = new();

        public frm_TickerForm()
        {
            InitializeComponent();

            LoadInitialList();

            client.BaseAddress = new Uri("https://localhost:45130/ticker/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void LoadInitialList()
        {

            engines.Add(new Engine { name = "Engine 1", running = false, State = "Stopped" });
            engines.Add(new Engine { name = "Engine 2", running = false, State = "Stopped" });
            engineGrid.DataSource = engines;
            engineGrid.MultiSelect = false;

            tickerGrid.DataSource = tickerList;
        }

        private async void Button1_ClickAsync(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in engineGrid.SelectedRows)
            {
                Engine selectedengine = (Engine)row.DataBoundItem;
                if (!selectedengine.running)
                {
                    selectedengine.running = true;
                    selectedengine.State = "Running";
                    await client.GetStringAsync("StartEngine");
                    await GetEngineData();//TODO pass engine name to start

                }
            }
            engineGrid.Refresh();
        }

        private async Task GetEngineData()
        {
            tickerList.Clear();

            foreach (var engine in engines.Where(e => e.running))
            {
                var response = await client.GetStringAsync("");
                var data = JsonConvert.DeserializeObject<Dictionary<string, double>>(response);
                foreach (var kv in data)
                {
                    if (!tickerList.Any(x => x.name == kv.Key))
                    {
                        tickerList.Add(new TickerObj { name = kv.Key, price = kv.Value });
                    }
                }
            }
        }

        private async void bttn_addticker_ClickAsync(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbx_inputticker.Text))
            {
                await client.PostAsJsonAsync("Subscribe", txtbx_inputticker.Text);
                await GetEngineData();
                txtbx_inputticker.Text = "";
            }
        }

        private async void button2_ClickAsync(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in engineGrid.SelectedRows)
            {
                Engine selectedengine = (Engine)row.DataBoundItem;
                if (selectedengine.running)
                {
                    selectedengine.running = false;
                    selectedengine.State = "Stopped";
                    await client.GetStringAsync("StopEngine");
                    tickerList.Clear();
                }
            }
            engineGrid.Refresh();
        }

        private async void bttn_refresh_Click(object sender, EventArgs e)
        {
            await GetEngineData();
        }

    }


    internal class Engine
    {
        internal bool running;

        public string name { get; internal set; }
        public string State { get; internal set; }
    }

    public class TickerObj
    {
        public string name { get; internal set; }
        public double price { get; internal set; }
    }
}

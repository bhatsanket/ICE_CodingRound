using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui
{
    public partial class frm_TickerForm : Form
    {
        BindingList<TickerObj> tickerList = new BindingList<TickerObj>();
        BindingList<Engine> engines = new BindingList<Engine>();
        private EngineManager engineManager;

        public frm_TickerForm()
        {
            InitializeComponent();

            loadInitialList();
             engineManager = new EngineManager();

        }

        private void loadInitialList()
        {

            engines.Add(new Engine { name = "Engine 1", running = false });
            engines.Add(new Engine { name = "Engine 2", running = false });
            engineGrid.DataSource = engines;
            engineGrid.MultiSelect = false;

            //tickerList.Add(new TickerObj { name = "aapl", price = 10.0 });
            //tickerList.Add(new TickerObj { name = "ice", price = 10.0 });
            tickerGrid.DataSource = tickerList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in engineGrid.SelectedRows)
            {
                Engine selectedengine = (Engine)row.DataBoundItem;
                if (!selectedengine.running)
                {
                    selectedengine.running = true;
                    selectedengine.State = "Running";
                }
            }
            engineGrid.Refresh();
        }

        private void bttn_addticker_Click(object sender, EventArgs e)
        {
            tickerList.Add(new TickerObj { name = txtbx_inputticker.Text, price = 0.0 });
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //foreach (var engine in engines)
            //{
            //    engineManager.getLatestUpdateFromEngine(engine);
            //}
        }
    }

    internal class EngineManager
    {
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

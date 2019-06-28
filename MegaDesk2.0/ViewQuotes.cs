using MegaDeskProject_1;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MegaDesk_Jones
{
    public partial class ViewQuotes : Form
    {
        private Form _mainMenu;
        public ViewQuotes(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;

            loadGrid();
        }

        private void loadGrid()
        {
            var quotesFile = @"quotes.json";

            using (StreamReader reader = new StreamReader(quotesFile))
            {
                string quotes = reader.ReadToEnd();
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);


                dataGridView1.DataSource = deskQuotes.Select(d => new
                {
                    Date = d.quoteDate,
                    Customer = d.customerName,
                    Depth = d.newDesk.depth,
                    Width = d.newDesk.width,
                    Drawers = d.newDesk.numDrawers,
                    SurfaceMaterial = d.newDesk.surfaceMaterial,
                    DeliveryType = d.rushDays,
                    QuoteAmount = d.deskPrice.ToString("c")
                }).ToList();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _mainMenu.Show();
            Close();
        }

    }
}

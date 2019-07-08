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
    public partial class searchQuote : Form
    {
        private Form _mainMenu;
        public searchQuote(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
            cmbxSurfaceMaterial.DataSource = Enum.GetValues(typeof(DesktopMaterial));
            cmbxSurfaceMaterial.SelectedIndex = -1;

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
        private void loadGrid(DesktopMaterial desktopMaterial)
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
                })
                    .Where(q => q.SurfaceMaterial == desktopMaterial)
                    .ToList();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _mainMenu.Show();
            Close();
        }

        private void CmbxSurfaceMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;

            if (combo.SelectedIndex < 0)
            {
                loadGrid();
            }
            else
            {
                loadGrid((DesktopMaterial)combo.SelectedValue);
            }
        }
    }
}

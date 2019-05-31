using MegaDeskProject_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Jones
{
    public partial class DisplayQuote : Form
    {
        private Form _mainMenu;
        // Desk currentDesk;
        DeskQuote _currentQuote;
        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();

            _currentQuote = deskQuote;

            //TODO: populate surface material and shipping dropdowns
            cmbSurface.DataSource = Enum.GetValues(typeof(DesktopMaterial));

        }
        
        
       //public DisplayQuote(Desk pvDesk, DeskQuote pvQuote)
       // {
       //     currentDesk = pvDesk;
       //     currentQuote = pvQuote;
       // }
             
        private void DisplayQuote_Load(object sender, EventArgs e)
        {
             
            this.txtCustomerName.Text = _currentQuote.customerName;
            this.txtWidth.Text = _currentQuote.newDesk.width.ToString();
            this.txtDepth.Text = _currentQuote.newDesk.depth.ToString();
            this.txtDrawers.Text = _currentQuote.newDesk.numDrawers.ToString();
            this.cmbDelivery.Text = _currentQuote.rushDays.ToString();
            this.cmbSurface.Text = _currentQuote.newDesk.surfaceMaterial.ToString();

        }

        private void BtnAddQuote_Click(object sender, EventArgs e)
        {

        }

        private void Done_Click(object sender, EventArgs e)
        {
            _mainMenu.Show();
            Close();
        }
    }
}

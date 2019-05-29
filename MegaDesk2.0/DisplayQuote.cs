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
        Desk currentDesk;
        DeskQuote currentQuote;
        public DisplayQuote()
        {
            InitializeComponent();
        }
        
        
       public DisplayQuote(Desk pvDesk, DeskQuote pvQuote)
        {
            currentDesk = pvDesk;
            currentQuote = pvQuote;
        }
             
        private void DisplayQuote_Load(object sender, EventArgs e)
        {
             
            this.txtCustomerName.Text = currentQuote.customerName;
            this.txtWidth.Text = currentDesk.width.ToString();
            this.txtDepth.Text = currentDesk.depth.ToString();
            this.txtDrawers.Text = currentDesk.numDrawers.ToString();
            this.txtDelivery.Text = currentQuote.rushDays.ToString();

        }

        private void BtnAddQuote_Click(object sender, EventArgs e)
        {

        }
    }
}

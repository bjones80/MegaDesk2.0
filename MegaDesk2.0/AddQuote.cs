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
    public partial class AddQuote : Form
    {
        private Form _mainMenu;
        public AddQuote(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           // var mainMenu = (MainMenu)Tag;
            _mainMenu.Show();
            Close();
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {


        }

        private void BtnAddQuote_Click(object sender, EventArgs e)
        {

            ViewQuotes frmViewQuotes = new ViewQuotes(this);
            frmViewQuotes.Show(this);
            Hide();
        }
    }
}

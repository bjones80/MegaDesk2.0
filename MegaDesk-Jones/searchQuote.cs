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
    public partial class searchQuote : Form
    {
        private Form _mainMenu;
        public searchQuote(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _mainMenu.Show();
            Close();
        }
    }
}

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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void NewQuote_Click(object sender, EventArgs e)
        {
            AddQuote frmAddQuote = new AddQuote(this); 
            frmAddQuote.Show(this);
            Hide();
        }
        private void ViewQuotes_Click(object sender, EventArgs e)
        {
            ViewQuotes frmViewQuote = new ViewQuotes(this);
            frmViewQuote.Show();
            Hide();
        }
        private void SearchQuotes_Click(object sender, EventArgs e)
        {
            searchQuote frmSearchQuote = new searchQuote(this);
            frmSearchQuote.Show();
            Hide();

        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

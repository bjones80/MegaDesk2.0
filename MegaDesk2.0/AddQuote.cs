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
    public partial class AddQuote : Form
    {
        private Form _mainMenu;
        public AddQuote(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
            cmbxSurfaceMaterial.DataSource = Enum.GetValues(typeof(DesktopMaterial));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // var mainMenu = (MainMenu)Tag;
            _mainMenu.Show();
            Close();
        }
               
        private void BtnAddQuote_Click(object sender, EventArgs e)
        {
            // assign desk values from current quote
            string custName = txtCustomerName.Text;
            int width = (int)numWidth.Value;
            int depth = (int)numDepth.Value;
            int drawer = (int)numDrawer.Value;
            decimal shippingType = Convert.ToDecimal(dropDelivery.Text);
            string materialType = cmbxSurfaceMaterial.Text;
            int materialId = 1;

            // Create materialId from materialType 
            switch (materialType)
            {
                case "oak":
                    materialId = 1;
                    break;
                case "pine":
                    materialId = 2;
                    break;
                case "rosewood":
                    materialId = 3;
                    break;
                case "veneer":
                    materialId = 4;
                    break;
                                }
            if (custName == "" || custName.All(char.IsDigit))
            {
                System.Windows.Forms.MessageBox.Show("Please enter a valid name");

            }
            else
            {
                try
                {
                    //create desk and quote 
                    Desk tempDesk = new Desk(width, depth, drawer, materialId);
                    DeskQuote tempQuote = new DeskQuote(tempDesk, shippingType, custName);

                    // show current quote 
                    DisplayQuote frmDisplayQuote = new DisplayQuote();
                    frmDisplayQuote.Show(this);
                    Hide();
                }
                catch
                {

                    System.Windows.Forms.MessageBox.Show("Please retry your quote");

                }
            }

        }

       
    }
    }

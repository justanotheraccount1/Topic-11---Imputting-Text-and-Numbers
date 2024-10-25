using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_11___Imputting_Text_and_Numbers
{
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
        }

        private void btnCaclulatePrice_Click(object sender, EventArgs e)
        {
            string item;
            int quantity;
            double price, totalPrice;
            item = txtItem.Text;
            quantity = Convert.ToInt32(txtQuantity.Text);
            price = Convert.ToDouble(txtPrice.Text);
            totalPrice = (quantity * price * 1.13);
            lblTotalPrice.Text = "Final Price: " + totalPrice.ToString("C");
        }
    }
}

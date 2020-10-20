using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_Invoice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        
        private void calculateTotal()
        {
            // get the subtotal amount from the subtotal text box

            decimal subTotal = Convert.ToDecimal(txt_subTotal.Text);

            // set the discountPercent variable based on the value of the subtotal variable

            decimal discountPercent = 0m; //the m indicate a decimal value
            if (subTotal >= 500)
            {
                discountPercent = .2m;
            }
            else if (subTotal >= 250 && subTotal < 500)
            {
                discountPercent = .15m;
            }
            else if (subTotal >= 100 && subTotal < 250)
            {
                discountPercent = .1m;
            }

            // calculate and assign the values for the discountAmount and invoiceTotal variable
            decimal discountAmount = subTotal * discountPercent;
            decimal invoiceTotal = subTotal - discountAmount;

            // format the values and display them in their text boxes 
            txtDiscountPercent.Text = discountPercent.ToString("p1"); // p1 = percent format with 1 decimal place
            txtDiscountAmount.Text = discountAmount.ToString("c"); // c = currenct format 
            txtTotal.Text = invoiceTotal.ToString("c");

            // move the focus to the subTotal text box 
            txt_subTotal.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void txt_subTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyData == Keys.Enter)
            {
                calculateTotal();
            }
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            calculateTotal();
        }

    }
}

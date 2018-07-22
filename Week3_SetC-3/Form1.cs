using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3_SetC_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_calculate_Click(object sender, EventArgs e)
        {
            double localCall = 0.15;
            int connfee = 33;
            int No_Of_Calls;
            double TotalCost;
            int billingperiod;

            No_Of_Calls = int.Parse(Txtbox_calls.Text);
            billingperiod = int.Parse(Txtbox_month.Text);

            TotalCost = (No_Of_Calls * localCall) + (billingperiod * connfee);
            Txtbox_tolCharge.Text = TotalCost.ToString("C");
            Txtbox_month.Focus();
            Txtbox_month.Text = String.Empty;
            Txtbox_calls.Text = String.Empty;
         

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.ActiveControl = Txtbox_month;
        }

        private void Txtbox_month_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Txtbox_month.Text, "[^1-12]"))
            {
                MessageBox.Show("Please enter only numbers/ between 1-12/ no decimal .");
                Txtbox_month.Text = Txtbox_month.Text.Remove(Txtbox_month.Text.Length - 1);
            }
        }

        private void Txtbox_calls_TextChanged(object sender, EventArgs e)
        {
           if (System.Text.RegularExpressions.Regex.IsMatch(Txtbox_calls.Text, "[^1-100000000]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Txtbox_calls.Text = Txtbox_calls.Text.Remove(Txtbox_calls.Text.Length - 1);
            }
        }
    }
}

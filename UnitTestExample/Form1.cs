using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTestExample
{

    public partial class Form1 : Form
    {
        private StockManagement sm = new StockManagement("IS304", "Stailness Steel", 524);
        public Form1()
        {
            InitializeComponent();

            sm.Receipt(500);
            sm.Output(365);

            textBox_current.Text = sm.StockBalance.ToString();
        }

        private void button_addReceipt_Click(object sender, EventArgs e)
        {
            string data = dateTimePicker_receipt.Value + " - " + textBox_receipt.Text;
            listBox_receipt.Items.Add(data);

            sm.Receipt(Convert.ToInt32(textBox_receipt.Text));

            textBox_current.Text = sm.StockBalance.ToString();
            
        }

        private void button_addOutput_Click(object sender, EventArgs e)
        {
            string data = dateTimePicker_output.Value + " - " + textBox_output.Text;
            listBox_output.Items.Add(data);

            sm.Output(Convert.ToInt32(textBox_output.Text));

            textBox_current.Text = sm.StockBalance.ToString();
        }
    }
}

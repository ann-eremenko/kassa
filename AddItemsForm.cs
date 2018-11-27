using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace kassa
{
    public partial class AddItemsForm : Form
    {
        private Stock stock
        {
            set;
            get;
        }
        public AddItemsForm(Stock stock)
        {
            InitializeComponent();

            this.stock = stock;
        }

        private void barcodeInput_TextChanged(object sender, EventArgs e)
        {
            if (barcodeInput.Text != string.Concat(barcodeInput.Text.Where(char.IsDigit)))
            {
                barcodeInput.Text = string.Concat(barcodeInput.Text.Where(char.IsDigit));
                barcodeInput.SelectionStart = barcodeInput.Text.Length + 1;
                SystemSounds.Beep.Play();
            }

            if (barcodeInput.TextLength > 13)
            {
                barcodeInput.Text = barcodeInput.Text.Substring(0,13);
                barcodeInput.SelectionStart = barcodeInput.Text.Length + 1;
                SystemSounds.Beep.Play();
            }
        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            if (nameInput.Text != string.Concat(nameInput.Text.Where(char.IsLetterOrDigit)))
            {
                nameInput.Text = string.Concat(nameInput.Text.Where(char.IsLetterOrDigit));
                nameInput.SelectionStart = nameInput.Text.Length + 1;
                SystemSounds.Beep.Play();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if((barcodeInput.Text != "") && (quantityInput.Value >= 0))
                stock.addItems(Int32.Parse(barcodeInput.Text), nameInput.Text, Convert.ToInt32(quantityInput.Value));
            else
                SystemSounds.Beep.Play();

            this.Close();
        }
    }
}
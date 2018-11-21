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
    public partial class DeletePositionForeverForm : Form
    {
        public DeletePositionForeverForm()
        {
            InitializeComponent();
        }

        private void barcodeInput_TextChanged(object sender, EventArgs e)
        {
            if (barcodeInput.Text != string.Concat(barcodeInput.Text.Where(char.IsDigit)))
            {
                barcodeInput.Text = string.Concat(barcodeInput.Text.Where(char.IsDigit));
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kassa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            (new AddItemsForm()).ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            (new DeleteItemsForm()).ShowDialog();
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            (new LogForm()).ShowDialog();
        }

        private void deleteForeverButton_Click(object sender, EventArgs e)
        {
            (new DeletePositionForeverForm()).ShowDialog();
        }
    }
}

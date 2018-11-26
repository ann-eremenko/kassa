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
        private Stock stock
        {
            get;
            set;
        }

        public MainForm()
        {
            InitializeComponent();

            stock = new Stock("./data.db", "./log.log");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            (new AddItemsForm(stock)).ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            (new DeleteItemsForm(stock)).ShowDialog();
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            (new LogForm(stock.getLoggerObj())).ShowDialog();
        }

        private void deleteForeverButton_Click(object sender, EventArgs e)
        {
            (new DeletePositionForeverForm(stock)).ShowDialog();
        }

        private void stockButton_Click(object sender, EventArgs e)
        {
            (new CurrentStockForm(stock)).ShowDialog();
        }
    }
}

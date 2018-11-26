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
    public partial class CurrentStockForm : Form
    {
        private Stock stock
        {
            get;
            set;
        }
        public CurrentStockForm(Stock stock)
        {
            InitializeComponent();

            this.stock = stock;
        }

        private void CurrentStockForm_Load(object sender, EventArgs e)
        {
            var lines = stock.getCurrentStock();

            foreach(var line in lines)
                logGrid.Rows.Add(line.Split(','));
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

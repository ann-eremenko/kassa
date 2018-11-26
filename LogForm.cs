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
    public partial class LogForm : Form
    {
        private Logger logger
        {
            get;
            set;
        }

        public LogForm(Logger _logger)
        {
            InitializeComponent();

            logger = _logger;

            var logRows = logger.getLog();

            for(int i = 0; i < logRows.Length; ++i)
            {
                var subs = logRows[i].Split(',');

                logGrid.Rows.Add(subs);

                logGrid.Rows[logGrid.Rows.Count - 1].HeaderCell.Value = (logGrid.Rows.Count - 1).ToString();

                if (subs[2][0] != '-')
                    logGrid.Rows[logGrid.Rows.Count - 1].Cells[2].Style.BackColor = Color.Green;
                else
                    logGrid.Rows[logGrid.Rows.Count - 1].Cells[2].Style.BackColor = Color.Red;
            }
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}

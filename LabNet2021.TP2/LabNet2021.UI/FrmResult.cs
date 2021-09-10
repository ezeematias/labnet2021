using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabNet2021.UI
{
    public partial class FrmResult : Form
    {
        string message;
        public FrmResult(string message)
        {
            InitializeComponent();
            this.message = message;
        }

        private void FrmResult_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {                
                this.Close();
            }
        }

        private void FrmResult_Load(object sender, EventArgs e)
        {
            lblResultado.Text = message;
        }
    }
}

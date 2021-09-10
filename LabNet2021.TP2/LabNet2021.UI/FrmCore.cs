using LabNet2021.Library;
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
    public partial class FrmCore : Form
    {
        public FrmCore()
        {
            InitializeComponent();
        }

        private void btnDividirPorCero_Click(object sender, EventArgs e)
        {
            try
            {
                Logic.DivideForZero(Logic.ValidationInteger(this.txbDividirPorCero.Text));
            }
            catch (Exception ex)
            {
                InvokeForm(ex.Message);
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                float result;
                result = Logic.DivisionOfTwoNumber(Logic.ValidationInteger(this.txbDividendo.Text), Logic.ValidationInteger(this.txbDivisor.Text));
                InvokeForm($"El resultado de la división es: {result}");
            }
            catch (Exception ex)
            {
                InvokeForm(ex.Message);
            }
        }

        private void InvokeForm(string message)
        {
            FrmResult frm = new FrmResult(message);
            frm.ShowDialog();
        }

        private void btnCandado_Click(object sender, EventArgs e)
        {
            try
            {
                Logic.FieldAccess();
            }
            catch (Exception ex)
            {
                InvokeForm(ex.Message);
            }
        }

        private void btnBomba_Click(object sender, EventArgs e)
        {
            try
            {
                Logic.SmokeBomb();
            }
            catch (Exception ex)
            {
                InvokeForm(ex.Message);                
            }
        }
    }
}

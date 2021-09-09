using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace FrmCore
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregarTransporte_Click(object sender, EventArgs e)
        {
            if (CoreSystem.DisponibilidadTransporte())
            {
                FrmAgregarTransporte agregarTransporte = new FrmAgregarTransporte();
                agregarTransporte.ShowDialog();
            }
            else
            {
                this.btnAgregarTransporte.Enabled = false;
                MessageBox.Show("No hay más trasportes", "SIN DISPONIBILIDAD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnOmnibus_Click(object sender, EventArgs e)
        {
            LimpiarInfo();
            this.rtbInfo.Text = CoreSystem.MostrarOmnibus();
        }

        private void btnTaxis_Click(object sender, EventArgs e)
        {
            LimpiarInfo();
            this.rtbInfo.Text = CoreSystem.MostrarTaxis();
        }

        /// <summary>
        /// Limpia el RichTextbox
        /// </summary>
        private void LimpiarInfo()
        {
            this.rtbInfo.Clear();
        }
    }
}

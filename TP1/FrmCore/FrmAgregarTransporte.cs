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
    public partial class FrmAgregarTransporte : Form
    {
        public FrmAgregarTransporte()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (CoreSystem.DisponibilidadTransporte())
            {

                if (this.txbNombre.Text != "" && this.nudCantidadPasajeros.Value > 0 )
                {
                    if (this.rbnTaxi.Checked)
                    {
                        CoreSystem.Taxis.Add(new Taxi(this.txbNombre.Text, (int)this.nudCantidadPasajeros.Value));
                    }
                    else
                    {
                        CoreSystem.Omnibus.Add(new Omnibus(this.txbNombre.Text, (int)this.nudCantidadPasajeros.Value));
                    }
                    if (MessageBox.Show("Se agregó correctamente\n\n¿Desea agregar otro trasporte?", "TRANSPORTES", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    {
                        this.Close();
                    }
                    else
                    {
                        LimpiarForm();
                    }
                }
                else
                {
                    MessageBox.Show("Se debe ingresar un nombre\ny/o una cantidad válida", "DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay más transportes de\neste tipo disponibles", "SIN TRANSPORTES", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        /// <summary>
        /// Re-establece los campos del formulario.
        /// </summary>
        private void LimpiarForm()
        {
            this.txbNombre.Clear();
            this.nudCantidadPasajeros.Value = 1; 
            if(CoreSystem.Omnibus.Count == 5)
            {
                this.rbnOmnibus.Enabled = false;
                this.rbnTaxi.Checked = true;
            }
            if(CoreSystem.Taxis.Count == 5)
            {
                this.rbnTaxi.Enabled = false;
                this.rbnOmnibus.Checked = true;
            }
        }
    }
}


namespace FrmCore
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnAgregarTransporte = new System.Windows.Forms.Button();
            this.btnOmnibus = new System.Windows.Forms.Button();
            this.btnTaxis = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAgregarTransporte
            // 
            this.btnAgregarTransporte.Location = new System.Drawing.Point(12, 12);
            this.btnAgregarTransporte.Name = "btnAgregarTransporte";
            this.btnAgregarTransporte.Size = new System.Drawing.Size(277, 57);
            this.btnAgregarTransporte.TabIndex = 0;
            this.btnAgregarTransporte.Text = "Agregar Transporte";
            this.btnAgregarTransporte.UseVisualStyleBackColor = true;
            this.btnAgregarTransporte.Click += new System.EventHandler(this.btnAgregarTransporte_Click);
            // 
            // btnOmnibus
            // 
            this.btnOmnibus.Location = new System.Drawing.Point(12, 75);
            this.btnOmnibus.Name = "btnOmnibus";
            this.btnOmnibus.Size = new System.Drawing.Size(137, 31);
            this.btnOmnibus.TabIndex = 2;
            this.btnOmnibus.Text = "Omnibus";
            this.btnOmnibus.UseVisualStyleBackColor = true;
            this.btnOmnibus.Click += new System.EventHandler(this.btnOmnibus_Click);
            // 
            // btnTaxis
            // 
            this.btnTaxis.Location = new System.Drawing.Point(153, 75);
            this.btnTaxis.Name = "btnTaxis";
            this.btnTaxis.Size = new System.Drawing.Size(136, 31);
            this.btnTaxis.TabIndex = 3;
            this.btnTaxis.Text = "Taxis";
            this.btnTaxis.UseVisualStyleBackColor = true;
            this.btnTaxis.Click += new System.EventHandler(this.btnTaxis_Click);
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(12, 112);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(277, 223);
            this.rtbInfo.TabIndex = 5;
            this.rtbInfo.Text = "";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(301, 347);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.btnTaxis);
            this.Controls.Add(this.btnOmnibus);
            this.Controls.Add(this.btnAgregarTransporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRANSPORTE BS AS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarTransporte;
        private System.Windows.Forms.Button btnOmnibus;
        private System.Windows.Forms.Button btnTaxis;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.RichTextBox rtbInfo;
    }
}


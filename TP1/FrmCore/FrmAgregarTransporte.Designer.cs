
namespace FrmCore
{
    partial class FrmAgregarTransporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarTransporte));
            this.lblNombreTransporte = new System.Windows.Forms.Label();
            this.nudCantidadPasajeros = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadPasajeros = new System.Windows.Forms.Label();
            this.rbnTaxi = new System.Windows.Forms.RadioButton();
            this.gbxTrasportes = new System.Windows.Forms.GroupBox();
            this.rbnOmnibus = new System.Windows.Forms.RadioButton();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPasajeros)).BeginInit();
            this.gbxTrasportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreTransporte
            // 
            this.lblNombreTransporte.AutoSize = true;
            this.lblNombreTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTransporte.ForeColor = System.Drawing.Color.White;
            this.lblNombreTransporte.Location = new System.Drawing.Point(9, 10);
            this.lblNombreTransporte.Name = "lblNombreTransporte";
            this.lblNombreTransporte.Size = new System.Drawing.Size(151, 15);
            this.lblNombreTransporte.TabIndex = 0;
            this.lblNombreTransporte.Text = "Nombre del transporte";
            // 
            // nudCantidadPasajeros
            // 
            this.nudCantidadPasajeros.Location = new System.Drawing.Point(12, 171);
            this.nudCantidadPasajeros.Name = "nudCantidadPasajeros";
            this.nudCantidadPasajeros.Size = new System.Drawing.Size(148, 20);
            this.nudCantidadPasajeros.TabIndex = 1;
            this.nudCantidadPasajeros.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidadPasajeros
            // 
            this.lblCantidadPasajeros.AutoSize = true;
            this.lblCantidadPasajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPasajeros.ForeColor = System.Drawing.Color.White;
            this.lblCantidadPasajeros.Location = new System.Drawing.Point(9, 153);
            this.lblCantidadPasajeros.Name = "lblCantidadPasajeros";
            this.lblCantidadPasajeros.Size = new System.Drawing.Size(151, 15);
            this.lblCantidadPasajeros.TabIndex = 2;
            this.lblCantidadPasajeros.Text = "Cantidad de pasajeros";
            // 
            // rbnTaxi
            // 
            this.rbnTaxi.AutoSize = true;
            this.rbnTaxi.Checked = true;
            this.rbnTaxi.Location = new System.Drawing.Point(22, 19);
            this.rbnTaxi.Name = "rbnTaxi";
            this.rbnTaxi.Size = new System.Drawing.Size(52, 19);
            this.rbnTaxi.TabIndex = 3;
            this.rbnTaxi.TabStop = true;
            this.rbnTaxi.Text = "Taxi";
            this.rbnTaxi.UseVisualStyleBackColor = true;
            // 
            // gbxTrasportes
            // 
            this.gbxTrasportes.Controls.Add(this.rbnOmnibus);
            this.gbxTrasportes.Controls.Add(this.rbnTaxi);
            this.gbxTrasportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTrasportes.ForeColor = System.Drawing.Color.White;
            this.gbxTrasportes.Location = new System.Drawing.Point(12, 65);
            this.gbxTrasportes.Name = "gbxTrasportes";
            this.gbxTrasportes.Size = new System.Drawing.Size(148, 73);
            this.gbxTrasportes.TabIndex = 4;
            this.gbxTrasportes.TabStop = false;
            this.gbxTrasportes.Text = "Tipo";
            // 
            // rbnOmnibus
            // 
            this.rbnOmnibus.AutoSize = true;
            this.rbnOmnibus.Location = new System.Drawing.Point(22, 42);
            this.rbnOmnibus.Name = "rbnOmnibus";
            this.rbnOmnibus.Size = new System.Drawing.Size(82, 19);
            this.rbnOmnibus.TabIndex = 4;
            this.rbnOmnibus.Text = "Omnibus";
            this.rbnOmnibus.UseVisualStyleBackColor = true;
            // 
            // txbNombre
            // 
            this.txbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(12, 29);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(148, 22);
            this.txbNombre.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 207);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 29);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmAgregarTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(171, 250);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.gbxTrasportes);
            this.Controls.Add(this.lblCantidadPasajeros);
            this.Controls.Add(this.nudCantidadPasajeros);
            this.Controls.Add(this.lblNombreTransporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAgregarTransporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Transporte";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPasajeros)).EndInit();
            this.gbxTrasportes.ResumeLayout(false);
            this.gbxTrasportes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreTransporte;
        private System.Windows.Forms.NumericUpDown nudCantidadPasajeros;
        private System.Windows.Forms.Label lblCantidadPasajeros;
        private System.Windows.Forms.RadioButton rbnTaxi;
        private System.Windows.Forms.GroupBox gbxTrasportes;
        private System.Windows.Forms.RadioButton rbnOmnibus;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Button btnAgregar;
    }
}
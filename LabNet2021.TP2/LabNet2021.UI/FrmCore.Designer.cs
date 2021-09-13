
namespace LabNet2021.UI
{
    partial class FrmCore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCore));
            this.btnDividirPorCero = new System.Windows.Forms.Button();
            this.gbxDividirPorCero = new System.Windows.Forms.GroupBox();
            this.txbDividirPorCero = new System.Windows.Forms.TextBox();
            this.gbxDividir = new System.Windows.Forms.GroupBox();
            this.txbDivisor = new System.Windows.Forms.TextBox();
            this.txbDividendo = new System.Windows.Forms.TextBox();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnCandado = new System.Windows.Forms.Button();
            this.btnBomba = new System.Windows.Forms.Button();
            this.gbxDividirPorCero.SuspendLayout();
            this.gbxDividir.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDividirPorCero
            // 
            this.btnDividirPorCero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividirPorCero.ForeColor = System.Drawing.Color.White;
            this.btnDividirPorCero.Location = new System.Drawing.Point(138, 19);
            this.btnDividirPorCero.Name = "btnDividirPorCero";
            this.btnDividirPorCero.Size = new System.Drawing.Size(75, 22);
            this.btnDividirPorCero.TabIndex = 0;
            this.btnDividirPorCero.Text = "Dividir";
            this.btnDividirPorCero.UseVisualStyleBackColor = true;
            this.btnDividirPorCero.Click += new System.EventHandler(this.btnDividirPorCero_Click);
            // 
            // gbxDividirPorCero
            // 
            this.gbxDividirPorCero.Controls.Add(this.txbDividirPorCero);
            this.gbxDividirPorCero.Controls.Add(this.btnDividirPorCero);
            this.gbxDividirPorCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDividirPorCero.ForeColor = System.Drawing.Color.White;
            this.gbxDividirPorCero.Location = new System.Drawing.Point(12, 12);
            this.gbxDividirPorCero.Name = "gbxDividirPorCero";
            this.gbxDividirPorCero.Size = new System.Drawing.Size(224, 56);
            this.gbxDividirPorCero.TabIndex = 1;
            this.gbxDividirPorCero.TabStop = false;
            this.gbxDividirPorCero.Text = "DIVIDIR POR CERO";
            // 
            // txbDividirPorCero
            // 
            this.txbDividirPorCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDividirPorCero.Location = new System.Drawing.Point(10, 19);
            this.txbDividirPorCero.Name = "txbDividirPorCero";
            this.txbDividirPorCero.Size = new System.Drawing.Size(112, 22);
            this.txbDividirPorCero.TabIndex = 1;
            // 
            // gbxDividir
            // 
            this.gbxDividir.Controls.Add(this.txbDivisor);
            this.gbxDividir.Controls.Add(this.txbDividendo);
            this.gbxDividir.Controls.Add(this.btnDividir);
            this.gbxDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDividir.ForeColor = System.Drawing.Color.White;
            this.gbxDividir.Location = new System.Drawing.Point(12, 83);
            this.gbxDividir.Name = "gbxDividir";
            this.gbxDividir.Size = new System.Drawing.Size(224, 84);
            this.gbxDividir.TabIndex = 2;
            this.gbxDividir.TabStop = false;
            this.gbxDividir.Text = "DIVIDIR";
            // 
            // txbDivisor
            // 
            this.txbDivisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDivisor.Location = new System.Drawing.Point(10, 51);
            this.txbDivisor.Name = "txbDivisor";
            this.txbDivisor.Size = new System.Drawing.Size(112, 22);
            this.txbDivisor.TabIndex = 3;
            // 
            // txbDividendo
            // 
            this.txbDividendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDividendo.Location = new System.Drawing.Point(10, 19);
            this.txbDividendo.Name = "txbDividendo";
            this.txbDividendo.Size = new System.Drawing.Size(112, 22);
            this.txbDividendo.TabIndex = 2;
            // 
            // btnDividir
            // 
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividir.ForeColor = System.Drawing.Color.White;
            this.btnDividir.Location = new System.Drawing.Point(138, 19);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 54);
            this.btnDividir.TabIndex = 0;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnCandado
            // 
            this.btnCandado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCandado.BackgroundImage")));
            this.btnCandado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCandado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCandado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCandado.Location = new System.Drawing.Point(12, 183);
            this.btnCandado.Name = "btnCandado";
            this.btnCandado.Size = new System.Drawing.Size(104, 77);
            this.btnCandado.TabIndex = 3;
            this.btnCandado.UseVisualStyleBackColor = true;
            this.btnCandado.Click += new System.EventHandler(this.btnCandado_Click);
            // 
            // btnBomba
            // 
            this.btnBomba.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBomba.BackgroundImage")));
            this.btnBomba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBomba.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBomba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBomba.Location = new System.Drawing.Point(132, 183);
            this.btnBomba.Name = "btnBomba";
            this.btnBomba.Size = new System.Drawing.Size(104, 77);
            this.btnBomba.TabIndex = 4;
            this.btnBomba.UseVisualStyleBackColor = true;
            this.btnBomba.Click += new System.EventHandler(this.btnBomba_Click);
            // 
            // FrmCore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(250, 276);
            this.Controls.Add(this.btnBomba);
            this.Controls.Add(this.btnCandado);
            this.Controls.Add(this.gbxDividir);
            this.Controls.Add(this.gbxDividirPorCero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetLab2021 - TP2";
            this.gbxDividirPorCero.ResumeLayout(false);
            this.gbxDividirPorCero.PerformLayout();
            this.gbxDividir.ResumeLayout(false);
            this.gbxDividir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDividirPorCero;
        private System.Windows.Forms.GroupBox gbxDividirPorCero;
        private System.Windows.Forms.TextBox txbDividirPorCero;
        private System.Windows.Forms.GroupBox gbxDividir;
        private System.Windows.Forms.TextBox txbDivisor;
        private System.Windows.Forms.TextBox txbDividendo;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnCandado;
        private System.Windows.Forms.Button btnBomba;
    }
}


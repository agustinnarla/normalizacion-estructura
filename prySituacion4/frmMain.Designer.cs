namespace prySituacion4
{
    partial class frmMain
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
            this.lblSeleccionLocalidad = new System.Windows.Forms.Label();
            this.lblSeleccionTipoCultivo = new System.Windows.Forms.Label();
            this.lblToneladas = new System.Windows.Forms.Label();
            this.lstLocalidad = new System.Windows.Forms.ComboBox();
            this.lstCultivos = new System.Windows.Forms.ListBox();
            this.txtToneladas = new System.Windows.Forms.TextBox();
            this.cmdActualizar = new System.Windows.Forms.Button();
            this.cmdVer = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeleccionLocalidad
            // 
            this.lblSeleccionLocalidad.AutoSize = true;
            this.lblSeleccionLocalidad.Location = new System.Drawing.Point(25, 36);
            this.lblSeleccionLocalidad.Name = "lblSeleccionLocalidad";
            this.lblSeleccionLocalidad.Size = new System.Drawing.Size(103, 13);
            this.lblSeleccionLocalidad.TabIndex = 0;
            this.lblSeleccionLocalidad.Text = "Seleccion Localidad";
            // 
            // lblSeleccionTipoCultivo
            // 
            this.lblSeleccionTipoCultivo.AutoSize = true;
            this.lblSeleccionTipoCultivo.Location = new System.Drawing.Point(25, 99);
            this.lblSeleccionTipoCultivo.Name = "lblSeleccionTipoCultivo";
            this.lblSeleccionTipoCultivo.Size = new System.Drawing.Size(128, 13);
            this.lblSeleccionTipoCultivo.TabIndex = 1;
            this.lblSeleccionTipoCultivo.Text = "Seleccion Tipo de Cultivo";
            // 
            // lblToneladas
            // 
            this.lblToneladas.AutoSize = true;
            this.lblToneladas.Location = new System.Drawing.Point(247, 36);
            this.lblToneladas.Name = "lblToneladas";
            this.lblToneladas.Size = new System.Drawing.Size(129, 13);
            this.lblToneladas.TabIndex = 2;
            this.lblToneladas.Text = "Produccion en Toneladas";
            // 
            // lstLocalidad
            // 
            this.lstLocalidad.FormattingEnabled = true;
            this.lstLocalidad.Location = new System.Drawing.Point(28, 52);
            this.lstLocalidad.Name = "lstLocalidad";
            this.lstLocalidad.Size = new System.Drawing.Size(172, 21);
            this.lstLocalidad.TabIndex = 3;
            // 
            // lstCultivos
            // 
            this.lstCultivos.FormattingEnabled = true;
            this.lstCultivos.Location = new System.Drawing.Point(26, 120);
            this.lstCultivos.Name = "lstCultivos";
            this.lstCultivos.Size = new System.Drawing.Size(174, 160);
            this.lstCultivos.TabIndex = 4;
            // 
            // txtToneladas
            // 
            this.txtToneladas.Location = new System.Drawing.Point(250, 53);
            this.txtToneladas.Name = "txtToneladas";
            this.txtToneladas.Size = new System.Drawing.Size(127, 20);
            this.txtToneladas.TabIndex = 5;
            // 
            // cmdActualizar
            // 
            this.cmdActualizar.Location = new System.Drawing.Point(250, 131);
            this.cmdActualizar.Name = "cmdActualizar";
            this.cmdActualizar.Size = new System.Drawing.Size(136, 37);
            this.cmdActualizar.TabIndex = 6;
            this.cmdActualizar.Text = "Actualizar";
            this.cmdActualizar.UseVisualStyleBackColor = true;
            this.cmdActualizar.Click += new System.EventHandler(this.cmdActualizar_Click);
            // 
            // cmdVer
            // 
            this.cmdVer.Location = new System.Drawing.Point(250, 174);
            this.cmdVer.Name = "cmdVer";
            this.cmdVer.Size = new System.Drawing.Size(136, 37);
            this.cmdVer.TabIndex = 7;
            this.cmdVer.Text = "Ver Produccion";
            this.cmdVer.UseVisualStyleBackColor = true;
            this.cmdVer.Click += new System.EventHandler(this.cmdVer_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(250, 223);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(136, 37);
            this.cmdSalir.TabIndex = 8;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 300);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdVer);
            this.Controls.Add(this.cmdActualizar);
            this.Controls.Add(this.txtToneladas);
            this.Controls.Add(this.lstCultivos);
            this.Controls.Add(this.lstLocalidad);
            this.Controls.Add(this.lblToneladas);
            this.Controls.Add(this.lblSeleccionTipoCultivo);
            this.Controls.Add(this.lblSeleccionLocalidad);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccionLocalidad;
        private System.Windows.Forms.Label lblSeleccionTipoCultivo;
        private System.Windows.Forms.Label lblToneladas;
        private System.Windows.Forms.ComboBox lstLocalidad;
        private System.Windows.Forms.ListBox lstCultivos;
        private System.Windows.Forms.TextBox txtToneladas;
        private System.Windows.Forms.Button cmdActualizar;
        private System.Windows.Forms.Button cmdVer;
        private System.Windows.Forms.Button cmdSalir;
    }
}


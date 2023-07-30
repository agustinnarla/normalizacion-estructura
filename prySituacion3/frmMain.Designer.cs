namespace prySituacion3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblIncendios = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.tvArbolito = new System.Windows.Forms.TreeView();
            this.lstCantidad = new System.Windows.Forms.ListView();
            this.stDatos = new System.Windows.Forms.StatusStrip();
            this.lblTitulo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.Fotitos = new System.Windows.Forms.ImageList(this.components);
            this.Incendios = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIncendios
            // 
            this.lblIncendios.AutoSize = true;
            this.lblIncendios.Location = new System.Drawing.Point(21, 41);
            this.lblIncendios.Name = "lblIncendios";
            this.lblIncendios.Size = new System.Drawing.Size(53, 13);
            this.lblIncendios.TabIndex = 0;
            this.lblIncendios.Text = "Incendios";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(354, 41);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad";
            // 
            // tvArbolito
            // 
            this.tvArbolito.Location = new System.Drawing.Point(24, 57);
            this.tvArbolito.Name = "tvArbolito";
            this.tvArbolito.Size = new System.Drawing.Size(263, 287);
            this.tvArbolito.TabIndex = 2;
            this.tvArbolito.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvArbolito_AfterSelect);
            this.tvArbolito.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvArbolito_NodeMouseClick);
            this.tvArbolito.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tvArbolito_MouseClick);
            // 
            // lstCantidad
            // 
            this.lstCantidad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Incendios,
            this.Cantidad});
            this.lstCantidad.HideSelection = false;
            this.lstCantidad.Location = new System.Drawing.Point(356, 61);
            this.lstCantidad.Name = "lstCantidad";
            this.lstCantidad.Size = new System.Drawing.Size(289, 282);
            this.lstCantidad.TabIndex = 3;
            this.lstCantidad.UseCompatibleStateImageBehavior = false;
            this.lstCantidad.View = System.Windows.Forms.View.SmallIcon;
            // 
            // stDatos
            // 
            this.stDatos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTitulo,
            this.lblTotal});
            this.stDatos.Location = new System.Drawing.Point(0, 381);
            this.stDatos.Name = "stDatos";
            this.stDatos.Size = new System.Drawing.Size(701, 22);
            this.stDatos.TabIndex = 4;
            this.stDatos.Text = "statusStrip1";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(37, 17);
            this.lblTitulo.Text = "Titulo";
            this.lblTitulo.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(32, 17);
            this.lblTotal.Text = "Total";
            // 
            // Fotitos
            // 
            this.Fotitos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Fotitos.ImageStream")));
            this.Fotitos.TransparentColor = System.Drawing.Color.Transparent;
            this.Fotitos.Images.SetKeyName(0, "carpeta1.png");
            this.Fotitos.Images.SetKeyName(1, "carpeta2.png");
            this.Fotitos.Images.SetKeyName(2, "carpeta3.png");
            // 
            // Incendios
            // 
            this.Incendios.Text = "Tipo de incendios ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 403);
            this.Controls.Add(this.stDatos);
            this.Controls.Add(this.lstCantidad);
            this.Controls.Add(this.tvArbolito);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblIncendios);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.stDatos.ResumeLayout(false);
            this.stDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIncendios;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TreeView tvArbolito;
        private System.Windows.Forms.ListView lstCantidad;
        private System.Windows.Forms.StatusStrip stDatos;
        private System.Windows.Forms.ToolStripStatusLabel lblTitulo;
        private System.Windows.Forms.ToolStripStatusLabel lblTotal;
        private System.Windows.Forms.ImageList Fotitos;
        private System.Windows.Forms.ColumnHeader Incendios;
        private System.Windows.Forms.ColumnHeader Cantidad;
    }
}


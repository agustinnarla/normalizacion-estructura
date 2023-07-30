namespace prySituacion4
{
    partial class frmGrafico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabDatos = new System.Windows.Forms.TabControl();
            this.tabLocalidad = new System.Windows.Forms.TabPage();
            this.tabTotal = new System.Windows.Forms.TabPage();
            this.lstLocalidad = new System.Windows.Forms.ComboBox();
            this.cmdGraficar = new System.Windows.Forms.Button();
            this.chartDatos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmdGraficar1 = new System.Windows.Forms.Button();
            this.tabDatos.SuspendLayout();
            this.tabLocalidad.SuspendLayout();
            this.tabTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDatos
            // 
            this.tabDatos.Controls.Add(this.tabLocalidad);
            this.tabDatos.Controls.Add(this.tabTotal);
            this.tabDatos.Location = new System.Drawing.Point(0, 0);
            this.tabDatos.Name = "tabDatos";
            this.tabDatos.SelectedIndex = 0;
            this.tabDatos.Size = new System.Drawing.Size(813, 438);
            this.tabDatos.TabIndex = 0;
            // 
            // tabLocalidad
            // 
            this.tabLocalidad.Controls.Add(this.chartDatos);
            this.tabLocalidad.Controls.Add(this.cmdGraficar);
            this.tabLocalidad.Controls.Add(this.lstLocalidad);
            this.tabLocalidad.Location = new System.Drawing.Point(4, 22);
            this.tabLocalidad.Name = "tabLocalidad";
            this.tabLocalidad.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocalidad.Size = new System.Drawing.Size(805, 412);
            this.tabLocalidad.TabIndex = 0;
            this.tabLocalidad.Text = "Produ por localidad";
            this.tabLocalidad.UseVisualStyleBackColor = true;
            this.tabLocalidad.Click += new System.EventHandler(this.tabLocalidad_Click);
            // 
            // tabTotal
            // 
            this.tabTotal.Controls.Add(this.cmdGraficar1);
            this.tabTotal.Controls.Add(this.chart1);
            this.tabTotal.Location = new System.Drawing.Point(4, 22);
            this.tabTotal.Name = "tabTotal";
            this.tabTotal.Padding = new System.Windows.Forms.Padding(3);
            this.tabTotal.Size = new System.Drawing.Size(805, 412);
            this.tabTotal.TabIndex = 1;
            this.tabTotal.Text = "Produ Total";
            this.tabTotal.UseVisualStyleBackColor = true;
            // 
            // lstLocalidad
            // 
            this.lstLocalidad.FormattingEnabled = true;
            this.lstLocalidad.Location = new System.Drawing.Point(102, 67);
            this.lstLocalidad.Name = "lstLocalidad";
            this.lstLocalidad.Size = new System.Drawing.Size(301, 21);
            this.lstLocalidad.TabIndex = 0;
            // 
            // cmdGraficar
            // 
            this.cmdGraficar.Location = new System.Drawing.Point(563, 40);
            this.cmdGraficar.Name = "cmdGraficar";
            this.cmdGraficar.Size = new System.Drawing.Size(170, 48);
            this.cmdGraficar.TabIndex = 1;
            this.cmdGraficar.Text = "Graficar";
            this.cmdGraficar.UseVisualStyleBackColor = true;
            this.cmdGraficar.Click += new System.EventHandler(this.cmdGraficar_Click);
            // 
            // chartDatos
            // 
            chartArea4.Name = "ChartArea1";
            this.chartDatos.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDatos.Legends.Add(legend4);
            this.chartDatos.Location = new System.Drawing.Point(73, 142);
            this.chartDatos.Name = "chartDatos";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartDatos.Series.Add(series4);
            this.chartDatos.Size = new System.Drawing.Size(383, 191);
            this.chartDatos.TabIndex = 2;
            this.chartDatos.Text = "chart1";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(141, 111);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(468, 225);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // cmdGraficar1
            // 
            this.cmdGraficar1.Location = new System.Drawing.Point(586, 35);
            this.cmdGraficar1.Name = "cmdGraficar1";
            this.cmdGraficar1.Size = new System.Drawing.Size(135, 39);
            this.cmdGraficar1.TabIndex = 4;
            this.cmdGraficar1.Text = "Graficar";
            this.cmdGraficar1.UseVisualStyleBackColor = true;
            this.cmdGraficar1.Click += new System.EventHandler(this.cmdGraficar1_Click);
            // 
            // frmGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabDatos);
            this.Name = "frmGrafico";
            this.Text = "frmGrafico";
            this.Load += new System.EventHandler(this.frmGrafico_Load);
            this.tabDatos.ResumeLayout(false);
            this.tabLocalidad.ResumeLayout(false);
            this.tabTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDatos;
        private System.Windows.Forms.TabPage tabLocalidad;
        private System.Windows.Forms.TabPage tabTotal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDatos;
        private System.Windows.Forms.Button cmdGraficar;
        private System.Windows.Forms.ComboBox lstLocalidad;
        private System.Windows.Forms.Button cmdGraficar1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
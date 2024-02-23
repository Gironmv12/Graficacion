namespace graficas
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gbCoord = new System.Windows.Forms.GroupBox();
            this.lblPendiente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.tbY2 = new System.Windows.Forms.TextBox();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.tbY1 = new System.Windows.Forms.TextBox();
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.lblCoordB = new System.Windows.Forms.Label();
            this.lblCoordA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBCoordAyB = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbCoord.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCoord
            // 
            this.gbCoord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCoord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(64)))));
            this.gbCoord.Controls.Add(this.lblPendiente);
            this.gbCoord.Controls.Add(this.btnDibujar);
            this.gbCoord.Controls.Add(this.label2);
            this.gbCoord.Controls.Add(this.btnLimpiar);
            this.gbCoord.Controls.Add(this.tbY2);
            this.gbCoord.Controls.Add(this.tbX2);
            this.gbCoord.Controls.Add(this.tbY1);
            this.gbCoord.Controls.Add(this.tbX1);
            this.gbCoord.Controls.Add(this.lblCoordB);
            this.gbCoord.Controls.Add(this.lblCoordA);
            this.gbCoord.ForeColor = System.Drawing.Color.White;
            this.gbCoord.Location = new System.Drawing.Point(22, 22);
            this.gbCoord.Name = "gbCoord";
            this.gbCoord.Size = new System.Drawing.Size(229, 242);
            this.gbCoord.TabIndex = 0;
            this.gbCoord.TabStop = false;
            this.gbCoord.Text = "Coordenadas";
            // 
            // lblPendiente
            // 
            this.lblPendiente.AutoSize = true;
            this.lblPendiente.Location = new System.Drawing.Point(106, 194);
            this.lblPendiente.Name = "lblPendiente";
            this.lblPendiente.Size = new System.Drawing.Size(0, 16);
            this.lblPendiente.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pendiente(M):";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Red;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(31, 147);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(166, 29);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnDibujar
            // 
            this.btnDibujar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(203)))), ((int)(((byte)(166)))));
            this.btnDibujar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(203)))), ((int)(((byte)(166)))));
            this.btnDibujar.FlatAppearance.BorderSize = 0;
            this.btnDibujar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDibujar.ForeColor = System.Drawing.Color.White;
            this.btnDibujar.Location = new System.Drawing.Point(31, 103);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(166, 29);
            this.btnDibujar.TabIndex = 1;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = false;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // tbY2
            // 
            this.tbY2.Location = new System.Drawing.Point(122, 67);
            this.tbY2.Name = "tbY2";
            this.tbY2.Size = new System.Drawing.Size(75, 22);
            this.tbY2.TabIndex = 5;
            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(31, 67);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(75, 22);
            this.tbX2.TabIndex = 4;
            // 
            // tbY1
            // 
            this.tbY1.Location = new System.Drawing.Point(122, 36);
            this.tbY1.Name = "tbY1";
            this.tbY1.Size = new System.Drawing.Size(75, 22);
            this.tbY1.TabIndex = 3;
            // 
            // tbX1
            // 
            this.tbX1.Location = new System.Drawing.Point(31, 36);
            this.tbX1.Name = "tbX1";
            this.tbX1.Size = new System.Drawing.Size(75, 22);
            this.tbX1.TabIndex = 1;
            // 
            // lblCoordB
            // 
            this.lblCoordB.AutoSize = true;
            this.lblCoordB.Location = new System.Drawing.Point(6, 67);
            this.lblCoordB.Name = "lblCoordB";
            this.lblCoordB.Size = new System.Drawing.Size(19, 16);
            this.lblCoordB.TabIndex = 2;
            this.lblCoordB.Text = "B:";
            // 
            // lblCoordA
            // 
            this.lblCoordA.AutoSize = true;
            this.lblCoordA.Location = new System.Drawing.Point(6, 42);
            this.lblCoordA.Name = "lblCoordA";
            this.lblCoordA.Size = new System.Drawing.Size(19, 16);
            this.lblCoordA.TabIndex = 1;
            this.lblCoordA.Text = "A:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coordendas A y B";
            // 
            // listBCoordAyB
            // 
            this.listBCoordAyB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(64)))));
            this.listBCoordAyB.ForeColor = System.Drawing.Color.White;
            this.listBCoordAyB.FormattingEnabled = true;
            this.listBCoordAyB.ItemHeight = 16;
            this.listBCoordAyB.Location = new System.Drawing.Point(22, 310);
            this.listBCoordAyB.Name = "listBCoordAyB";
            this.listBCoordAyB.Size = new System.Drawing.Size(229, 644);
            this.listBCoordAyB.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbCoord);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBCoordAyB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 1033);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Grafica);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(275, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1627, 1033);
            this.panel2.TabIndex = 5;
            // 
            // Grafica
            // 
            this.Grafica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grafica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(64)))));
            this.Grafica.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowColor = System.Drawing.Color.White;
            this.Grafica.ChartAreas.Add(chartArea3);
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.Name = "Legend1";
            this.Grafica.Legends.Add(legend3);
            this.Grafica.Location = new System.Drawing.Point(210, 51);
            this.Grafica.Name = "Grafica";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.LegendText = "Linea DDA";
            series3.Name = "Series1";
            series3.ShadowColor = System.Drawing.Color.White;
            this.Grafica.Series.Add(series3);
            this.Grafica.Size = new System.Drawing.Size(825, 601);
            this.Grafica.TabIndex = 4;
            this.Grafica.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Garfica DDA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCoord.ResumeLayout(false);
            this.gbCoord.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grafica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCoord;
        private System.Windows.Forms.Label lblCoordB;
        private System.Windows.Forms.Label lblCoordA;
        private System.Windows.Forms.TextBox tbX1;
        private System.Windows.Forms.TextBox tbY1;
        private System.Windows.Forms.TextBox tbY2;
        private System.Windows.Forms.TextBox tbX2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBCoordAyB;
        private System.Windows.Forms.Label lblPendiente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafica;
    }
}


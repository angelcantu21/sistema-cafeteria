namespace ProyectoCafeteriaUTE.CorteForm
{
    partial class Corte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Corte));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.corteDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarCorteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gananciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.observarGananciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeDineroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaVentanas = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.corteDeCajaToolStripMenuItem,
            this.gananciasToolStripMenuItem,
            this.reportesDeDineroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // corteDeCajaToolStripMenuItem
            // 
            this.corteDeCajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarCorteToolStripMenuItem});
            this.corteDeCajaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corteDeCajaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("corteDeCajaToolStripMenuItem.Image")));
            this.corteDeCajaToolStripMenuItem.Name = "corteDeCajaToolStripMenuItem";
            this.corteDeCajaToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.corteDeCajaToolStripMenuItem.Text = "Corte de caja";
            // 
            // realizarCorteToolStripMenuItem
            // 
            this.realizarCorteToolStripMenuItem.Name = "realizarCorteToolStripMenuItem";
            this.realizarCorteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.realizarCorteToolStripMenuItem.Text = "Realizar corte";
            this.realizarCorteToolStripMenuItem.Click += new System.EventHandler(this.realizarCorteToolStripMenuItem_Click);
            // 
            // gananciasToolStripMenuItem
            // 
            this.gananciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.observarGananciasToolStripMenuItem});
            this.gananciasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gananciasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gananciasToolStripMenuItem.Image")));
            this.gananciasToolStripMenuItem.Name = "gananciasToolStripMenuItem";
            this.gananciasToolStripMenuItem.Size = new System.Drawing.Size(98, 21);
            this.gananciasToolStripMenuItem.Text = "Ganancias";
            // 
            // observarGananciasToolStripMenuItem
            // 
            this.observarGananciasToolStripMenuItem.Name = "observarGananciasToolStripMenuItem";
            this.observarGananciasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.observarGananciasToolStripMenuItem.Text = "Observar ganancias";
            this.observarGananciasToolStripMenuItem.Click += new System.EventHandler(this.observarGananciasToolStripMenuItem_Click);
            // 
            // reportesDeDineroToolStripMenuItem
            // 
            this.reportesDeDineroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem});
            this.reportesDeDineroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesDeDineroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesDeDineroToolStripMenuItem.Image")));
            this.reportesDeDineroToolStripMenuItem.Name = "reportesDeDineroToolStripMenuItem";
            this.reportesDeDineroToolStripMenuItem.Size = new System.Drawing.Size(153, 21);
            this.reportesDeDineroToolStripMenuItem.Text = "Reportes de dinero";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // vistaVentanas
            // 
            this.vistaVentanas.Location = new System.Drawing.Point(12, 28);
            this.vistaVentanas.Name = "vistaVentanas";
            this.vistaVentanas.Size = new System.Drawing.Size(934, 539);
            this.vistaVentanas.TabIndex = 2;
            // 
            // Corte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 567);
            this.Controls.Add(this.vistaVentanas);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Corte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C O R T E   D E   C  A J A - C A F E T A - U T E";
            this.Load += new System.EventHandler(this.Corte_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem corteDeCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gananciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeDineroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarCorteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem observarGananciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.Panel vistaVentanas;
    }
}
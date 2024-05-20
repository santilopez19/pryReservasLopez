namespace pryReservasLopez
{
    partial class frmTeatros
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quenakenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tobasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quenakenToolStripMenuItem,
            this.onasToolStripMenuItem,
            this.tobasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(400, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quenakenToolStripMenuItem
            // 
            this.quenakenToolStripMenuItem.Name = "quenakenToolStripMenuItem";
            this.quenakenToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.quenakenToolStripMenuItem.Text = "Quenaken";
            this.quenakenToolStripMenuItem.Click += new System.EventHandler(this.quenakenToolStripMenuItem_Click);
            // 
            // onasToolStripMenuItem
            // 
            this.onasToolStripMenuItem.Name = "onasToolStripMenuItem";
            this.onasToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.onasToolStripMenuItem.Text = "Onas";
            this.onasToolStripMenuItem.Click += new System.EventHandler(this.onasToolStripMenuItem_Click);
            // 
            // tobasToolStripMenuItem
            // 
            this.tobasToolStripMenuItem.Name = "tobasToolStripMenuItem";
            this.tobasToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.tobasToolStripMenuItem.Text = "Tobas";
            this.tobasToolStripMenuItem.Click += new System.EventHandler(this.tobasToolStripMenuItem_Click);
            // 
            // frmTeatros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 251);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmTeatros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teatros";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quenakenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tobasToolStripMenuItem;
    }
}


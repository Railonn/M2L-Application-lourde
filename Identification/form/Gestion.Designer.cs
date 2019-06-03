namespace Identification.form
{
    partial class Gestion
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.frmGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterLesFraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generéLeDocumentCERFAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validerLesFraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmGestion,
            this.validerLesFraisToolStripMenuItem,
            this.déconnecterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(398, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmGestion
            // 
            this.frmGestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterLesFraisToolStripMenuItem,
            this.generéLeDocumentCERFAToolStripMenuItem});
            this.frmGestion.Name = "frmGestion";
            this.frmGestion.Size = new System.Drawing.Size(59, 20);
            this.frmGestion.Text = "Gestion";
            // 
            // consulterLesFraisToolStripMenuItem
            // 
            this.consulterLesFraisToolStripMenuItem.Name = "consulterLesFraisToolStripMenuItem";
            this.consulterLesFraisToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.consulterLesFraisToolStripMenuItem.Text = "Consulter les frais";
            this.consulterLesFraisToolStripMenuItem.Click += new System.EventHandler(this.ConsulterLesFraisToolStripMenuItem_Click_1);
            // 
            // generéLeDocumentCERFAToolStripMenuItem
            // 
            this.generéLeDocumentCERFAToolStripMenuItem.Name = "generéLeDocumentCERFAToolStripMenuItem";
            this.generéLeDocumentCERFAToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.generéLeDocumentCERFAToolStripMenuItem.Text = "Generé le document CERFA";
            this.generéLeDocumentCERFAToolStripMenuItem.Click += new System.EventHandler(this.GeneréLeDocumentCERFAToolStripMenuItem_Click);
            // 
            // validerLesFraisToolStripMenuItem
            // 
            this.validerLesFraisToolStripMenuItem.Name = "validerLesFraisToolStripMenuItem";
            this.validerLesFraisToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.validerLesFraisToolStripMenuItem.Text = "Valider les frais";
            this.validerLesFraisToolStripMenuItem.Click += new System.EventHandler(this.ValiderLesFraisToolStripMenuItem_Click);
            // 
            // déconnecterToolStripMenuItem
            // 
            this.déconnecterToolStripMenuItem.Name = "déconnecterToolStripMenuItem";
            this.déconnecterToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.déconnecterToolStripMenuItem.Text = "Déconnecter";
            this.déconnecterToolStripMenuItem.Click += new System.EventHandler(this.DéconnecterToolStripMenuItem_Click);
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 218);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gestion";
            this.Text = "Gestion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem frmGestion;
        private System.Windows.Forms.ToolStripMenuItem validerLesFraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterLesFraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generéLeDocumentCERFAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnecterToolStripMenuItem;
    }
}
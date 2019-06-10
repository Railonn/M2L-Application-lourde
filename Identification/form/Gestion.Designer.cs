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
            this.Accueil = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validerLesFraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterLesFraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generéLeDocumentCERFAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirLesModificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Accueil.SuspendLayout();
            this.SuspendLayout();
            // 
            // Accueil
            // 
            this.Accueil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.voirLesModificationsToolStripMenuItem,
            this.déconnecterToolStripMenuItem});
            this.Accueil.Location = new System.Drawing.Point(0, 0);
            this.Accueil.Name = "Accueil";
            this.Accueil.Size = new System.Drawing.Size(337, 24);
            this.Accueil.TabIndex = 0;
            this.Accueil.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.validerLesFraisToolStripMenuItem,
            this.consulterLesFraisToolStripMenuItem,
            this.generéLeDocumentCERFAToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.gestionToolStripMenuItem.Text = "Gestion des frais";
            // 
            // validerLesFraisToolStripMenuItem
            // 
            this.validerLesFraisToolStripMenuItem.Name = "validerLesFraisToolStripMenuItem";
            this.validerLesFraisToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.validerLesFraisToolStripMenuItem.Text = "Valider les frais";
            this.validerLesFraisToolStripMenuItem.Click += new System.EventHandler(this.ValiderLesFraisToolStripMenuItem1_Click);
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
            // voirLesModificationsToolStripMenuItem
            // 
            this.voirLesModificationsToolStripMenuItem.Name = "voirLesModificationsToolStripMenuItem";
            this.voirLesModificationsToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.voirLesModificationsToolStripMenuItem.Text = "Afficher l\'historique";
            this.voirLesModificationsToolStripMenuItem.Click += new System.EventHandler(this.VoirLesModificationsToolStripMenuItem_Click);
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
            this.ClientSize = new System.Drawing.Size(337, 181);
            this.Controls.Add(this.Accueil);
            this.MainMenuStrip = this.Accueil;
            this.Name = "Gestion";
            this.Text = "M2L - Accueil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gestion_FormClosing);
            this.Accueil.ResumeLayout(false);
            this.Accueil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Accueil;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterLesFraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generéLeDocumentCERFAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirLesModificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validerLesFraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnecterToolStripMenuItem;
    }
}
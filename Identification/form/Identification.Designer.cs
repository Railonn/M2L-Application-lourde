namespace Identification
{
    partial class FrmIdentification
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.btnValide = new System.Windows.Forms.Button();
            this.FermerApplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(114, 52);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.Text = "17 05 40 010 121";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(30, 55);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(62, 13);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "N° licence :";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(30, 100);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(77, 13);
            this.lblMdp.TabIndex = 2;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(114, 97);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '*';
            this.txtMdp.Size = new System.Drawing.Size(100, 20);
            this.txtMdp.TabIndex = 3;
            this.txtMdp.Text = "1234";
            // 
            // btnValide
            // 
            this.btnValide.Location = new System.Drawing.Point(80, 142);
            this.btnValide.Name = "btnValide";
            this.btnValide.Size = new System.Drawing.Size(75, 23);
            this.btnValide.TabIndex = 4;
            this.btnValide.Text = "Valider";
            this.btnValide.UseVisualStyleBackColor = true;
            this.btnValide.Click += new System.EventHandler(this.BtnValide_Click);
            // 
            // FermerApplication
            // 
            this.FermerApplication.Location = new System.Drawing.Point(161, 142);
            this.FermerApplication.Name = "FermerApplication";
            this.FermerApplication.Size = new System.Drawing.Size(75, 23);
            this.FermerApplication.TabIndex = 5;
            this.FermerApplication.Text = "Fermer";
            this.FermerApplication.UseVisualStyleBackColor = true;
            this.FermerApplication.Click += new System.EventHandler(this.FermerApplication_Click);
            // 
            // FrmIdentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 210);
            this.Controls.Add(this.FermerApplication);
            this.Controls.Add(this.btnValide);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Name = "FrmIdentification";
            this.Text = "Identification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Button btnValide;
        private System.Windows.Forms.Button FermerApplication;
    }
}


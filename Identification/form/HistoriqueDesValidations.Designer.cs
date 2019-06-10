namespace Identification.form
{
    partial class HistoriqueDesValidations
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
            this.lvActionsTresoriers = new System.Windows.Forms.ListView();
            this.mailDemandeur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateFrais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateModif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modifications = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvActionsTresoriers
            // 
            this.lvActionsTresoriers.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvActionsTresoriers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mailDemandeur,
            this.dateFrais,
            this.dateModif,
            this.modifications});
            this.lvActionsTresoriers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvActionsTresoriers.FullRowSelect = true;
            this.lvActionsTresoriers.GridLines = true;
            this.lvActionsTresoriers.Location = new System.Drawing.Point(0, 0);
            this.lvActionsTresoriers.MultiSelect = false;
            this.lvActionsTresoriers.Name = "lvActionsTresoriers";
            this.lvActionsTresoriers.Size = new System.Drawing.Size(800, 450);
            this.lvActionsTresoriers.TabIndex = 1;
            this.lvActionsTresoriers.UseCompatibleStateImageBehavior = false;
            this.lvActionsTresoriers.View = System.Windows.Forms.View.Details;
            // 
            // mailDemandeur
            // 
            this.mailDemandeur.Text = "E-mail du demandeur";
            this.mailDemandeur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mailDemandeur.Width = 187;
            // 
            // dateFrais
            // 
            this.dateFrais.Text = "Date de la demande";
            this.dateFrais.Width = 151;
            // 
            // dateModif
            // 
            this.dateModif.Text = "Date de modification";
            this.dateModif.Width = 218;
            // 
            // modifications
            // 
            this.modifications.Text = "Modification effectuée";
            this.modifications.Width = 239;
            // 
            // HistoriqueDesValidations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvActionsTresoriers);
            this.Name = "HistoriqueDesValidations";
            this.Text = "HistoriqueDesValidations";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvActionsTresoriers;
        private System.Windows.Forms.ColumnHeader dateFrais;
        private System.Windows.Forms.ColumnHeader mailDemandeur;
        private System.Windows.Forms.ColumnHeader modifications;
        private System.Windows.Forms.ColumnHeader dateModif;
    }
}
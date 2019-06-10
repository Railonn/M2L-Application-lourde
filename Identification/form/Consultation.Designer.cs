namespace Identification.form
{
    partial class FrmConsultation
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
            this.dateFrais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.motifFrais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trajetFrais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kmFrais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.peageFrais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.repasFrais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.herbergFrais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvFrais = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // dateFrais
            // 
            this.dateFrais.Text = "Date";
            this.dateFrais.Width = 100;
            // 
            // motifFrais
            // 
            this.motifFrais.Text = "Motif";
            this.motifFrais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.motifFrais.Width = 120;
            // 
            // trajetFrais
            // 
            this.trajetFrais.Text = "Trajet";
            this.trajetFrais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.trajetFrais.Width = 120;
            // 
            // kmFrais
            // 
            this.kmFrais.Text = "Km";
            this.kmFrais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kmFrais.Width = 85;
            // 
            // peageFrais
            // 
            this.peageFrais.Text = "Péage";
            this.peageFrais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.peageFrais.Width = 85;
            // 
            // repasFrais
            // 
            this.repasFrais.Text = "Repas";
            this.repasFrais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.repasFrais.Width = 85;
            // 
            // herbergFrais
            // 
            this.herbergFrais.Text = "Hébergement";
            this.herbergFrais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.herbergFrais.Width = 85;
            // 
            // lvFrais
            // 
            this.lvFrais.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvFrais.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dateFrais,
            this.motifFrais,
            this.trajetFrais,
            this.kmFrais,
            this.peageFrais,
            this.repasFrais,
            this.herbergFrais});
            this.lvFrais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFrais.FullRowSelect = true;
            this.lvFrais.GridLines = true;
            this.lvFrais.Location = new System.Drawing.Point(0, 0);
            this.lvFrais.MultiSelect = false;
            this.lvFrais.Name = "lvFrais";
            this.lvFrais.Size = new System.Drawing.Size(684, 299);
            this.lvFrais.TabIndex = 0;
            this.lvFrais.UseCompatibleStateImageBehavior = false;
            this.lvFrais.View = System.Windows.Forms.View.Details;
            this.lvFrais.Click += new System.EventHandler(this.LvFrais_SelectedIndexChanged);
            // 
            // frmConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 299);
            this.Controls.Add(this.lvFrais);
            this.Name = "frmConsultation";
            this.Text = "Consultation des frais";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader dateFrais;
        private System.Windows.Forms.ColumnHeader motifFrais;
        private System.Windows.Forms.ColumnHeader trajetFrais;
        private System.Windows.Forms.ColumnHeader kmFrais;
        private System.Windows.Forms.ColumnHeader peageFrais;
        private System.Windows.Forms.ColumnHeader repasFrais;
        private System.Windows.Forms.ColumnHeader herbergFrais;
        private System.Windows.Forms.ListView lvFrais;
    }
}
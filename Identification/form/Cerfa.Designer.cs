namespace Identification.form
{
    partial class frmCerfa
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbBeneficiare = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRaison = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDonnateur = new System.Windows.Forms.ComboBox();
            this.liguesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.liguesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 240);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(743, 0);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // cbBeneficiare
            // 
            this.cbBeneficiare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBeneficiare.FormattingEnabled = true;
            this.cbBeneficiare.Location = new System.Drawing.Point(12, 32);
            this.cbBeneficiare.Name = "cbBeneficiare";
            this.cbBeneficiare.Size = new System.Drawing.Size(719, 26);
            this.cbBeneficiare.TabIndex = 1;
            this.cbBeneficiare.Text = "Nom du club";
            this.cbBeneficiare.SelectedIndexChanged += new System.EventHandler(this.cbBeneficiare_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // cbRaison
            // 
            this.cbRaison.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRaison.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRaison.FormattingEnabled = true;
            this.cbRaison.ItemHeight = 18;
            this.cbRaison.Items.AddRange(new object[] {
            "Oeuvre ou organisme d\'intérêt général",
            "Fondation d\"entreprise",
            "Association ou fonsation reconnue d\'utilité publique",
            "Musée de france",
            "Association culturelle ou de bienfaissance",
            "Etablissement d\'enseignement supérieur ou artistique privé",
            "Association fournissant gratuitement une aide alimentaire ou médicale",
            "Organisme ayant pour objet exclusif de participer financierement à la creation d\'" +
                "entreprise",
            "Etablissement public des cultes reconnue d\'Alsace-Moselle",
            "Société ou organisme agréé de recherche scientifique ou technique",
            "Organisme ayant pour activité principale l\'organisme de festivals"});
            this.cbRaison.Location = new System.Drawing.Point(12, 84);
            this.cbRaison.Name = "cbRaison";
            this.cbRaison.Size = new System.Drawing.Size(719, 26);
            this.cbRaison.TabIndex = 0;
            this.cbRaison.Tag = "";
            this.cbRaison.Text = "Type du bénéficiaire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bénéficiare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Donnateur";
            // 
            // cbDonnateur
            // 
            this.cbDonnateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDonnateur.FormattingEnabled = true;
            this.cbDonnateur.Location = new System.Drawing.Point(11, 136);
            this.cbDonnateur.Name = "cbDonnateur";
            this.cbDonnateur.Size = new System.Drawing.Size(719, 26);
            this.cbDonnateur.TabIndex = 5;
            this.cbDonnateur.Text = "Nom du donnateur";
            // 
            // liguesBindingSource
            // 
            this.liguesBindingSource.DataSource = typeof(Identification.BDD.ligues);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCerfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 240);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbDonnateur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbRaison);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cbBeneficiare);
            this.Name = "frmCerfa";
            this.Text = "Reçu des dons";
            ((System.ComponentModel.ISupportInitialize)(this.liguesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbBeneficiare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRaison;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDonnateur;
        private System.Windows.Forms.BindingSource liguesBindingSource;
        private System.Windows.Forms.Button button1;
    }
}
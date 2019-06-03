namespace Identification.form
{
    partial class FrmValideFrais
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrajet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.lbDemandeur = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbDateDemande = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnValider = new System.Windows.Forms.Button();
            this.numKmValide = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numHebergementValide = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKmDemande = new System.Windows.Forms.TextBox();
            this.txtPeageDemande = new System.Windows.Forms.TextBox();
            this.txtRepasDemande = new System.Windows.Forms.TextBox();
            this.txtHebergementDemande = new System.Windows.Forms.TextBox();
            this.numPeageValide = new System.Windows.Forms.NumericUpDown();
            this.numRepasValide = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalDemande = new System.Windows.Forms.TextBox();
            this.txtTotalValide = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKmValide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHebergementValide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeageValide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRepasValide)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtTrajet, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtMotif, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbDemandeur, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbDateDemande, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(263, 174);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Demandeur : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Trajet :";
            // 
            // txtTrajet
            // 
            this.txtTrajet.Location = new System.Drawing.Point(80, 114);
            this.txtTrajet.Name = "txtTrajet";
            this.txtTrajet.ReadOnly = true;
            this.txtTrajet.Size = new System.Drawing.Size(178, 20);
            this.txtTrajet.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Motif :";
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(80, 88);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.ReadOnly = true;
            this.txtMotif.Size = new System.Drawing.Size(178, 20);
            this.txtMotif.TabIndex = 6;
            // 
            // lbDemandeur
            // 
            this.lbDemandeur.FormattingEnabled = true;
            this.lbDemandeur.Location = new System.Drawing.Point(80, 16);
            this.lbDemandeur.Name = "lbDemandeur";
            this.lbDemandeur.Size = new System.Drawing.Size(178, 30);
            this.lbDemandeur.TabIndex = 8;
            this.lbDemandeur.SelectedIndexChanged += new System.EventHandler(this.LbDemandeur_SelectedIndexChanged);
            this.lbDemandeur.MouseCaptureChanged += new System.EventHandler(this.LbDemandeur_MouseCaptureChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Demande :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(80, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Information général";
            // 
            // lbDateDemande
            // 
            this.lbDateDemande.FormattingEnabled = true;
            this.lbDateDemande.Location = new System.Drawing.Point(80, 52);
            this.lbDateDemande.Name = "lbDateDemande";
            this.lbDateDemande.Size = new System.Drawing.Size(178, 30);
            this.lbDateDemande.TabIndex = 9;
            this.lbDateDemande.SelectedIndexChanged += new System.EventHandler(this.LbDateDemande_SelectedIndexChanged);
            this.lbDateDemande.MouseCaptureChanged += new System.EventHandler(this.LbDateDemande_MouseCaptureChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnValider, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.numKmValide, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.numHebergementValide, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtKmDemande, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtPeageDemande, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtRepasDemande, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtHebergementDemande, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.numPeageValide, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.numRepasValide, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtTotalDemande, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtTotalValide, 2, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(276, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(334, 173);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(232, 146);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(83, 23);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // numKmValide
            // 
            this.numKmValide.Location = new System.Drawing.Point(232, 16);
            this.numKmValide.Name = "numKmValide";
            this.numKmValide.Size = new System.Drawing.Size(83, 20);
            this.numKmValide.TabIndex = 6;
            this.numKmValide.ValueChanged += new System.EventHandler(this.NumValide_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Km parcourue (0.28€/km) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Demande";
            // 
            // numHebergementValide
            // 
            this.numHebergementValide.DecimalPlaces = 2;
            this.numHebergementValide.Location = new System.Drawing.Point(232, 94);
            this.numHebergementValide.Name = "numHebergementValide";
            this.numHebergementValide.Size = new System.Drawing.Size(83, 20);
            this.numHebergementValide.TabIndex = 16;
            this.numHebergementValide.ValueChanged += new System.EventHandler(this.NumValide_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Valider";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Cout du peage :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Cout du repas :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Cout de l\'hebergement :";
            // 
            // txtKmDemande
            // 
            this.txtKmDemande.Location = new System.Drawing.Point(143, 16);
            this.txtKmDemande.Name = "txtKmDemande";
            this.txtKmDemande.ReadOnly = true;
            this.txtKmDemande.Size = new System.Drawing.Size(83, 20);
            this.txtKmDemande.TabIndex = 6;
            // 
            // txtPeageDemande
            // 
            this.txtPeageDemande.Location = new System.Drawing.Point(143, 42);
            this.txtPeageDemande.Name = "txtPeageDemande";
            this.txtPeageDemande.ReadOnly = true;
            this.txtPeageDemande.Size = new System.Drawing.Size(83, 20);
            this.txtPeageDemande.TabIndex = 8;
            // 
            // txtRepasDemande
            // 
            this.txtRepasDemande.Location = new System.Drawing.Point(143, 68);
            this.txtRepasDemande.Name = "txtRepasDemande";
            this.txtRepasDemande.ReadOnly = true;
            this.txtRepasDemande.Size = new System.Drawing.Size(83, 20);
            this.txtRepasDemande.TabIndex = 10;
            // 
            // txtHebergementDemande
            // 
            this.txtHebergementDemande.Location = new System.Drawing.Point(143, 94);
            this.txtHebergementDemande.Name = "txtHebergementDemande";
            this.txtHebergementDemande.ReadOnly = true;
            this.txtHebergementDemande.Size = new System.Drawing.Size(83, 20);
            this.txtHebergementDemande.TabIndex = 12;
            // 
            // numPeageValide
            // 
            this.numPeageValide.DecimalPlaces = 2;
            this.numPeageValide.Location = new System.Drawing.Point(232, 42);
            this.numPeageValide.Name = "numPeageValide";
            this.numPeageValide.Size = new System.Drawing.Size(83, 20);
            this.numPeageValide.TabIndex = 14;
            this.numPeageValide.ValueChanged += new System.EventHandler(this.NumValide_ValueChanged);
            // 
            // numRepasValide
            // 
            this.numRepasValide.DecimalPlaces = 2;
            this.numRepasValide.Location = new System.Drawing.Point(232, 68);
            this.numRepasValide.Name = "numRepasValide";
            this.numRepasValide.Size = new System.Drawing.Size(83, 20);
            this.numRepasValide.TabIndex = 15;
            this.numRepasValide.ValueChanged += new System.EventHandler(this.NumValide_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Total :";
            // 
            // txtTotalDemande
            // 
            this.txtTotalDemande.Location = new System.Drawing.Point(143, 120);
            this.txtTotalDemande.Name = "txtTotalDemande";
            this.txtTotalDemande.ReadOnly = true;
            this.txtTotalDemande.Size = new System.Drawing.Size(83, 20);
            this.txtTotalDemande.TabIndex = 18;
            // 
            // txtTotalValide
            // 
            this.txtTotalValide.Location = new System.Drawing.Point(232, 120);
            this.txtTotalValide.Name = "txtTotalValide";
            this.txtTotalValide.ReadOnly = true;
            this.txtTotalValide.Size = new System.Drawing.Size(83, 20);
            this.txtTotalValide.TabIndex = 19;
            this.txtTotalValide.Text = "0.00";
            // 
            // frmValideFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 185);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmValideFrais";
            this.Text = "Validation d\'une ligne de frais";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKmValide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHebergementValide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeageValide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRepasValide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.TextBox txtTrajet;
        private System.Windows.Forms.ListBox lbDemandeur;
        private System.Windows.Forms.ListBox lbDateDemande;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKmDemande;
        private System.Windows.Forms.TextBox txtPeageDemande;
        private System.Windows.Forms.TextBox txtRepasDemande;
        private System.Windows.Forms.TextBox txtHebergementDemande;
        private System.Windows.Forms.NumericUpDown numKmValide;
        private System.Windows.Forms.NumericUpDown numHebergementValide;
        private System.Windows.Forms.NumericUpDown numPeageValide;
        private System.Windows.Forms.NumericUpDown numRepasValide;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalDemande;
        private System.Windows.Forms.TextBox txtTotalValide;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnValider;
    }
}
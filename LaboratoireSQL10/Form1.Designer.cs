namespace LaboratoireSQL10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Programmes = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVoirListeProg = new System.Windows.Forms.Button();
            this.btnModifierProg = new System.Windows.Forms.Button();
            this.btnSupprimerProg = new System.Windows.Forms.Button();
            this.btnRechercherProg = new System.Windows.Forms.Button();
            this.btnAjouterProg = new System.Windows.Forms.Button();
            this.txtProgrammeName = new System.Windows.Forms.TextBox();
            this.txtProgrammeId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Étudiants = new System.Windows.Forms.TabPage();
            this.dataGridProg = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Programmes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProg)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Programmes);
            this.tabControl1.Controls.Add(this.Étudiants);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // Programmes
            // 
            this.Programmes.Controls.Add(this.groupBox1);
            this.Programmes.Controls.Add(this.txtProgrammeName);
            this.Programmes.Controls.Add(this.txtProgrammeId);
            this.Programmes.Controls.Add(this.label2);
            this.Programmes.Controls.Add(this.label1);
            this.Programmes.Location = new System.Drawing.Point(4, 24);
            this.Programmes.Name = "Programmes";
            this.Programmes.Padding = new System.Windows.Forms.Padding(3);
            this.Programmes.Size = new System.Drawing.Size(791, 418);
            this.Programmes.TabIndex = 0;
            this.Programmes.Text = "Programmes";
            this.Programmes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVoirListeProg);
            this.groupBox1.Controls.Add(this.btnModifierProg);
            this.groupBox1.Controls.Add(this.btnSupprimerProg);
            this.groupBox1.Controls.Add(this.btnRechercherProg);
            this.groupBox1.Controls.Add(this.btnAjouterProg);
            this.groupBox1.Location = new System.Drawing.Point(6, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boutons";
            // 
            // btnVoirListeProg
            // 
            this.btnVoirListeProg.Location = new System.Drawing.Point(651, 31);
            this.btnVoirListeProg.Name = "btnVoirListeProg";
            this.btnVoirListeProg.Size = new System.Drawing.Size(92, 34);
            this.btnVoirListeProg.TabIndex = 4;
            this.btnVoirListeProg.Text = "Voir Liste";
            this.btnVoirListeProg.UseVisualStyleBackColor = true;
            this.btnVoirListeProg.Click += new System.EventHandler(this.btnVoirListeProg_Click);
            // 
            // btnModifierProg
            // 
            this.btnModifierProg.Location = new System.Drawing.Point(510, 31);
            this.btnModifierProg.Name = "btnModifierProg";
            this.btnModifierProg.Size = new System.Drawing.Size(92, 34);
            this.btnModifierProg.TabIndex = 3;
            this.btnModifierProg.Text = "Modifier";
            this.btnModifierProg.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerProg
            // 
            this.btnSupprimerProg.Location = new System.Drawing.Point(352, 31);
            this.btnSupprimerProg.Name = "btnSupprimerProg";
            this.btnSupprimerProg.Size = new System.Drawing.Size(92, 34);
            this.btnSupprimerProg.TabIndex = 2;
            this.btnSupprimerProg.Text = "Supprimer";
            this.btnSupprimerProg.UseVisualStyleBackColor = true;
            // 
            // btnRechercherProg
            // 
            this.btnRechercherProg.Location = new System.Drawing.Point(186, 31);
            this.btnRechercherProg.Name = "btnRechercherProg";
            this.btnRechercherProg.Size = new System.Drawing.Size(92, 34);
            this.btnRechercherProg.TabIndex = 1;
            this.btnRechercherProg.Text = "Rechercher";
            this.btnRechercherProg.UseVisualStyleBackColor = true;
            // 
            // btnAjouterProg
            // 
            this.btnAjouterProg.Location = new System.Drawing.Point(25, 31);
            this.btnAjouterProg.Name = "btnAjouterProg";
            this.btnAjouterProg.Size = new System.Drawing.Size(92, 34);
            this.btnAjouterProg.TabIndex = 0;
            this.btnAjouterProg.Text = "Ajouter";
            this.btnAjouterProg.UseVisualStyleBackColor = true;
            this.btnAjouterProg.Click += new System.EventHandler(this.btnAjouterProg_Click);
            // 
            // txtProgrammeName
            // 
            this.txtProgrammeName.Location = new System.Drawing.Point(6, 102);
            this.txtProgrammeName.Name = "txtProgrammeName";
            this.txtProgrammeName.Size = new System.Drawing.Size(775, 23);
            this.txtProgrammeName.TabIndex = 3;
            // 
            // txtProgrammeId
            // 
            this.txtProgrammeId.Location = new System.Drawing.Point(6, 30);
            this.txtProgrammeId.Name = "txtProgrammeId";
            this.txtProgrammeId.Size = new System.Drawing.Size(775, 23);
            this.txtProgrammeId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom du programme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programme Id";
            // 
            // Étudiants
            // 
            this.Étudiants.Location = new System.Drawing.Point(4, 24);
            this.Étudiants.Name = "Étudiants";
            this.Étudiants.Padding = new System.Windows.Forms.Padding(3);
            this.Étudiants.Size = new System.Drawing.Size(791, 418);
            this.Étudiants.TabIndex = 1;
            this.Étudiants.Text = "Étudiants";
            this.Étudiants.UseVisualStyleBackColor = true;
            // 
            // dataGridProg
            // 
            this.dataGridProg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProg.Location = new System.Drawing.Point(808, 27);
            this.dataGridProg.Name = "dataGridProg";
            this.dataGridProg.RowTemplate.Height = 25;
            this.dataGridProg.Size = new System.Drawing.Size(480, 418);
            this.dataGridProg.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 463);
            this.Controls.Add(this.dataGridProg);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Programmes.ResumeLayout(false);
            this.Programmes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage Programmes;
        private GroupBox groupBox1;
        private Button btnVoirListeProg;
        private Button btnModifierProg;
        private Button btnSupprimerProg;
        private Button btnRechercherProg;
        private Button btnAjouterProg;
        private TextBox txtProgrammeName;
        private TextBox txtProgrammeId;
        private Label label2;
        private Label label1;
        private TabPage Étudiants;
        private DataGridView dataGridProg;
    }
}
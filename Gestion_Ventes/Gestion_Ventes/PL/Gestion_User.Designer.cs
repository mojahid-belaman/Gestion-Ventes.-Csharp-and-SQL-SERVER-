namespace Gestion_Ventes.PL
{
    partial class Gestion_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_User));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pcbMinimized = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnAjouUti = new System.Windows.Forms.Button();
            this.btnImprimerUti = new System.Windows.Forms.Button();
            this.btnSuprimerUti = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvutilisateur = new System.Windows.Forms.DataGridView();
            this.txtSearchUti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvutilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pcbMinimized);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1354, 29);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(7, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gestion_Utilisateur";
            // 
            // pcbMinimized
            // 
            this.pcbMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbMinimized.BackColor = System.Drawing.Color.Transparent;
            this.pcbMinimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbMinimized.Image = ((System.Drawing.Image)(resources.GetObject("pcbMinimized.Image")));
            this.pcbMinimized.Location = new System.Drawing.Point(1295, 3);
            this.pcbMinimized.Name = "pcbMinimized";
            this.pcbMinimized.Size = new System.Drawing.Size(24, 24);
            this.pcbMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMinimized.TabIndex = 3;
            this.pcbMinimized.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1327, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // btnAjouUti
            // 
            this.btnAjouUti.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAjouUti.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnAjouUti.FlatAppearance.BorderSize = 0;
            this.btnAjouUti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnAjouUti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouUti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouUti.ForeColor = System.Drawing.Color.White;
            this.btnAjouUti.Location = new System.Drawing.Point(11, 649);
            this.btnAjouUti.Name = "btnAjouUti";
            this.btnAjouUti.Size = new System.Drawing.Size(329, 35);
            this.btnAjouUti.TabIndex = 60;
            this.btnAjouUti.Text = "Ajouter un Nouveau Utilisateur";
            this.btnAjouUti.UseVisualStyleBackColor = false;
            this.btnAjouUti.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnImprimerUti
            // 
            this.btnImprimerUti.BackColor = System.Drawing.Color.DarkOrange;
            this.btnImprimerUti.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnImprimerUti.FlatAppearance.BorderSize = 0;
            this.btnImprimerUti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnImprimerUti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimerUti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerUti.ForeColor = System.Drawing.Color.White;
            this.btnImprimerUti.Location = new System.Drawing.Point(969, 649);
            this.btnImprimerUti.Name = "btnImprimerUti";
            this.btnImprimerUti.Size = new System.Drawing.Size(375, 35);
            this.btnImprimerUti.TabIndex = 59;
            this.btnImprimerUti.Text = "Modifié Données d\'utilisateur\r\n";
            this.btnImprimerUti.UseVisualStyleBackColor = false;
            this.btnImprimerUti.Click += new System.EventHandler(this.btnImprimerUti_Click);
            // 
            // btnSuprimerUti
            // 
            this.btnSuprimerUti.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSuprimerUti.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnSuprimerUti.FlatAppearance.BorderSize = 0;
            this.btnSuprimerUti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnSuprimerUti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuprimerUti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuprimerUti.ForeColor = System.Drawing.Color.White;
            this.btnSuprimerUti.Location = new System.Drawing.Point(462, 649);
            this.btnSuprimerUti.Name = "btnSuprimerUti";
            this.btnSuprimerUti.Size = new System.Drawing.Size(375, 35);
            this.btnSuprimerUti.TabIndex = 58;
            this.btnSuprimerUti.Text = "Supprimer Utilisateur Sélectionné";
            this.btnSuprimerUti.UseVisualStyleBackColor = false;
            this.btnSuprimerUti.Click += new System.EventHandler(this.btnSuprimerUti_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(969, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvutilisateur);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(10, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1339, 447);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listes des Utilisateurs";
            // 
            // dgvutilisateur
            // 
            this.dgvutilisateur.AllowUserToAddRows = false;
            this.dgvutilisateur.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy;
            this.dgvutilisateur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvutilisateur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvutilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvutilisateur.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvutilisateur.Location = new System.Drawing.Point(6, 58);
            this.dgvutilisateur.MultiSelect = false;
            this.dgvutilisateur.Name = "dgvutilisateur";
            this.dgvutilisateur.ReadOnly = true;
            this.dgvutilisateur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvutilisateur.Size = new System.Drawing.Size(1327, 371);
            this.dgvutilisateur.TabIndex = 0;
            // 
            // txtSearchUti
            // 
            this.txtSearchUti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchUti.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUti.Location = new System.Drawing.Point(580, 81);
            this.txtSearchUti.Name = "txtSearchUti";
            this.txtSearchUti.Size = new System.Drawing.Size(391, 25);
            this.txtSearchUti.TabIndex = 54;
            this.txtSearchUti.TextChanged += new System.EventHandler(this.txtSearchUti_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(253, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "Entrez les Mots-Clés de Recherche :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Gestion_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gestion_Ventes.Properties.Resources.apple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.btnAjouUti);
            this.Controls.Add(this.btnImprimerUti);
            this.Controls.Add(this.btnSuprimerUti);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearchUti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion_User";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvutilisateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcbMinimized;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnImprimerUti;
        private System.Windows.Forms.Button btnSuprimerUti;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvutilisateur;
        private System.Windows.Forms.TextBox txtSearchUti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjouUti;
    }
}
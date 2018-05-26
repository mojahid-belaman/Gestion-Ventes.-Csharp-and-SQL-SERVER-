namespace Gestion_Ventes.PL
{
    partial class Frm_Commande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Commande));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pcbMinimized = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCommande = new System.Windows.Forms.DataGridView();
            this.txtSearchCmd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImprimerCmd = new System.Windows.Forms.Button();
            this.btnSuprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommande)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(1338, 29);
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
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gestion_Commande";
            // 
            // pcbMinimized
            // 
            this.pcbMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbMinimized.BackColor = System.Drawing.Color.Transparent;
            this.pcbMinimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbMinimized.Image = ((System.Drawing.Image)(resources.GetObject("pcbMinimized.Image")));
            this.pcbMinimized.Location = new System.Drawing.Point(1279, 3);
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
            this.pictureBox5.Location = new System.Drawing.Point(1311, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(959, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvCommande);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(0, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1339, 419);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des Commandes";
            // 
            // dgvCommande
            // 
            this.dgvCommande.AllowUserToAddRows = false;
            this.dgvCommande.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy;
            this.dgvCommande.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCommande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCommande.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCommande.Location = new System.Drawing.Point(6, 32);
            this.dgvCommande.MultiSelect = false;
            this.dgvCommande.Name = "dgvCommande";
            this.dgvCommande.ReadOnly = true;
            this.dgvCommande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommande.Size = new System.Drawing.Size(1327, 377);
            this.dgvCommande.TabIndex = 0;
            // 
            // txtSearchCmd
            // 
            this.txtSearchCmd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchCmd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCmd.Location = new System.Drawing.Point(570, 79);
            this.txtSearchCmd.Name = "txtSearchCmd";
            this.txtSearchCmd.Size = new System.Drawing.Size(391, 25);
            this.txtSearchCmd.TabIndex = 7;
            this.txtSearchCmd.TextChanged += new System.EventHandler(this.txtSearchCmd_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(243, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Entrez les Mots-Clés de Recherche :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnImprimerCmd
            // 
            this.btnImprimerCmd.BackColor = System.Drawing.Color.DarkOrange;
            this.btnImprimerCmd.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnImprimerCmd.FlatAppearance.BorderSize = 0;
            this.btnImprimerCmd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnImprimerCmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimerCmd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerCmd.ForeColor = System.Drawing.Color.White;
            this.btnImprimerCmd.Location = new System.Drawing.Point(913, 615);
            this.btnImprimerCmd.Name = "btnImprimerCmd";
            this.btnImprimerCmd.Size = new System.Drawing.Size(375, 35);
            this.btnImprimerCmd.TabIndex = 52;
            this.btnImprimerCmd.Text = "Imprimer Commande Spécifié";
            this.btnImprimerCmd.UseVisualStyleBackColor = false;
            this.btnImprimerCmd.Click += new System.EventHandler(this.btnImprimerCmd_Click);
            // 
            // btnSuprimer
            // 
            this.btnSuprimer.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSuprimer.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnSuprimer.FlatAppearance.BorderSize = 0;
            this.btnSuprimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnSuprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuprimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuprimer.ForeColor = System.Drawing.Color.White;
            this.btnSuprimer.Location = new System.Drawing.Point(452, 615);
            this.btnSuprimer.Name = "btnSuprimer";
            this.btnSuprimer.Size = new System.Drawing.Size(375, 35);
            this.btnSuprimer.TabIndex = 51;
            this.btnSuprimer.Text = "Supprimer Commande Sélectionné";
            this.btnSuprimer.UseVisualStyleBackColor = false;
            this.btnSuprimer.Click += new System.EventHandler(this.btnSuprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAjouter.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(34, 615);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(325, 35);
            this.btnAjouter.TabIndex = 53;
            this.btnAjouter.Text = "Ajouter un Nouveau Commande";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // Frm_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gestion_Ventes.Properties.Resources.apple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1338, 694);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnImprimerCmd);
            this.Controls.Add(this.btnSuprimer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearchCmd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Commande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Commande";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcbMinimized;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvCommande;
        private System.Windows.Forms.TextBox txtSearchCmd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimerCmd;
        private System.Windows.Forms.Button btnSuprimer;
        private System.Windows.Forms.Button btnAjouter;
    }
}
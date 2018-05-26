namespace Gestion_Ventes.PL
{
    partial class Catégorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catégorie));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbclose = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCategorie = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnImprimerSingle = new System.Windows.Forms.Button();
            this.btnSaveCatPro = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSuprimer = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.pictureNext = new System.Windows.Forms.PictureBox();
            this.picturePreview = new System.Windows.Forms.PictureBox();
            this.pictureLast = new System.Windows.Forms.PictureBox();
            this.pictureFirst = new System.Windows.Forms.PictureBox();
            this.labelPos = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorie)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFirst)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.pbclose);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1143, 29);
            this.panel2.TabIndex = 11;
            // 
            // pbclose
            // 
            this.pbclose.BackColor = System.Drawing.Color.Transparent;
            this.pbclose.Image = ((System.Drawing.Image)(resources.GetObject("pbclose.Image")));
            this.pbclose.Location = new System.Drawing.Point(1114, 3);
            this.pbclose.Name = "pbclose";
            this.pbclose.Size = new System.Drawing.Size(24, 24);
            this.pbclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbclose.TabIndex = 7;
            this.pbclose.TabStop = false;
            this.pbclose.Click += new System.EventHandler(this.pbclose_Click_1);
            this.pbclose.MouseLeave += new System.EventHandler(this.pbclose_MouseLeave_1);
            this.pbclose.MouseHover += new System.EventHandler(this.pbclose_MouseHover_1);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1083, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(7, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gestion_Catégorie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID de Catégorie :";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(205, 64);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(156, 27);
            this.txtID.TabIndex = 13;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(6, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Description Catégorie :";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(205, 149);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtName.Size = new System.Drawing.Size(263, 64);
            this.txtName.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(653, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 219);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Données Catégorie";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvCategorie);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(12, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(617, 294);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listes des Catégories";
            // 
            // dgvCategorie
            // 
            this.dgvCategorie.AllowUserToAddRows = false;
            this.dgvCategorie.AllowUserToDeleteRows = false;
            this.dgvCategorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorie.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorie.Location = new System.Drawing.Point(6, 32);
            this.dgvCategorie.MultiSelect = false;
            this.dgvCategorie.Name = "dgvCategorie";
            this.dgvCategorie.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvCategorie.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategorie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorie.Size = new System.Drawing.Size(602, 256);
            this.dgvCategorie.TabIndex = 0;
            this.dgvCategorie.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnImprimerSingle);
            this.groupBox3.Controls.Add(this.btnSaveCatPro);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnSuprimer);
            this.groupBox3.Controls.Add(this.btnNew);
            this.groupBox3.Controls.Add(this.btnAjouter);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(12, 409);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1128, 167);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opérations";
            // 
            // btnImprimerSingle
            // 
            this.btnImprimerSingle.BackColor = System.Drawing.Color.DarkOrange;
            this.btnImprimerSingle.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnImprimerSingle.FlatAppearance.BorderSize = 0;
            this.btnImprimerSingle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnImprimerSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimerSingle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerSingle.ForeColor = System.Drawing.Color.White;
            this.btnImprimerSingle.Location = new System.Drawing.Point(265, 109);
            this.btnImprimerSingle.Name = "btnImprimerSingle";
            this.btnImprimerSingle.Size = new System.Drawing.Size(258, 39);
            this.btnImprimerSingle.TabIndex = 76;
            this.btnImprimerSingle.Text = "Imprimer Catégorie Spécifié";
            this.btnImprimerSingle.UseVisualStyleBackColor = false;
            this.btnImprimerSingle.Click += new System.EventHandler(this.btnImprimerSingle_Click);
            // 
            // btnSaveCatPro
            // 
            this.btnSaveCatPro.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSaveCatPro.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnSaveCatPro.FlatAppearance.BorderSize = 0;
            this.btnSaveCatPro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnSaveCatPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCatPro.ForeColor = System.Drawing.Color.White;
            this.btnSaveCatPro.Location = new System.Drawing.Point(535, 98);
            this.btnSaveCatPro.Name = "btnSaveCatPro";
            this.btnSaveCatPro.Size = new System.Drawing.Size(308, 58);
            this.btnSaveCatPro.TabIndex = 75;
            this.btnSaveCatPro.Text = "Sauvgarder Catégorie Spécifié \r\nSon Produit dans PDF";
            this.btnSaveCatPro.UseVisualStyleBackColor = false;
            this.btnSaveCatPro.Click += new System.EventHandler(this.btnSaveCatPro_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(846, 43);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(265, 39);
            this.btnUpdate.TabIndex = 74;
            this.btnUpdate.Text = "Modifié Catégorie ";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnSuprimer.Location = new System.Drawing.Point(545, 43);
            this.btnSuprimer.Name = "btnSuprimer";
            this.btnSuprimer.Size = new System.Drawing.Size(286, 39);
            this.btnSuprimer.TabIndex = 73;
            this.btnSuprimer.Text = "Supprimer Catégorie Sélectionné";
            this.btnSuprimer.UseVisualStyleBackColor = false;
            this.btnSuprimer.Click += new System.EventHandler(this.btnSuprimer_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(6, 43);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(238, 39);
            this.btnNew.TabIndex = 71;
            this.btnNew.Text = "Nouveau";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAjouter.Enabled = false;
            this.btnAjouter.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(265, 43);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(269, 39);
            this.btnAjouter.TabIndex = 71;
            this.btnAjouter.Text = "Ajouter un Nouveau Catégorie";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // pictureNext
            // 
            this.pictureNext.BackColor = System.Drawing.Color.Transparent;
            this.pictureNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureNext.Image = ((System.Drawing.Image)(resources.GetObject("pictureNext.Image")));
            this.pictureNext.Location = new System.Drawing.Point(771, 99);
            this.pictureNext.Name = "pictureNext";
            this.pictureNext.Size = new System.Drawing.Size(61, 43);
            this.pictureNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNext.TabIndex = 16;
            this.pictureNext.TabStop = false;
            this.pictureNext.Click += new System.EventHandler(this.pictureNext_Click);
            // 
            // picturePreview
            // 
            this.picturePreview.BackColor = System.Drawing.Color.Transparent;
            this.picturePreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturePreview.Image = ((System.Drawing.Image)(resources.GetObject("picturePreview.Image")));
            this.picturePreview.Location = new System.Drawing.Point(964, 99);
            this.picturePreview.Name = "picturePreview";
            this.picturePreview.Size = new System.Drawing.Size(61, 43);
            this.picturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePreview.TabIndex = 16;
            this.picturePreview.TabStop = false;
            this.picturePreview.Click += new System.EventHandler(this.picturePreview_Click);
            // 
            // pictureLast
            // 
            this.pictureLast.BackColor = System.Drawing.Color.Transparent;
            this.pictureLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureLast.Image = ((System.Drawing.Image)(resources.GetObject("pictureLast.Image")));
            this.pictureLast.Location = new System.Drawing.Point(704, 99);
            this.pictureLast.Name = "pictureLast";
            this.pictureLast.Size = new System.Drawing.Size(61, 43);
            this.pictureLast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLast.TabIndex = 16;
            this.pictureLast.TabStop = false;
            this.pictureLast.Click += new System.EventHandler(this.pictureLast_Click);
            // 
            // pictureFirst
            // 
            this.pictureFirst.BackColor = System.Drawing.Color.Transparent;
            this.pictureFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureFirst.Image = ((System.Drawing.Image)(resources.GetObject("pictureFirst.Image")));
            this.pictureFirst.Location = new System.Drawing.Point(1031, 99);
            this.pictureFirst.Name = "pictureFirst";
            this.pictureFirst.Size = new System.Drawing.Size(61, 43);
            this.pictureFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFirst.TabIndex = 16;
            this.pictureFirst.TabStop = false;
            this.pictureFirst.Click += new System.EventHandler(this.pictureFirst_Click);
            // 
            // labelPos
            // 
            this.labelPos.AutoSize = true;
            this.labelPos.BackColor = System.Drawing.Color.Transparent;
            this.labelPos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelPos.Location = new System.Drawing.Point(877, 114);
            this.labelPos.Name = "labelPos";
            this.labelPos.Size = new System.Drawing.Size(36, 17);
            this.labelPos.TabIndex = 19;
            this.labelPos.Text = "6 / 7";
            // 
            // Catégorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 601);
            this.Controls.Add(this.labelPos);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureFirst);
            this.Controls.Add(this.picturePreview);
            this.Controls.Add(this.pictureLast);
            this.Controls.Add(this.pictureNext);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Catégorie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catégorie";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorie)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFirst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCategorie;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureNext;
        private System.Windows.Forms.PictureBox picturePreview;
        private System.Windows.Forms.PictureBox pictureLast;
        private System.Windows.Forms.PictureBox pictureFirst;
        private System.Windows.Forms.Label labelPos;
        private System.Windows.Forms.Button btnSuprimer;
        private System.Windows.Forms.Button btnSaveCatPro;
        private System.Windows.Forms.Button btnImprimerSingle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbclose;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}
namespace Gestion_Ventes.PL
{
    partial class Frm_ADD_USER
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
            this.frm = new System.Windows.Forms.PictureBox();
            this.minimized = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAdd_Utili = new System.Windows.Forms.Label();
            this.pbclose = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomUti = new System.Windows.Forms.TextBox();
            this.txtNomCom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCPSW = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureANU = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.frm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimized)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureANU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // frm
            // 
            this.frm.BackColor = System.Drawing.Color.Transparent;
            this.frm.Image = global::Gestion_Ventes.Properties.Resources.Close3b;
            this.frm.Location = new System.Drawing.Point(594, 3);
            this.frm.Name = "frm";
            this.frm.Size = new System.Drawing.Size(24, 24);
            this.frm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frm.TabIndex = 3;
            this.frm.TabStop = false;
            this.frm.Click += new System.EventHandler(this.frm_Click);
            // 
            // minimized
            // 
            this.minimized.BackColor = System.Drawing.Color.Transparent;
            this.minimized.Image = global::Gestion_Ventes.Properties.Resources.minimize_icon_29;
            this.minimized.Location = new System.Drawing.Point(563, 3);
            this.minimized.Name = "minimized";
            this.minimized.Size = new System.Drawing.Size(24, 24);
            this.minimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimized.TabIndex = 4;
            this.minimized.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.labelAdd_Utili);
            this.panel2.Controls.Add(this.frm);
            this.panel2.Controls.Add(this.minimized);
            this.panel2.Controls.Add(this.pbclose);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 29);
            this.panel2.TabIndex = 11;
            // 
            // labelAdd_Utili
            // 
            this.labelAdd_Utili.AutoSize = true;
            this.labelAdd_Utili.BackColor = System.Drawing.Color.Transparent;
            this.labelAdd_Utili.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAdd_Utili.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdd_Utili.ForeColor = System.Drawing.Color.Purple;
            this.labelAdd_Utili.Location = new System.Drawing.Point(3, 3);
            this.labelAdd_Utili.Name = "labelAdd_Utili";
            this.labelAdd_Utili.Size = new System.Drawing.Size(151, 21);
            this.labelAdd_Utili.TabIndex = 11;
            this.labelAdd_Utili.Text = "Ajouter Utilisateur";
            // 
            // pbclose
            // 
            this.pbclose.BackColor = System.Drawing.Color.Transparent;
            this.pbclose.Image = global::Gestion_Ventes.Properties.Resources.Close3b;
            this.pbclose.Location = new System.Drawing.Point(838, 2);
            this.pbclose.Name = "pbclose";
            this.pbclose.Size = new System.Drawing.Size(24, 24);
            this.pbclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbclose.TabIndex = 2;
            this.pbclose.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Gestion_Ventes.Properties.Resources.minimize_icon_29;
            this.pictureBox6.Location = new System.Drawing.Point(807, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nom d\'utilisateur :";
            // 
            // txtNomUti
            // 
            this.txtNomUti.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomUti.Location = new System.Drawing.Point(321, 83);
            this.txtNomUti.Name = "txtNomUti";
            this.txtNomUti.Size = new System.Drawing.Size(276, 30);
            this.txtNomUti.TabIndex = 0;
            this.txtNomUti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomCom
            // 
            this.txtNomCom.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomCom.Location = new System.Drawing.Point(321, 156);
            this.txtNomCom.Name = "txtNomCom";
            this.txtNomCom.Size = new System.Drawing.Size(276, 30);
            this.txtNomCom.TabIndex = 1;
            this.txtNomCom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nom Complet :";
            // 
            // txtPsw
            // 
            this.txtPsw.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPsw.Location = new System.Drawing.Point(321, 238);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.PasswordChar = '*';
            this.txtPsw.Size = new System.Drawing.Size(276, 30);
            this.txtPsw.TabIndex = 2;
            this.txtPsw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(12, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mot de Passe :";
            // 
            // txtCPSW
            // 
            this.txtCPSW.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPSW.Location = new System.Drawing.Point(321, 313);
            this.txtCPSW.Name = "txtCPSW";
            this.txtCPSW.PasswordChar = '*';
            this.txtCPSW.Size = new System.Drawing.Size(276, 30);
            this.txtCPSW.TabIndex = 3;
            this.txtCPSW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCPSW.Validated += new System.EventHandler(this.txtCPSW_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(12, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Confirmez votre mot de passe :";
            // 
            // cb
            // 
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb.FormattingEnabled = true;
            this.cb.Items.AddRange(new object[] {
            "Administarteur",
            "User"});
            this.cb.Location = new System.Drawing.Point(321, 387);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(276, 31);
            this.cb.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(12, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Type d\'utilisateur :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(17, 486);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(237, 36);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Ajouter Utilisateur";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(360, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Annuler";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureANU
            // 
            this.pictureANU.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureANU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureANU.Image = global::Gestion_Ventes.Properties.Resources._47932;
            this.pictureANU.Location = new System.Drawing.Point(17, 486);
            this.pictureANU.Name = "pictureANU";
            this.pictureANU.Size = new System.Drawing.Size(47, 36);
            this.pictureANU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureANU.TabIndex = 20;
            this.pictureANU.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Gestion_Ventes.Properties.Resources.dialog_close1;
            this.pictureBox1.Location = new System.Drawing.Point(360, 486);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_ADD_USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gestion_Ventes.Properties.Resources.apple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 550);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureANU);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.txtCPSW);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomCom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomUti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ADD_USER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ADD_USER";
            ((System.ComponentModel.ISupportInitialize)(this.frm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimized)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureANU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox frm;
        private System.Windows.Forms.PictureBox minimized;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbclose;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureANU;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label labelAdd_Utili;
        public System.Windows.Forms.TextBox txtNomUti;
        public System.Windows.Forms.TextBox txtNomCom;
        public System.Windows.Forms.TextBox txtPsw;
        public System.Windows.Forms.TextBox txtCPSW;
        public System.Windows.Forms.ComboBox cb;
    }
}
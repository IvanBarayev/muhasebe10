﻿namespace Muhasebe
{
    partial class SifrePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifrePanel));
            this.btGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.chbSifre = new System.Windows.Forms.CheckBox();
            this.cbKAdi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btYeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btGiris
            // 
            this.btGiris.Enabled = false;
            this.btGiris.Location = new System.Drawing.Point(193, 163);
            this.btGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btGiris.Name = "btGiris";
            this.btGiris.Size = new System.Drawing.Size(100, 28);
            this.btGiris.TabIndex = 0;
            this.btGiris.Text = "Giriş";
            this.btGiris.UseVisualStyleBackColor = true;
            this.btGiris.Click += new System.EventHandler(this.btGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı :";
            // 
            // tbSifre
            // 
            this.tbSifre.Location = new System.Drawing.Point(85, 69);
            this.tbSifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(207, 22);
            this.tbSifre.TabIndex = 2;
            this.tbSifre.UseSystemPasswordChar = true;
            this.tbSifre.TextChanged += new System.EventHandler(this.tbSifre_TextChanged);
            // 
            // chbSifre
            // 
            this.chbSifre.AutoSize = true;
            this.chbSifre.Location = new System.Drawing.Point(85, 109);
            this.chbSifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbSifre.Name = "chbSifre";
            this.chbSifre.Size = new System.Drawing.Size(113, 21);
            this.chbSifre.TabIndex = 3;
            this.chbSifre.Text = "Şifreyi göster";
            this.chbSifre.UseVisualStyleBackColor = true;
            this.chbSifre.CheckedChanged += new System.EventHandler(this.chbSifre_CheckedChanged);
            // 
            // cbKAdi
            // 
            this.cbKAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbKAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKAdi.FormattingEnabled = true;
            this.cbKAdi.Location = new System.Drawing.Point(86, 22);
            this.cbKAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbKAdi.Name = "cbKAdi";
            this.cbKAdi.Size = new System.Drawing.Size(207, 24);
            this.cbKAdi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre       :";
            // 
            // btYeni
            // 
            this.btYeni.Location = new System.Drawing.Point(85, 163);
            this.btYeni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btYeni.Name = "btYeni";
            this.btYeni.Size = new System.Drawing.Size(100, 28);
            this.btYeni.TabIndex = 6;
            this.btYeni.Text = "Yeni";
            this.btYeni.UseVisualStyleBackColor = true;
            this.btYeni.Click += new System.EventHandler(this.btYeni_Click);
            // 
            // SifrePanel
            // 
            this.AcceptButton = this.btGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 305);
            this.Controls.Add(this.btYeni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbKAdi);
            this.Controls.Add(this.chbSifre);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btGiris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SifrePanel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Kullanıcı Girişi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SifrePanel_FormClosing);
            this.Load += new System.EventHandler(this.SifrePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.CheckBox chbSifre;
        private System.Windows.Forms.ComboBox cbKAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btYeni;
    }
}
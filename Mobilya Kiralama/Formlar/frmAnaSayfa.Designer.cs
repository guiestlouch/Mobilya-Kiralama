using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MobilyaKiralama
{
    partial class frmAnaSayfa
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
            this.btnMobilyaEkle = new System.Windows.Forms.Button();
            this.btnMobilyaListele = new System.Windows.Forms.Button();
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.btnKullaniciListele = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.btnYapilanSatislar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panelSayfalar = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMobilyaEkle
            // 
            this.btnMobilyaEkle.Location = new System.Drawing.Point(44, 12);
            this.btnMobilyaEkle.Name = "btnMobilyaEkle";
            this.btnMobilyaEkle.Size = new System.Drawing.Size(80, 60);
            this.btnMobilyaEkle.TabIndex = 0;
            this.btnMobilyaEkle.Text = "Mobilya Ekle";
            this.btnMobilyaEkle.UseVisualStyleBackColor = true;
            this.btnMobilyaEkle.Click += new System.EventHandler(this.btnMobilyaEkle_Click_1);
            // 
            // btnMobilyaListele
            // 
            this.btnMobilyaListele.Location = new System.Drawing.Point(130, 12);
            this.btnMobilyaListele.Name = "btnMobilyaListele";
            this.btnMobilyaListele.Size = new System.Drawing.Size(80, 60);
            this.btnMobilyaListele.TabIndex = 0;
            this.btnMobilyaListele.Text = "Mobilya Listele";
            this.btnMobilyaListele.UseVisualStyleBackColor = true;
            this.btnMobilyaListele.Click += new System.EventHandler(this.btnMobilyaListele_Click_1);
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Location = new System.Drawing.Point(216, 12);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(80, 60);
            this.btnKullaniciEkle.TabIndex = 0;
            this.btnKullaniciEkle.Text = "Kullanıcı Ekle";
            this.btnKullaniciEkle.UseVisualStyleBackColor = true;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click_1);
            // 
            // btnKullaniciListele
            // 
            this.btnKullaniciListele.Location = new System.Drawing.Point(302, 12);
            this.btnKullaniciListele.Name = "btnKullaniciListele";
            this.btnKullaniciListele.Size = new System.Drawing.Size(80, 60);
            this.btnKullaniciListele.TabIndex = 0;
            this.btnKullaniciListele.Text = "Kullanıcı Listele";
            this.btnKullaniciListele.UseVisualStyleBackColor = true;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(388, 12);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(80, 60);
            this.btnMusteriEkle.TabIndex = 0;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.Location = new System.Drawing.Point(474, 12);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Size = new System.Drawing.Size(80, 60);
            this.btnMusteriListele.TabIndex = 0;
            this.btnMusteriListele.Text = "Müşteri Listele";
            this.btnMusteriListele.UseVisualStyleBackColor = true;
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Location = new System.Drawing.Point(560, 12);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(80, 60);
            this.btnSatisYap.TabIndex = 0;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            // 
            // btnYapilanSatislar
            // 
            this.btnYapilanSatislar.Location = new System.Drawing.Point(646, 12);
            this.btnYapilanSatislar.Name = "btnYapilanSatislar";
            this.btnYapilanSatislar.Size = new System.Drawing.Size(80, 60);
            this.btnYapilanSatislar.TabIndex = 0;
            this.btnYapilanSatislar.Text = "Yapılan Satışlar";
            this.btnYapilanSatislar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMobilyaEkle);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnYapilanSatislar);
            this.panel1.Controls.Add(this.btnKullaniciEkle);
            this.panel1.Controls.Add(this.btnMusteriListele);
            this.panel1.Controls.Add(this.btnMobilyaListele);
            this.panel1.Controls.Add(this.btnSatisYap);
            this.panel1.Controls.Add(this.btnMusteriEkle);
            this.panel1.Controls.Add(this.btnKullaniciListele);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 112);
            this.panel1.TabIndex = 2;
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(732, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(80, 60);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // panelSayfalar
            // 
            this.panelSayfalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSayfalar.Location = new System.Drawing.Point(0, 112);
            this.panelSayfalar.Name = "panelSayfalar";
            this.panelSayfalar.Size = new System.Drawing.Size(846, 299);
            this.panelSayfalar.TabIndex = 3;
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(846, 411);
            this.Controls.Add(this.panelSayfalar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.IsMdiContainer = true;
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobilya Satış Otomasyonu Ana Sayfa";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnMobilyaEkle;
        private Button btnMobilyaListele;
        private Button btnKullaniciEkle;
        private Button btnKullaniciListele;
        private Button btnMusteriEkle;
        private Button btnMusteriListele;
        private Button btnSatisYap;
        private Button btnYapilanSatislar;
        private Panel panel1;
        private Panel panelSayfalar;
        private Button btnCikis;
    }
}
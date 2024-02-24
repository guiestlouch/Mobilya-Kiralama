using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MobilyaKiralama.Formlar
{
    partial class frmMobilyaEkle
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
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateGelis = new System.Windows.Forms.DateTimePicker();
            this.dateUretim = new System.Windows.Forms.DateTimePicker();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.txtBoyut = new System.Windows.Forms.TextBox();
            this.txtKDV = new System.Windows.Forms.TextBox();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.comboModel = new System.Windows.Forms.ComboBox();
            this.tBLModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mobilyaDataSet = new Mobilya_Kiralama.MobilyaDataSet();
            this.tBLModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.tBLMarkaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tBLMarkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mobilyaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLMarkaTableAdapter = new Mobilya_Kiralama.MobilyaDataSetTableAdapters.TBLMarkaTableAdapter();
            this.tBLModelTableAdapter = new Mobilya_Kiralama.MobilyaDataSetTableAdapters.TBLModelTableAdapter();
            this.txtSeriNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fKTBLModelTBLMarkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLMarkaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tBLModelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilyaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMarkaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMarkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilyaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTBLModelTBLMarkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMarkaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLModelBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(124, 290);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(86, 20);
            this.btnIptal.TabIndex = 27;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(31, 290);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(86, 20);
            this.btnEkle.TabIndex = 26;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(234, 113);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(69, 20);
            this.btnResimSec.TabIndex = 25;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(234, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 73);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Renk";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Geliş Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Model";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Satış Fiyatı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "KDV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Boyut";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Üretim Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Alış Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Marka";
            // 
            // dateGelis
            // 
            this.dateGelis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateGelis.Location = new System.Drawing.Point(106, 112);
            this.dateGelis.Name = "dateGelis";
            this.dateGelis.Size = new System.Drawing.Size(104, 20);
            this.dateGelis.TabIndex = 14;
            // 
            // dateUretim
            // 
            this.dateUretim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateUretim.Location = new System.Drawing.Point(106, 87);
            this.dateUretim.Name = "dateUretim";
            this.dateUretim.Size = new System.Drawing.Size(104, 20);
            this.dateUretim.TabIndex = 13;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(106, 212);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(104, 20);
            this.txtRenk.TabIndex = 12;
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(106, 162);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(104, 20);
            this.txtSatisFiyati.TabIndex = 11;
            // 
            // txtBoyut
            // 
            this.txtBoyut.Location = new System.Drawing.Point(106, 237);
            this.txtBoyut.Name = "txtBoyut";
            this.txtBoyut.Size = new System.Drawing.Size(104, 20);
            this.txtBoyut.TabIndex = 10;
            // 
            // txtKDV
            // 
            this.txtKDV.Location = new System.Drawing.Point(106, 187);
            this.txtKDV.Name = "txtKDV";
            this.txtKDV.Size = new System.Drawing.Size(104, 20);
            this.txtKDV.TabIndex = 9;
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(106, 137);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(104, 20);
            this.txtAlisFiyati.TabIndex = 8;
            // 
            // comboModel
            // 
            this.comboModel.DataSource = this.tBLModelBindingSource2;
            this.comboModel.DisplayMember = "Model";
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Location = new System.Drawing.Point(106, 60);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(104, 21);
            this.comboModel.TabIndex = 7;
            // 
            // tBLModelBindingSource1
            // 
            this.tBLModelBindingSource1.DataMember = "TBLModel";
            this.tBLModelBindingSource1.DataSource = this.mobilyaDataSet;
            // 
            // mobilyaDataSet
            // 
            this.mobilyaDataSet.DataSetName = "MobilyaDataSet";
            this.mobilyaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLModelBindingSource
            // 
            this.tBLModelBindingSource.DataMember = "TBLModel";
            this.tBLModelBindingSource.DataSource = this.mobilyaDataSet;
            // 
            // comboMarka
            // 
            this.comboMarka.DataSource = this.tBLMarkaBindingSource2;
            this.comboMarka.DisplayMember = "Marka";
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(106, 34);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(104, 21);
            this.comboMarka.TabIndex = 6;
            // 
            // tBLMarkaBindingSource1
            // 
            this.tBLMarkaBindingSource1.DataMember = "TBLMarka";
            this.tBLMarkaBindingSource1.DataSource = this.mobilyaDataSet;
            // 
            // tBLMarkaBindingSource
            // 
            this.tBLMarkaBindingSource.DataMember = "TBLMarka";
            this.tBLMarkaBindingSource.DataSource = this.mobilyaDataSet;
            // 
            // mobilyaDataSetBindingSource
            // 
            this.mobilyaDataSetBindingSource.DataSource = this.mobilyaDataSet;
            this.mobilyaDataSetBindingSource.Position = 0;
            // 
            // tBLMarkaTableAdapter
            // 
            this.tBLMarkaTableAdapter.ClearBeforeFill = true;
            // 
            // tBLModelTableAdapter
            // 
            this.tBLModelTableAdapter.ClearBeforeFill = true;
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Location = new System.Drawing.Point(106, 264);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(104, 20);
            this.txtSeriNo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Seri No";
            // 
            // fKTBLModelTBLMarkaBindingSource
            // 
            this.fKTBLModelTBLMarkaBindingSource.DataMember = "FK_TBLModel_TBLMarka";
            this.fKTBLModelTBLMarkaBindingSource.DataSource = this.tBLMarkaBindingSource;
            // 
            // tBLMarkaBindingSource2
            // 
            this.tBLMarkaBindingSource2.DataMember = "TBLMarka";
            this.tBLMarkaBindingSource2.DataSource = this.mobilyaDataSet;
            // 
            // tBLModelBindingSource2
            // 
            this.tBLModelBindingSource2.DataMember = "TBLModel";
            this.tBLModelBindingSource2.DataSource = this.mobilyaDataSet;
            // 
            // frmMobilyaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(322, 337);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateGelis);
            this.Controls.Add(this.dateUretim);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.txtBoyut);
            this.Controls.Add(this.txtKDV);
            this.Controls.Add(this.txtSeriNo);
            this.Controls.Add(this.txtAlisFiyati);
            this.Controls.Add(this.comboModel);
            this.Controls.Add(this.comboMarka);
            this.Name = "frmMobilyaEkle";
            this.Text = "Mobilya Ekleme Sayfası";
            this.Load += new System.EventHandler(this.frmMobilyaEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilyaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMarkaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMarkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilyaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTBLModelTBLMarkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMarkaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLModelBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnIptal;
        private Button btnEkle;
        private Button btnResimSec;
        private PictureBox pictureBox1;
        private Label label12;
        private Label label8;
        private Label label4;
        private Label label7;
        private Label label10;
        private Label label9;
        private Label label6;
        private Label label5;
        private Label label3;
        private DateTimePicker dateGelis;
        private DateTimePicker dateUretim;
        private TextBox txtRenk;
        private TextBox txtSatisFiyati;
        private TextBox txtBoyut;
        private TextBox txtKDV;
        private TextBox txtAlisFiyati;
        private ComboBox comboModel;
        private ComboBox comboMarka;
        private BindingSource mobilyaDataSetBindingSource;
        private Mobilya_Kiralama.MobilyaDataSet mobilyaDataSet;
        private BindingSource tBLMarkaBindingSource;
        private Mobilya_Kiralama.MobilyaDataSetTableAdapters.TBLMarkaTableAdapter tBLMarkaTableAdapter;
        private BindingSource tBLModelBindingSource;
        private Mobilya_Kiralama.MobilyaDataSetTableAdapters.TBLModelTableAdapter tBLModelTableAdapter;
        private BindingSource tBLModelBindingSource1;
        private BindingSource tBLMarkaBindingSource1;
        private TextBox txtSeriNo;
        private Label label1;
        private BindingSource fKTBLModelTBLMarkaBindingSource;
        private BindingSource tBLModelBindingSource2;
        private BindingSource tBLMarkaBindingSource2;
    }
}
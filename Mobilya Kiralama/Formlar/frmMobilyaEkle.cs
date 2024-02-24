using Mobilya_Kiralama.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilyaKiralama.Formlar
{
    public partial class frmMobilyaEkle : Form
    {
        public frmMobilyaEkle()
        {
            InitializeComponent();
        }


        private void frmMobilyaEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'mobilyaDataSet.TBLModel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLModelTableAdapter.Fill(this.mobilyaDataSet.TBLModel);
            // TODO: Bu kod satırı 'mobilyaDataSet.TBLMarka' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLMarkaTableAdapter.Fill(this.mobilyaDataSet.TBLMarka);

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            pictureBox1.ImageLocation = file.FileName;
        }
        Mobilyalar mob = new Mobilyalar();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into urun values('" + comboMarka.Text + "','" + comboModel.Text + "',@uretimtarihi,@alistarihi,@alisfiyati,@satisfiyati,'" + int.Parse(txtKDV.Text) + "','" + txtRenk + "','" + txtBoyut + "','" + pictureBox1.ImageLocation + "','" + txtSeriNo + "')";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@uretimtarihi", dateUretim.Value);
            komut2.Parameters.AddWithValue("@alistarihi", dateGelis.Value);
            komut2.Parameters.AddWithValue("@alisfiyati", double.Parse(txtAlisFiyati.Text));
            komut2.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatisFiyati.Text));
            mob.ESG(komut2, sorgu2, comboMarka, comboModel, dateUretim, dateGelis, txtAlisFiyati, txtSatisFiyati, txtKDV, txtRenk, txtBoyut, pictureBox1, txtSeriNo);
        }
    }
}
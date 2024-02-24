using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilyaKiralama
{
    public partial class frmKullaniciGiris : Form
    {
        public frmKullaniciGiris()
        {
            InitializeComponent();
        }

        private void frmKullaniciGiris_Load(object sender, EventArgs e)
        {

        }

        private void lblYeniKullanici_Click_1(object sender, EventArgs e)
        {
            frmYeniKullanici yk = new frmYeniKullanici();
            yk.ShowDialog();
        }

        Classlar.Kullanici k = new Classlar.Kullanici();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                txtSifre.UseSystemPasswordChar = true;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                txtSifre.UseSystemPasswordChar = false;
                checkBox1.Text = "Göster";
            }
        }


        private void btnGiris_Click(object sender, EventArgs e)
        {
            k.KullaniciGirisi(txtSifre, txtKullaniciAdi);
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
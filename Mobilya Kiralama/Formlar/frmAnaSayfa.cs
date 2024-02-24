using MobilyaKiralama.Formlar;
using System.Windows.Forms;
using System;

namespace MobilyaKiralama
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }
        private void FormGetir(Form frm)
        {
            panelSayfalar.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Left;
            panelSayfalar.Controls.Add(frm);
            frm.Show();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnMobilyaEkle_Click_1(object sender, EventArgs e)
        {
            Formlar.frmMobilyaEkle mobekle = new Formlar.frmMobilyaEkle();
            FormGetir(mobekle);
        }

        private void btnMobilyaListele_Click_1(object sender, EventArgs e)
        {
            Formlar.frmMobilyaListele moblistele = new Formlar.frmMobilyaListele();
            FormGetir(moblistele);
        }

        private void btnKullaniciEkle_Click_1(object sender, EventArgs e)
        {
            frmYeniKullanici yeni = new frmYeniKullanici();
            FormGetir(yeni);
        }
    }
}
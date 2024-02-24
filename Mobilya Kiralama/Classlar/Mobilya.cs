using MobilyaKiralama.Classlar;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobilya_Kiralama.Classlar
{
    internal class Mobilyalar
    {
        SqlConnection baglanti = new SqlConnection(Veritabani.strbaglanti);
        public int ESG(SqlCommand komut, string sorgu, ComboBox marka, ComboBox model, DateTimePicker dateuretim, DateTimePicker dategelis, TextBox alisfiyati, TextBox satisfiyati, TextBox KDV, TextBox renk, TextBox boyut, PictureBox resim, TextBox serino)
        {
            int sonuc = 0;
            komut.CommandText = sorgu;
            komut.Connection = baglanti;
            if (baglanti.State == System.Data.ConnectionState.Closed)
                baglanti.Open();
            try
            {
                sonuc = komut.ExecuteNonQuery();
                MessageBox.Show("işlem başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                string hata = ex.Message;
            }
            finally
            {
                baglanti.Close();
            }

            return sonuc;
        }
    }
}

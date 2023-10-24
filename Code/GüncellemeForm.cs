using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veritabanı_Ödev
{
    public partial class GüncellemeForm : Form
    {
        public GüncellemeForm()
        {
            InitializeComponent();
        }

        // Veritabanı ile bağlantı kuruluyor.
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port=5432; Database=DersBilgileri; user ID=postgres; password=1234");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Tabloyu gösteren kısım.
        private void listeyiGösterBtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from dersbilgileri order by dönemi";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            listeyiGosterDgw.DataSource = ds.Tables[0];
        }

        // Tablo içinde girilen privatekey(derskodu) veriyi günceller önce veriyi siler daha sonra yeni girilen bilgiler ile tekrar ekler.
        private void GüncelleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete From dersbilgileri where derskodu=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", GüncellenecekDersKoduTxt.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into dersbilgileri (derskodu,dersadi,derskredisi,akts,dersinhocasi,dönemi,harfnotu) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
            komut1.Parameters.AddWithValue("@p1", DersKoduTxt.Text);
            komut1.Parameters.AddWithValue("@p2", DersAdiTxt.Text);
            komut1.Parameters.AddWithValue("@p3", Convert.ToInt32(DersKredisiTxt.Text));
            komut1.Parameters.AddWithValue("@p4", Convert.ToInt32(AktsTxt.Text));
            komut1.Parameters.AddWithValue("@p5", DersinHocasıTxt.Text);
            komut1.Parameters.AddWithValue("@p6", DonemiTxt.Text);
            //komut1.Parameters.AddWithValue("@p7","AA");
            if (DerstenAldığıNotTxt.Text == "")
                komut1.Parameters.AddWithValue("@p7", "");
            else if (Convert.ToInt32(DerstenAldığıNotTxt.Text) >= 90)
                komut1.Parameters.AddWithValue("@p7", "AA");
            else if (Convert.ToInt32(DerstenAldığıNotTxt.Text) >= 85)
                komut1.Parameters.AddWithValue("@p7", "BA");
            else if (Convert.ToInt32(DerstenAldığıNotTxt.Text) >= 80)
                komut1.Parameters.AddWithValue("@p7", "BB");
            else if (Convert.ToInt32(DerstenAldığıNotTxt.Text) >= 75)
                komut1.Parameters.AddWithValue("@p7", "CB");
            else if (Convert.ToInt32(DerstenAldığıNotTxt.Text) >= 60)
                komut1.Parameters.AddWithValue("@p7", "CC");
            else if (Convert.ToInt32(DerstenAldığıNotTxt.Text) >= 55)
                komut1.Parameters.AddWithValue("@p7", "DC");
            else if (Convert.ToInt32(DerstenAldığıNotTxt.Text) >= 50)
                komut1.Parameters.AddWithValue("@p7", "DD");
            else if (Convert.ToInt32(DerstenAldığıNotTxt.Text) < 50)
                komut1.Parameters.AddWithValue("@p7", "FF");
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme Başarılı");

        }

        private void eklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();  
            f.Show();
            this.Close();
        }

        private void silmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SilmeForm sf = new SilmeForm();
            sf.Show();
            this.Close();
        }

        private void transkriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeForm lf = new ListeForm();
            lf.Show();
            this.Close();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

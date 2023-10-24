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
    public partial class SilmeForm : Form
    {
        public SilmeForm()
        {
            InitializeComponent();
        }
        // Veritabanı ile bağlantı kuruluyor.
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port=5432; Database=DersBilgileri; user ID=postgres; password=1234");

        //Tablodan silme işlemi yapılan kısım.
        private void SilBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete From dersbilgileri where derskodu=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", SilinecekDersinKoduTxt.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme başarlı");
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

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GüncellemeForm gf = new GüncellemeForm();
            gf.Show();
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

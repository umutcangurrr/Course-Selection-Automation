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
    public partial class ListeForm : Form
    {
        public ListeForm()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port=5432; Database=DersBilgileri; user ID=postgres; password=1234");
        private void ListeleBtn_Click(object sender, EventArgs e)
        {
            //Transkript tablosunda sadece derskodu, dersadi, derskredisi, harfnotu ve bunların dönemine göre gösterilmesi için yazılan sorgu.
            string sorgu = "select derskodu,dersadi,derskredisi,harfnotu from dersbilgileri where harfnotu != '' order by dönemi";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ListeDgw.DataSource = ds.Tables[0];

           double pay = 0;
            
            // dgw içindeki belirli kolonlardan veri çekerek gano hesaplama kısmının dersin kredisi*dersin notu kısmını yapar
            for (int i = 0; i < ListeDgw.Rows.Count; i++)
            {
                if (Convert.ToString(ListeDgw.Rows[i].Cells[3].Value) == "AA")
                    pay += (Convert.ToDouble(ListeDgw.Rows[i].Cells[2].Value)) * 4;

                else if (Convert.ToString(ListeDgw.Rows[i].Cells[3].Value) == "BA")
                    pay += (Convert.ToDouble(ListeDgw.Rows[i].Cells[2].Value)) * 3.5;

                else if (Convert.ToString(ListeDgw.Rows[i].Cells[3].Value) == "BB")
                    pay += (Convert.ToDouble(ListeDgw.Rows[i].Cells[2].Value)) * 3;

                else if (Convert.ToString(ListeDgw.Rows[i].Cells[3].Value) == "CB")
                    pay += (Convert.ToDouble(ListeDgw.Rows[i].Cells[2].Value)) * 2.5;

                else if (Convert.ToString(ListeDgw.Rows[i].Cells[3].Value) == "CC")
                    pay += (Convert.ToDouble(ListeDgw.Rows[i].Cells[2].Value)) * 2;

                else if (Convert.ToString(ListeDgw.Rows[i].Cells[3].Value) == "DC")
                    pay += (Convert.ToDouble(ListeDgw.Rows[i].Cells[2].Value)) * 1.5;
                else if (Convert.ToString(ListeDgw.Rows[i].Cells[3].Value) == "DD")
                    pay += (Convert.ToDouble(ListeDgw.Rows[i].Cells[2].Value)) * 1;

                else if (Convert.ToString(ListeDgw.Rows[i].Cells[3].Value) == "FF")
                    pay += (Convert.ToDouble(ListeDgw.Rows[i].Cells[2].Value)) * 0;
            }

            double payda = 0;
            // dgw içindeki belirli kolonlardan veri çekerek gano hesaplama kısmının toplam kredi kısmını yapar
            for (int i = 0; i < ListeDgw.Rows.Count; i++)
            {
                payda += Convert.ToDouble(ListeDgw.Rows[i].Cells[2].Value);
            }


            double gano = pay / payda;

            ganoTxt.Text = Convert.ToString(gano);



        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GüncellemeForm gf = new GüncellemeForm();
            gf.Show();
            this.Close();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

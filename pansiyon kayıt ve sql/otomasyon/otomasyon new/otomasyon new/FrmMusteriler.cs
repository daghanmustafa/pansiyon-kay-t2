using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace otomasyon_new
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SBG9EFS;Initial Catalog=DAĞHAN PANSİYON;Integrated Security=True");
                                                   
        private void verilergoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *  from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
                 
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilergoster();
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {

        }
        int id = 0;

        public object ListView1 { get; private set; }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            Txtadi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            Txtsoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtKimlikNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirişTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpcikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriid=("+id+")",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Txtadi.Clear();
            Txtsoyadi.Clear();
            comboBox1.Text = "";
            TxtMail.Text = "";
            TxtKimlikNo.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpcikisTarihi.Text = "";
            DtpGirişTarihi.Text = "";
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set Adi='"+Txtadi.Text+"',Soyadi='"+Txtsoyadi.Text+"',Cinsiyet='"+comboBox1.Text+"',Telefon='"+MskTxtTelefon.Text+"','"+TxtMail.Text+"','"+TxtKimlikNo.Text+"','"+TxtUcret.Text+"',GirişTarihi='"+DtpGirişTarihi.Value.ToString("yyyy-MM-dd")+"',cikisTarihi='"+DtpcikisTarihi.Value.ToString("yyyy-MM-dd") + "'  where Musteriid="+id+"",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem ekle = new ListViewItem();
            ekle.Text = oku["Musteriid"].ToString();
            ekle.SubItems.Add(oku["Adi"].ToString());
            ekle.SubItems.Add(oku["Soyadi"].ToString());
            ekle.SubItems.Add(oku["Cinsiyet"].ToString());
            ekle.SubItems.Add(oku["Telefon"].ToString());
            ekle.SubItems.Add(oku["Mail"].ToString());
            ekle.SubItems.Add(oku["TC"].ToString());
            ekle.SubItems.Add(oku["OdaNo"].ToString());
            ekle.SubItems.Add(oku["Ucret"].ToString());
            ekle.SubItems.Add(oku["GirisTarihi"].ToString());
            ekle.SubItems.Add(oku["CikisTarihi"].ToString());
            listView1.Items.Add(ekle);
        }
        baglanti.Close();
        }
    }
}

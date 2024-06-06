using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace kirtasiye_otomasyonu
{
    public partial class Form8 : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=SKIP60\\SQLEXPRESS; Initial Catalog=kitasiye; Integrated Security =TRUE");
        //yukarıdaki de bağlantı
        SqlDataAdapter dataAdapter;//sorgu çalıştır
        DataTable dataTable;//datateble
        string query;//sorgu
        private void veri_getir()
        {
            dataAdapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();

            connection.Open();
            dataAdapter.Fill(dataTable);
            connection.Close();

            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["id"].Visible = false;//id dataGridView1 kaldırıyor
            for (int i = 0; i < dataTable.Rows.Count; i++)// no sayıyor
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public Form8()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form5 myform = new Form5();//buton 2 basılınca form 5 gidiyor
            myform.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // dataGridView1 de tüm satrırı seçmene yardımcı olur
            dataGridView1.ReadOnly = true;//dataGridView1 sadece okunabilen bir tablo haline geldi
            dataGridView1.Columns.Add("SNo", "No");
            query = "SELECT * FROM urunler"; // Ürünler tablosunu 
            veri_getir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 myform = new Form3();
            myform.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM urunler WHERE UrunAdi like'" + textBox1.Text + "%'";//ürün arama yeri textbox'a ne yazarsan o ürün aranır
            veri_getir();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM urunler";//tüm ürünleri getirir
            veri_getir();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM urunler ORDER BY Stok ASC";//En Az Olan Ürün getiri
            veri_getir();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM urunler ORDER BY Stok DESC";//En Fazla Olan Ürün getiri
            veri_getir();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 myform = new Form6();
            myform.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form11 frm=new Form11();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form12 frm = new Form12();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 myform = new Form1();
            myform.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 myform = new Form7();
            myform.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 myform = new Form9();
            myform.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

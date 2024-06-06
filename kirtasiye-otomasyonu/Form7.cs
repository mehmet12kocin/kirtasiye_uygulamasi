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
using System.Data.SqlClient;

namespace kirtasiye_otomasyonu
{
    public partial class Form7 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=SKIP60\\SQLEXPRESS; Initial Catalog=kitasiye; Integrated Security =TRUE");
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        string query;
        string squery;
        public Form7()
        {
            InitializeComponent();
        }
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

        private void veri_sil()
        {
            dataAdapter = new SqlDataAdapter(squery, connection);
            dataTable = new DataTable();

            connection.Open();
            dataAdapter.Fill(dataTable);
            connection.Close();

            dataGridView1.DataSource = dataTable;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // dataGridView1 de tum satriri seçmene yardımcı olur
            dataGridView1.ReadOnly = true;//dataGridView1 sadece okunabilen bir tablo haline geldi
            dataGridView1.Columns.Add("SNo", "No");
            query = "SELECT * FROM toplancilar";
            veri_getir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 myform = new Form8();
            myform.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM toplancilar WHERE DukanAdı like'" + textBox1.Text + "%'";
            veri_getir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Veriyi silmeye eminmisin", "Toptancıyı Sil", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
                    squery = "DELETE FROM toplancilar WHERE id=" + id;
                    veri_sil();
                    veri_getir();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

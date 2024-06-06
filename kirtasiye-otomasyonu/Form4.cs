using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kirtasiye_otomasyonu
{
    public partial class Form4 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=SKIP60\\SQLEXPRESS; Initial Catalog=kitasiye; Integrated Security =TRUE");
        SqlDataAdapter dataAdapter;
        DataTable dataTable;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;//dataGridView1 sadece okunabilen bir tablo haline geldi
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            button1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
        double fiyat, miktar, topfiyat;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }
            else
            {
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox2.Clear();
                textBox4.Clear();
                textBox5.Clear();

            }
            string barkod = textBox1.Text;

            try
            {
                connection.Open();
                // Veritabanından ürün bilgilerini çekme
                string query = "SELECT UrunAdi,Fiyat FROM Urunler WHERE Barkod = @Barkod";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Barkod", barkod);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Ürün bilgilerini TextBox'lara yerleştirme
                        textBox2.Text = reader.GetString(0);
                        textBox4.Text = reader.GetString(1).ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Eğer girilen karakter bir sayı değilse ve kontrol karakteri de değilse, o karakterin TextBox'a eklenmesini engelle
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double s1, s2, s3;
            s1 = Convert.ToDouble(textBox3.Text);
            s2 = Convert.ToDouble(textBox4.Text);
            s3 = s1 * s2;
            textBox5.Text = s3.ToString();
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "1";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            button1.Enabled = false;
        }
    }
}

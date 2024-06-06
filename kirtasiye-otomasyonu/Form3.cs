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

namespace kirtasiye_otomasyonu
{
    public partial class Form3 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=SKIP60\\SQLEXPRESS; Initial Catalog=kitasiye; Integrated Security =TRUE");

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""||textBox2.Text == ""||textBox3.Text == ""||textBox4.Text == ""||textBox5.Text=="")
            {
                MessageBox.Show("Lütfen bütün yerleri doldurun","Boş Yer Bıraktınız");
            }
            else 
            { 
            string query = "INSERT INTO Kulanici (TcNO,ad,soyad,username,password) VALUES (@TcNO,@ad,@soyad,@username, @password)";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ad", textBox1.Text); // label1.Text'ten ad değerini alıyoruz
            command.Parameters.AddWithValue("@soyad", textBox2.Text); // label2.Text'ten soyad değerini alıyoruz
            command.Parameters.AddWithValue("@TcNO", textBox5.Text);
            command.Parameters.AddWithValue("@username", textBox3.Text);
            command.Parameters.AddWithValue("@password", textBox4.Text);

            try
            {
                connection.Open();
                command.ExecuteNonQuery(); // Veritabanına ekleme işlemi

                DialogResult result = MessageBox.Show("Veri tabanına eklendi", "Veri Ekleme", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Form8 form = new Form8();
                form.Show();
                this.Hide();
            }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Show();
            this.Hide();
        }
    }
}

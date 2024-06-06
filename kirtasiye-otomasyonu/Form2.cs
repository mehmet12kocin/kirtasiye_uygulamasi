using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace kirtasiye_otomasyonu
{
    public partial class Form2 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=SKIP60\\SQLEXPRESS; Initial Catalog=kitasiye; Integrated Security =TRUE");
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || richTextBox1.Text == "")
            {
                MessageBox.Show("Lütfen bütün yerleri doldurun", "Boş Yer Bıraktınız");
            }
            else
            {
                string query = "INSERT INTO toplancilar (DukanAdı,TelNo,NeAldigimiz,Adresi) VALUES (@dukanadı,@telno,@aldıgımız,@adres)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@dukanadı", textBox1.Text); // label1.Text'ten ad değerini alıyoruz
                command.Parameters.AddWithValue("@telno", textBox2.Text); // label2.Text'ten soyad değerini alıyoruz
                command.Parameters.AddWithValue("@aldıgımız", textBox3.Text);
                command.Parameters.AddWithValue("@adres", richTextBox1.Text);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery(); // Veritabanına ekleme işlemi

                    MessageBox.Show("Veritabanına Eklendi");
                    Form7 form = new Form7();
                    form.Show();
                    this.Hide();
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
            Form7 myform = new Form7();
            myform.Show();
            this.Hide();
        }
    }
}

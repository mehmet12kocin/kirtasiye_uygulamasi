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
    public partial class Form11 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=SKIP60\\SQLEXPRESS; Initial Catalog=kitasiye; Integrated Security =TRUE");
        //yukarıdaki de bağlantı
        SqlDataAdapter dataAdapter;//sorgu çalıştır
        DataTable dataTable;//datateble
        string query;//sorgu
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO kategori (kategori) VALUES (@kategori)";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@kategori", textBox1.Text);

            try
            {
                connection.Open();
                command.ExecuteNonQuery(); //veri tanabanina ekleme
                DialogResult result = MessageBox.Show("Kategori Eklendi.", "ekleme işlemi", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    textBox1.Text = "";

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

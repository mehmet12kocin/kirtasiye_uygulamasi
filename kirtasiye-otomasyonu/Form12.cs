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

    public partial class Form12 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=SKIP60\\SQLEXPRESS; Initial Catalog=kitasiye; Integrated Security =TRUE");
        //yukarıdaki de bağlantı
        SqlDataAdapter dataAdapter;//sorgu çalıştır
        DataTable dataTable;//datateble
        string query;//sorgu
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load_1(object sender, EventArgs e)
        {
            string query = "SELECT k_id, kategori FROM kategori";

            // Bağlantıyı aç
            connection.Open();

            // Komut oluştur
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                // Verileri oku
                SqlDataReader reader = command.ExecuteReader();

                // ComboBox'a verileri ekle
                while (reader.Read())
                {
                    int kategoriId = reader.GetInt32(0);
                    string kategoriAdi = reader.GetString(1);

                    // ComboBox'a kategori adını ekle
                    comboBox1.Items.Add(kategoriAdi);

                    // ComboBox'taki öğelerin ValueMember'ına kategori ID'sini ekle
                    comboBox1.ValueMember = "k_id";
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda işle
                MessageBox.Show("Veri okuma hatası: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex != -1)
            {
                string selectedText = comboBox1.Text;
                query = "INSERT INTO markalar (kategori, Marka) VALUES (@kategori, @marka)";
                SqlCommand command = new SqlCommand(query, connection);

                
                
                
                    command.Parameters.AddWithValue("@marka", textBox1.Text);
                    command.Parameters.AddWithValue("@kategori", selectedText);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery(); // Veritabanına ekleme
                        DialogResult result = MessageBox.Show("Marka Eklendi.", "Marka Ekleme İşlemi", MessageBoxButtons.OK);
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
            else
            {
                MessageBox.Show("Lütfen bir kategori seçin.");
            }
        }
    }
}

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
using System.Collections;

namespace kirtasiye_otomasyonu
{
    public partial class Form6 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=SKIP60\\SQLEXPRESS; Initial Catalog=kitasiye; Integrated Security =TRUE");
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "UPDATE urunler SET UrunAdi =@urunad, Marka =@marka, Kategori =@kategori,Fiyat =@fiyat, Raf =@raf,Stok=@stok where Barkod =@barkod";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@urunad", textBox14.Text);
            command.Parameters.AddWithValue("@marka", textBox13.Text);
            command.Parameters.AddWithValue("@kategori", textBox11.Text);
            command.Parameters.AddWithValue("@barkod", textBox9.Text);
            command.Parameters.AddWithValue("@fiyat", textBox12.Text);
            command.Parameters.AddWithValue("@raf", textBox10.Text);
            //label degeri sayı yaptım burda
            int labelDeger = int.Parse(label15.Text);
            int textBoxDeger = int.Parse(textBox8.Text);
            int ekle = labelDeger + textBoxDeger;

            command.Parameters.AddWithValue("@stok", ekle);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                DialogResult result = MessageBox.Show("Ürün Güncelendi.");
                if (result == DialogResult.OK)
                {

                    textBox14.Text = "";
                    textBox13.Text = "";
                    textBox11.Text = "";
                    textBox12.Text = "";
                    textBox10.Text = "";
                    label15.Text = "";
                    textBox8.Text = "0";
                    label15.Text = "0";
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
            textBox9.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 myform = new Form8();
            myform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.SelectedItem == null || comboBox1.SelectedItem == null || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Lütfen bütün yerleri doldurun", "Boş Yer Bıraktınız");
            }
            else
            {
                string query = "INSERT INTO urunler (UrunAdi,Marka,Kategori,Barkod,Fiyat,Raf,Stok) VALUES (@urunad,@marka,@kategori,@barkod,@fiyat,@raf,@stok)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@urunad", textBox1.Text);
                command.Parameters.AddWithValue("@marka", comboBox2.SelectedItem);
                command.Parameters.AddWithValue("@kategori", comboBox1.SelectedItem);
                command.Parameters.AddWithValue("@barkod", textBox4.Text);
                command.Parameters.AddWithValue("@fiyat", textBox5.Text);
                command.Parameters.AddWithValue("@raf", textBox6.Text);
                command.Parameters.AddWithValue("@stok", textBox7.Text);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery(); //veri tanabanina ekleme
                    DialogResult result = MessageBox.Show("Ürün Eklendi.", "ekleme işlemi", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {

                        textBox4.Text = "";
                        textBox1.Text = "";
                        comboBox1.Items.Clear();
                        comboBox2.Items.Clear();
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox14.Text = "";
            textBox13.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox10.Text = "";
            label15.Text = "";
            textBox8.Text = "0";
            label15.Text = "0";
            // burayı ChatGTP den aldım 
            string barkod = textBox9.Text;

            try
            {
                connection.Open();
                // Veritabanından ürün bilgilerini çekme
                string query = "SELECT UrunAdi, Marka, Kategori, Fiyat, Raf, Stok FROM Urunler WHERE Barkod = @Barkod";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Barkod", barkod);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Ürün bilgilerini TextBox'lara yerleştirme
                        textBox14.Text = reader.GetString(0);
                        textBox13.Text = reader.GetString(1);
                        textBox11.Text = reader.GetString(2);
                        textBox12.Text = reader.GetString(3);
                        textBox10.Text = reader.GetString(4);
                        label15.Text = reader.GetInt32(5).ToString();
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

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string query = "SELECT kategori FROM kategori";

            try
            {
                // Bağlantıyı aç
                connection.Open();

                // Komut oluştur
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // ComboBox2'ye verileri ekle
                    while (reader.Read())
                    {
                        string kategoriAdi = reader.GetString(0); // 0 indeksli sütunu okuyun
                        comboBox2.Items.Add(kategoriAdi);
                    }
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

            // ComboBox2'de seçilen öğe değiştiğinde çalışacak olayı tanımlayın
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen kategoriyi al
            string selectedCategory = comboBox2.SelectedItem.ToString();

            // ComboBox1'i temizle
            comboBox1.Items.Clear();

            string query1 = "SELECT marka FROM markalar WHERE kategori = @kategori";

            try
            {
                // Bağlantıyı aç
                connection.Open();

                // Komut oluştur
                SqlCommand command1 = new SqlCommand(query1, connection);
                command1.Parameters.AddWithValue("@kategori", selectedCategory);

                using (SqlDataReader reader1 = command1.ExecuteReader())
                {
                    // ComboBox1'e verileri ekle
                    while (reader1.Read())
                    {
                        string marka = reader1.GetString(0); // 0 indeksli sütunu okuyun
                        comboBox1.Items.Add(marka);
                    }
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
    }
}

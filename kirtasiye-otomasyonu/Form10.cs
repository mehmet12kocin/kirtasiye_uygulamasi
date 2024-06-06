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
    public partial class Form10 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=SKIP60\\SQLEXPRESS; Initial Catalog=kitasiye; Integrated Security =TRUE");
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        string query;
        string squery;

        public Form10()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            textBox7.Enabled = false;
            dataGridView1.Columns.Add("SNo", "No");
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // dataGridView1 de tum satriri seçmene yardımcı olur
            dataGridView1.ReadOnly = true;//dataGridView1 sadece okunabilen bir tablo haline geldi
            query = "SELECT * FROM Kulanici "; // Kullanıcı tablosunu seçmelisiniz
            veri_getir();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM Kulanici WHERE ad like'" + textBox1.Text + "%'";
            veri_getir();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                textBox7.Text = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells["ad"].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells["soyad"].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells["TcNO"].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells["username"].Value.ToString();
                textBox6.Text = dataGridView1.SelectedRows[0].Cells["password"].Value.ToString();
            }
            catch
            {


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string query = "UPDATE Kulanici SET ad = @ad, soyad = @soyad, TcNO = @TcNO, username = @username, password = @password WHERE id=@id";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", textBox7.Text);
            command.Parameters.AddWithValue("@ad", textBox2.Text);
            command.Parameters.AddWithValue("@soyad", textBox3.Text);
            command.Parameters.AddWithValue("@TcNO", textBox4.Text);
            command.Parameters.AddWithValue("@username", textBox5.Text);
            command.Parameters.AddWithValue("@password", textBox6.Text);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                DialogResult result = MessageBox.Show("Kullanıcı güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            query = "SELECT * FROM Kulanici ";
            veri_getir();

        }
    }
}

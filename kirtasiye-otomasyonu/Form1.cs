using System.Data.SqlClient;
using System.Data.OleDb;

namespace kirtasiye_otomasyonu
{
    public partial class Form1 : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=SKIP60\\SQLEXPRESS; Initial Catalog=kitasiye; Integrated Security =TRUE");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string pass = textBox2.Text;

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Kulanici WHERE  username= @username AND password = @password", connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", pass);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string retrievedUsername = reader["id"].ToString().TrimEnd();

                    if (retrievedUsername == "1")
                    {
                        Form8 myform = new Form8();
                        myform.Show();
                        this.Hide();
                    }
                    else
                    {
                        Form4 form = new Form4();
                        form.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Böyle Bir Kulanýcý Bulunamadý","Hatalý Giriþ");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Formu kapatmak istiyor musunuz?", "Çýkýþ Ýþlemi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
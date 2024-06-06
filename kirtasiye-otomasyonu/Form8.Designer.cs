namespace kirtasiye_otomasyonu
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 220);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(950, 309);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(31, 23);
            button1.Name = "button1";
            button1.Size = new Size(155, 65);
            button1.TabIndex = 1;
            button1.Text = "Kulanıcı Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(192, 23);
            button2.Name = "button2";
            button2.Size = new Size(155, 65);
            button2.TabIndex = 1;
            button2.Text = "Kulanıcı Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(31, 94);
            button3.Name = "button3";
            button3.Size = new Size(155, 65);
            button3.TabIndex = 1;
            button3.Text = "Ürün Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(514, 23);
            button4.Name = "button4";
            button4.Size = new Size(155, 65);
            button4.TabIndex = 1;
            button4.Text = "Kategori Ekle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(675, 23);
            button5.Name = "button5";
            button5.Size = new Size(155, 65);
            button5.TabIndex = 1;
            button5.Text = "Marka Ekle";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(836, 23);
            button6.Name = "button6";
            button6.Size = new Size(145, 65);
            button6.TabIndex = 1;
            button6.Text = "Çıkış Yap";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(353, 23);
            button7.Name = "button7";
            button7.Size = new Size(155, 65);
            button7.TabIndex = 1;
            button7.Text = "Toptancılar";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 179);
            label1.Name = "label1";
            label1.Size = new Size(116, 31);
            label1.TabIndex = 2;
            label1.Text = "Ürün Ara :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(153, 176);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 38);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(802, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(179, 117);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(15, 82);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(153, 24);
            radioButton3.TabIndex = 0;
            radioButton3.Text = "En Fazla Olan Ürün";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(15, 52);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(137, 24);
            radioButton2.TabIndex = 0;
            radioButton2.Text = "En Az Olan Ürün";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(15, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(111, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tüm Ürünler";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(192, 94);
            button8.Name = "button8";
            button8.Size = new Size(155, 65);
            button8.TabIndex = 1;
            button8.Text = "Ürün Sil";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 530);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button8);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button7);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form8";
            Text = "Admin ";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button8;
    }
}
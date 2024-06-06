namespace kirtasiye_otomasyonu
{
    partial class Form3
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(422, 58);
            label1.Name = "label1";
            label1.Size = new Size(54, 31);
            label1.TabIndex = 0;
            label1.Text = "Ad :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(482, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 38);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(389, 102);
            label2.Name = "label2";
            label2.Size = new Size(87, 31);
            label2.TabIndex = 0;
            label2.Text = "Soyad :";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(482, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 38);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(324, 190);
            label3.Name = "label3";
            label3.Size = new Size(152, 31);
            label3.TabIndex = 0;
            label3.Text = "Kullanıcı Adı :";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(482, 187);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(189, 38);
            textBox3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(406, 234);
            label4.Name = "label4";
            label4.Size = new Size(70, 31);
            label4.TabIndex = 0;
            label4.Text = "Şifre :";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(482, 231);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(189, 38);
            textBox4.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(555, 309);
            button1.Name = "button1";
            button1.Size = new Size(148, 60);
            button1.TabIndex = 2;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(401, 309);
            button2.Name = "button2";
            button2.Size = new Size(148, 60);
            button2.TabIndex = 2;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(390, 146);
            label5.Name = "label5";
            label5.Size = new Size(86, 31);
            label5.TabIndex = 0;
            label5.Text = "TC No :";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(482, 143);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(189, 38);
            textBox5.TabIndex = 1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 530);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Kullanıcı Ekle";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Label label5;
        private TextBox textBox5;
    }
}
namespace kirtasiye_otomasyonu
{
    partial class Form2
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
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(276, 202);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(315, 240);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(276, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 38);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(120, 73);
            label1.Name = "label1";
            label1.Size = new Size(150, 31);
            label1.TabIndex = 2;
            label1.Text = "Dükanın Adı :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(90, 205);
            label2.Name = "label2";
            label2.Size = new Size(180, 31);
            label2.TabIndex = 2;
            label2.Text = "Dükanın Adresi :";
            label2.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(276, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 38);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(136, 117);
            label3.Name = "label3";
            label3.Size = new Size(134, 31);
            label3.TabIndex = 2;
            label3.Text = "Telefon No :";
            label3.Click += label1_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(276, 158);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(243, 38);
            textBox3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(73, 161);
            label4.Name = "label4";
            label4.Size = new Size(197, 31);
            label4.TabIndex = 2;
            label4.Text = "Ne(ler) Aldığımız :";
            label4.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(760, 181);
            button1.Name = "button1";
            button1.Size = new Size(176, 78);
            button1.TabIndex = 3;
            button1.Text = "Toptancı Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(525, 126);
            label5.Name = "label5";
            label5.Size = new Size(143, 20);
            label5.TabIndex = 4;
            label5.Text = "5** *** ** ** Şeklinde";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(760, 274);
            button2.Name = "button2";
            button2.Size = new Size(176, 78);
            button2.TabIndex = 3;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 530);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Name = "Form2";
            Text = "Toptancı Ekle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Button button1;
        private Label label5;
        private Button button2;
    }
}
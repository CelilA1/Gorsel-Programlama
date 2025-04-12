namespace Ödev3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button_Temizle = new Button();
            button_Goster = new Button();
            textBox_DogumTarihi = new TextBox();
            button_Kaydet = new Button();
            textBox_Kilo = new TextBox();
            textBox_Boy = new TextBox();
            textBox_Soyad = new TextBox();
            textBox_Ad = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            pictureBox_BurcResim = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_BurcResim).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MidnightBlue;
            groupBox1.Controls.Add(button_Temizle);
            groupBox1.Controls.Add(button_Goster);
            groupBox1.Controls.Add(textBox_DogumTarihi);
            groupBox1.Controls.Add(button_Kaydet);
            groupBox1.Controls.Add(textBox_Kilo);
            groupBox1.Controls.Add(textBox_Boy);
            groupBox1.Controls.Add(textBox_Soyad);
            groupBox1.Controls.Add(textBox_Ad);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(581, 342);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişisel Bilgiler";
            // 
            // button_Temizle
            // 
            button_Temizle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button_Temizle.ForeColor = Color.Black;
            button_Temizle.Location = new Point(365, 268);
            button_Temizle.Name = "button_Temizle";
            button_Temizle.Size = new Size(173, 56);
            button_Temizle.TabIndex = 14;
            button_Temizle.Text = "Temizle";
            button_Temizle.UseVisualStyleBackColor = true;
            button_Temizle.Click += button_Temizle_Click;
            // 
            // button_Goster
            // 
            button_Goster.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button_Goster.ForeColor = Color.Black;
            button_Goster.Location = new Point(177, 268);
            button_Goster.Name = "button_Goster";
            button_Goster.Size = new Size(173, 56);
            button_Goster.TabIndex = 13;
            button_Goster.Text = "Göster";
            button_Goster.UseVisualStyleBackColor = true;
            button_Goster.Click += button_Goster_Click;
            // 
            // textBox_DogumTarihi
            // 
            textBox_DogumTarihi.Location = new Point(177, 204);
            textBox_DogumTarihi.Name = "textBox_DogumTarihi";
            textBox_DogumTarihi.Size = new Size(173, 34);
            textBox_DogumTarihi.TabIndex = 12;
            // 
            // button_Kaydet
            // 
            button_Kaydet.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button_Kaydet.ForeColor = Color.Black;
            button_Kaydet.Location = new Point(16, 268);
            button_Kaydet.Name = "button_Kaydet";
            button_Kaydet.Size = new Size(144, 56);
            button_Kaydet.TabIndex = 11;
            button_Kaydet.Text = "Kaydet";
            button_Kaydet.UseVisualStyleBackColor = true;
            button_Kaydet.Click += button_Kaydet_Click;
            // 
            // textBox_Kilo
            // 
            textBox_Kilo.Location = new Point(177, 164);
            textBox_Kilo.Name = "textBox_Kilo";
            textBox_Kilo.Size = new Size(173, 34);
            textBox_Kilo.TabIndex = 9;
            // 
            // textBox_Boy
            // 
            textBox_Boy.Location = new Point(177, 126);
            textBox_Boy.Name = "textBox_Boy";
            textBox_Boy.Size = new Size(173, 34);
            textBox_Boy.TabIndex = 8;
            // 
            // textBox_Soyad
            // 
            textBox_Soyad.Location = new Point(177, 86);
            textBox_Soyad.Name = "textBox_Soyad";
            textBox_Soyad.Size = new Size(173, 34);
            textBox_Soyad.TabIndex = 7;
            // 
            // textBox_Ad
            // 
            textBox_Ad.Location = new Point(177, 46);
            textBox_Ad.Name = "textBox_Ad";
            textBox_Ad.Size = new Size(173, 34);
            textBox_Ad.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(15, 210);
            label5.Name = "label5";
            label5.Size = new Size(145, 28);
            label5.TabIndex = 5;
            label5.Text = "Doğum Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(16, 170);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 4;
            label4.Text = "Kilo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(16, 132);
            label3.Name = "label3";
            label3.Size = new Size(95, 28);
            label3.TabIndex = 3;
            label3.Text = "Boy(cm):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(15, 92);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 2;
            label2.Text = "Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(16, 52);
            label1.Name = "label1";
            label1.Size = new Size(43, 28);
            label1.TabIndex = 1;
            label1.Text = "Ad:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 360);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1011, 478);
            dataGridView1.TabIndex = 1;
            // 
            // pictureBox_BurcResim
            // 
            pictureBox_BurcResim.Location = new Point(612, 12);
            pictureBox_BurcResim.Name = "pictureBox_BurcResim";
            pictureBox_BurcResim.Size = new Size(411, 342);
            pictureBox_BurcResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_BurcResim.TabIndex = 2;
            pictureBox_BurcResim.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(1071, 874);
            Controls.Add(pictureBox_BurcResim);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_BurcResim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox_Kilo;
        private TextBox textBox_Boy;
        private TextBox textBox_Soyad;
        private TextBox textBox_Ad;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button_Kaydet;
        private DataGridView dataGridView1;
        private TextBox textBox_DogumTarihi;
        private PictureBox pictureBox_BurcResim;
        private Button button_Goster;
        private Button button_Temizle;
    }
}

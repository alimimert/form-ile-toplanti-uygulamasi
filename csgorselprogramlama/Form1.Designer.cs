namespace csgorselprogramlama
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
            this.toplanti_olusturan_takvim = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toplanti_katilan_takvim = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toplanti_olusturan_kisi = new System.Windows.Forms.TextBox();
            this.toplanti_olusturan_aciklama = new System.Windows.Forms.TextBox();
            this.toplanti_katilan_isim = new System.Windows.Forms.TextBox();
            this.toplanti_olustur = new System.Windows.Forms.Button();
            this.toplantiya_katil = new System.Windows.Forms.Button();
            this.silButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelmabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.toplanti_katilan_kod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toplanti_olusturan_takvim
            // 
            this.toplanti_olusturan_takvim.Location = new System.Drawing.Point(67, 317);
            this.toplanti_olusturan_takvim.Name = "toplanti_olusturan_takvim";
            this.toplanti_olusturan_takvim.TabIndex = 0;
            this.toplanti_olusturan_takvim.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.toplanti_olusturan_takvim_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toplantı Oluştur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Toplantıyı Oluşturan Kişi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1131, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 34);
            this.label4.TabIndex = 4;
            this.label4.Text = "Toplantıya Katıl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Açıklama:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1108, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Toplantı Kodu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1112, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Katılımcı İsmi:";
            // 
            // toplanti_katilan_takvim
            // 
            this.toplanti_katilan_takvim.Location = new System.Drawing.Point(1118, 317);
            this.toplanti_katilan_takvim.Name = "toplanti_katilan_takvim";
            this.toplanti_katilan_takvim.TabIndex = 8;
            this.toplanti_katilan_takvim.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.toplanti_katilan_takvim_DateChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(387, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(677, 365);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // toplanti_olusturan_kisi
            // 
            this.toplanti_olusturan_kisi.BackColor = System.Drawing.Color.White;
            this.toplanti_olusturan_kisi.Location = new System.Drawing.Point(225, 73);
            this.toplanti_olusturan_kisi.Name = "toplanti_olusturan_kisi";
            this.toplanti_olusturan_kisi.Size = new System.Drawing.Size(125, 27);
            this.toplanti_olusturan_kisi.TabIndex = 11;
            this.toplanti_olusturan_kisi.TextChanged += new System.EventHandler(this.toplanti_olusturan_kisi_TextChanged);
            // 
            // toplanti_olusturan_aciklama
            // 
            this.toplanti_olusturan_aciklama.BackColor = System.Drawing.Color.White;
            this.toplanti_olusturan_aciklama.Location = new System.Drawing.Point(225, 128);
            this.toplanti_olusturan_aciklama.Name = "toplanti_olusturan_aciklama";
            this.toplanti_olusturan_aciklama.Size = new System.Drawing.Size(125, 27);
            this.toplanti_olusturan_aciklama.TabIndex = 12;
            this.toplanti_olusturan_aciklama.TextChanged += new System.EventHandler(this.toplanti_olusturan_aciklama_TextChanged);
            // 
            // toplanti_katilan_isim
            // 
            this.toplanti_katilan_isim.BackColor = System.Drawing.Color.White;
            this.toplanti_katilan_isim.Location = new System.Drawing.Point(1255, 131);
            this.toplanti_katilan_isim.Name = "toplanti_katilan_isim";
            this.toplanti_katilan_isim.Size = new System.Drawing.Size(125, 27);
            this.toplanti_katilan_isim.TabIndex = 14;
            this.toplanti_katilan_isim.TextChanged += new System.EventHandler(this.toplanti_katilan_isim_TextChanged);
            // 
            // toplanti_olustur
            // 
            this.toplanti_olustur.BackColor = System.Drawing.Color.Green;
            this.toplanti_olustur.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toplanti_olustur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toplanti_olustur.Location = new System.Drawing.Point(102, 536);
            this.toplanti_olustur.Name = "toplanti_olustur";
            this.toplanti_olustur.Size = new System.Drawing.Size(176, 61);
            this.toplanti_olustur.TabIndex = 15;
            this.toplanti_olustur.Text = "Toplantıyı Oluştur";
            this.toplanti_olustur.UseVisualStyleBackColor = false;
            this.toplanti_olustur.Click += new System.EventHandler(this.toplanti_olustur_Click);
            // 
            // toplantiya_katil
            // 
            this.toplantiya_katil.BackColor = System.Drawing.Color.Navy;
            this.toplantiya_katil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toplantiya_katil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toplantiya_katil.Location = new System.Drawing.Point(1167, 536);
            this.toplantiya_katil.Name = "toplantiya_katil";
            this.toplantiya_katil.Size = new System.Drawing.Size(161, 61);
            this.toplantiya_katil.TabIndex = 16;
            this.toplantiya_katil.Text = "Toplantıya Katıl";
            this.toplantiya_katil.UseVisualStyleBackColor = false;
            this.toplantiya_katil.Click += new System.EventHandler(this.toplantiya_katil_Click);
            // 
            // silButton
            // 
            this.silButton.BackColor = System.Drawing.Color.Red;
            this.silButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.silButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.silButton.Location = new System.Drawing.Point(649, 219);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(174, 47);
            this.silButton.TabIndex = 17;
            this.silButton.Text = "Toplantıyı Sil";
            this.silButton.UseVisualStyleBackColor = false;
            this.silButton.Click += new System.EventHandler(this.silButton_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(81, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Toplantı Oluşturma Tarihini Seçin:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1146, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Toplantı Katılım Tarihini Seçin";
            // 
            // labelmabel
            // 
            this.labelmabel.AutoSize = true;
            this.labelmabel.Location = new System.Drawing.Point(514, 285);
            this.labelmabel.Name = "labelmabel";
            this.labelmabel.Size = new System.Drawing.Size(461, 20);
            this.labelmabel.TabIndex = 20;
            this.labelmabel.Text = "Toplantı Silmek İçin Bir Toplantı Seçip Toplantı Sil Butonuna Tıklayın!";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(502, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(486, 45);
            this.label10.TabIndex = 21;
            this.label10.Text = "Toplantı Planlama Uygulaması";
            // 
            // toplanti_katilan_kod
            // 
            this.toplanti_katilan_kod.Location = new System.Drawing.Point(1255, 73);
            this.toplanti_katilan_kod.Name = "toplanti_katilan_kod";
            this.toplanti_katilan_kod.Size = new System.Drawing.Size(125, 27);
            this.toplanti_katilan_kod.TabIndex = 22;
            this.toplanti_katilan_kod.TextChanged += new System.EventHandler(this.toplanti_katilan_kod_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1452, 728);
            this.Controls.Add(this.toplanti_katilan_kod);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelmabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.toplantiya_katil);
            this.Controls.Add(this.toplanti_olustur);
            this.Controls.Add(this.toplanti_katilan_isim);
            this.Controls.Add(this.toplanti_olusturan_aciklama);
            this.Controls.Add(this.toplanti_olusturan_kisi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toplanti_katilan_takvim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toplanti_olusturan_takvim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonthCalendar toplanti_olusturan_takvim;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private MonthCalendar toplanti_katilan_takvim;
        private DataGridView dataGridView1;
        private TextBox toplanti_olusturan_kisi;
        private TextBox toplanti_olusturan_aciklama;
        private TextBox toplanti_katilan_isim;
        private Button toplanti_olustur;
        private Button toplantiya_katil;
        private Button silButton;
        private Label label8;
        private Label label9;
        private Label labelmabel;
        private Label label10;
        private TextBox toplanti_katilan_kod;
    }
}
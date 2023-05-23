
namespace EczaneOtomasyonu.Forms
{
    partial class IlacBilgi
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ılacBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eczaneDataSet3 = new EczaneOtomasyonu.EczaneDataSet3();
            this.ilacBilgiTableAdapter = new EczaneOtomasyonu.EczaneDataSet3TableAdapters.IlacBilgiTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.barkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ılacAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonKullanimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kutuSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanimNedeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yanEtkileriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslimAlanYakaKartNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonkullanimtarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kutusayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanimnedeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yanetkileri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslimalanyakakartno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ılacBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneDataSet3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "İlaç Ara ( İsme Göre )";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barkodDataGridViewTextBoxColumn,
            this.ılacAdiDataGridViewTextBoxColumn,
            this.firmaDataGridViewTextBoxColumn,
            this.sonKullanimTarihiDataGridViewTextBoxColumn,
            this.kutuSayisiDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.kullanimNedeniDataGridViewTextBoxColumn,
            this.yanEtkileriDataGridViewTextBoxColumn,
            this.teslimAlanYakaKartNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ılacBilgiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(955, 156);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ılacBilgiBindingSource
            // 
            this.ılacBilgiBindingSource.DataMember = "IlacBilgi";
            this.ılacBilgiBindingSource.DataSource = this.eczaneDataSet3;
            // 
            // eczaneDataSet3
            // 
            this.eczaneDataSet3.DataSetName = "EczaneDataSet3";
            this.eczaneDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ilacBilgiTableAdapter
            // 
            this.ilacBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 134);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İlaç Bilgi Girişi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(314, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(830, 36);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(104, 69);
            this.textBox8.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(699, 36);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 69);
            this.textBox7.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(853, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Yan Etkileri:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(701, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Kullanım Nedeni:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(554, 89);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(554, 36);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(319, 39);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(76, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fiyat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Kutu Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Son Kullanma Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Firma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "İlaç Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Barkod:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(521, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 185);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(208, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "İşlemi Gerçekleştiren Personel";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(315, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 404);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 164);
            this.listBox1.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(8, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(236, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "-----> Tarihi Geçmiş ilaçlar Listesi";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barkod,
            this.ilacadi,
            this.firma,
            this.sonkullanimtarihi,
            this.kutusayisi,
            this.fiyat,
            this.kullanimnedeni,
            this.yanetkileri,
            this.teslimalanyakakartno});
            this.dataGridView2.Location = new System.Drawing.Point(12, 65);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(955, 156);
            this.dataGridView2.TabIndex = 7;
            // 
            // barkodDataGridViewTextBoxColumn
            // 
            this.barkodDataGridViewTextBoxColumn.DataPropertyName = "Barkod";
            this.barkodDataGridViewTextBoxColumn.HeaderText = "Barkod";
            this.barkodDataGridViewTextBoxColumn.Name = "barkodDataGridViewTextBoxColumn";
            // 
            // ılacAdiDataGridViewTextBoxColumn
            // 
            this.ılacAdiDataGridViewTextBoxColumn.DataPropertyName = "IlacAdi";
            this.ılacAdiDataGridViewTextBoxColumn.HeaderText = "İlaç Adı";
            this.ılacAdiDataGridViewTextBoxColumn.Name = "ılacAdiDataGridViewTextBoxColumn";
            // 
            // firmaDataGridViewTextBoxColumn
            // 
            this.firmaDataGridViewTextBoxColumn.DataPropertyName = "Firma";
            this.firmaDataGridViewTextBoxColumn.HeaderText = "Firma";
            this.firmaDataGridViewTextBoxColumn.Name = "firmaDataGridViewTextBoxColumn";
            // 
            // sonKullanimTarihiDataGridViewTextBoxColumn
            // 
            this.sonKullanimTarihiDataGridViewTextBoxColumn.DataPropertyName = "SonKullanimTarihi";
            this.sonKullanimTarihiDataGridViewTextBoxColumn.HeaderText = "Son Kullanım Tarihi";
            this.sonKullanimTarihiDataGridViewTextBoxColumn.Name = "sonKullanimTarihiDataGridViewTextBoxColumn";
            // 
            // kutuSayisiDataGridViewTextBoxColumn
            // 
            this.kutuSayisiDataGridViewTextBoxColumn.DataPropertyName = "KutuSayisi";
            this.kutuSayisiDataGridViewTextBoxColumn.HeaderText = "Kutu Sayısı";
            this.kutuSayisiDataGridViewTextBoxColumn.Name = "kutuSayisiDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // kullanimNedeniDataGridViewTextBoxColumn
            // 
            this.kullanimNedeniDataGridViewTextBoxColumn.DataPropertyName = "KullanimNedeni";
            this.kullanimNedeniDataGridViewTextBoxColumn.HeaderText = "Kullanım Nedeni";
            this.kullanimNedeniDataGridViewTextBoxColumn.Name = "kullanimNedeniDataGridViewTextBoxColumn";
            // 
            // yanEtkileriDataGridViewTextBoxColumn
            // 
            this.yanEtkileriDataGridViewTextBoxColumn.DataPropertyName = "YanEtkileri";
            this.yanEtkileriDataGridViewTextBoxColumn.HeaderText = "Yan Etkileri";
            this.yanEtkileriDataGridViewTextBoxColumn.Name = "yanEtkileriDataGridViewTextBoxColumn";
            // 
            // teslimAlanYakaKartNoDataGridViewTextBoxColumn
            // 
            this.teslimAlanYakaKartNoDataGridViewTextBoxColumn.DataPropertyName = "TeslimAlanYakaKartNo";
            this.teslimAlanYakaKartNoDataGridViewTextBoxColumn.HeaderText = "Teslim Alan Yaka Kart No";
            this.teslimAlanYakaKartNoDataGridViewTextBoxColumn.Name = "teslimAlanYakaKartNoDataGridViewTextBoxColumn";
            // 
            // barkod
            // 
            this.barkod.HeaderText = "Barkod";
            this.barkod.Name = "barkod";
            // 
            // ilacadi
            // 
            this.ilacadi.HeaderText = "İlaç Adı";
            this.ilacadi.Name = "ilacadi";
            // 
            // firma
            // 
            this.firma.HeaderText = "Firma";
            this.firma.Name = "firma";
            // 
            // sonkullanimtarihi
            // 
            this.sonkullanimtarihi.HeaderText = "Son Kullanım Tarihi";
            this.sonkullanimtarihi.Name = "sonkullanimtarihi";
            // 
            // kutusayisi
            // 
            this.kutusayisi.HeaderText = "Kutu Sayısı";
            this.kutusayisi.Name = "kutusayisi";
            // 
            // fiyat
            // 
            this.fiyat.HeaderText = "Fiyat";
            this.fiyat.Name = "fiyat";
            // 
            // kullanimnedeni
            // 
            this.kullanimnedeni.HeaderText = "Kullanım Nedeni";
            this.kullanimnedeni.Name = "kullanimnedeni";
            // 
            // yanetkileri
            // 
            this.yanetkileri.HeaderText = "Yan Etkileri";
            this.yanetkileri.Name = "yanetkileri";
            // 
            // teslimalanyakakartno
            // 
            this.teslimalanyakakartno.HeaderText = "Teslim Alan Yaka Kart No";
            this.teslimalanyakakartno.Name = "teslimalanyakakartno";
            // 
            // IlacBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 575);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "IlacBilgi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IlacBilgi";
            this.Load += new System.EventHandler(this.IlacBilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ılacBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneDataSet3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EczaneDataSet3 eczaneDataSet3;
        private System.Windows.Forms.BindingSource ılacBilgiBindingSource;
        private EczaneDataSet3TableAdapters.IlacBilgiTableAdapter ilacBilgiTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılacAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonKullanimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kutuSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanimNedeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yanEtkileriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimAlanYakaKartNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn firma;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonkullanimtarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kutusayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanimnedeni;
        private System.Windows.Forms.DataGridViewTextBoxColumn yanetkileri;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimalanyakakartno;
    }
}
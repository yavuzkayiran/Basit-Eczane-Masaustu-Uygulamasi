
namespace EczaneOtomasyonu.Forms
{
    partial class IlacSatis
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tcKimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sosyalGuvenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eczaneDataSet5 = new EczaneOtomasyonu.EczaneDataSet5();
            this.hastaBilgiTableAdapter = new EczaneOtomasyonu.EczaneDataSet5TableAdapters.HastaBilgiTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.barkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ılacAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonKullanimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kutuSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanimNedeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yanEtkileriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ılacBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eczaneDataSet6 = new EczaneOtomasyonu.EczaneDataSet6();
            this.ilacBilgiTableAdapter = new EczaneOtomasyonu.EczaneDataSet6TableAdapters.IlacBilgiTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.TcKimlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SosyalGuvence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IlacAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SonKullanimTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KutuSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullanimNedeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YanEtkileri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ılacBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcKimlikDataGridViewTextBoxColumn,
            this.adSoyadDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.sosyalGuvenceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hastaBilgiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(148, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tcKimlikDataGridViewTextBoxColumn
            // 
            this.tcKimlikDataGridViewTextBoxColumn.DataPropertyName = "TcKimlik";
            this.tcKimlikDataGridViewTextBoxColumn.HeaderText = "TcKimlik";
            this.tcKimlikDataGridViewTextBoxColumn.Name = "tcKimlikDataGridViewTextBoxColumn";
            // 
            // adSoyadDataGridViewTextBoxColumn
            // 
            this.adSoyadDataGridViewTextBoxColumn.DataPropertyName = "AdSoyad";
            this.adSoyadDataGridViewTextBoxColumn.HeaderText = "AdSoyad";
            this.adSoyadDataGridViewTextBoxColumn.Name = "adSoyadDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // sosyalGuvenceDataGridViewTextBoxColumn
            // 
            this.sosyalGuvenceDataGridViewTextBoxColumn.DataPropertyName = "SosyalGuvence";
            this.sosyalGuvenceDataGridViewTextBoxColumn.HeaderText = "SosyalGuvence";
            this.sosyalGuvenceDataGridViewTextBoxColumn.Name = "sosyalGuvenceDataGridViewTextBoxColumn";
            // 
            // hastaBilgiBindingSource
            // 
            this.hastaBilgiBindingSource.DataMember = "HastaBilgi";
            this.hastaBilgiBindingSource.DataSource = this.eczaneDataSet5;
            // 
            // eczaneDataSet5
            // 
            this.eczaneDataSet5.DataSetName = "EczaneDataSet5";
            this.eczaneDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaBilgiTableAdapter
            // 
            this.hastaBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barkodDataGridViewTextBoxColumn,
            this.ılacAdiDataGridViewTextBoxColumn,
            this.sonKullanimTarihiDataGridViewTextBoxColumn,
            this.kutuSayisiDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.kullanimNedeniDataGridViewTextBoxColumn,
            this.yanEtkileriDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.ılacBilgiBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(45, 276);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(744, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
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
            this.ılacAdiDataGridViewTextBoxColumn.HeaderText = "IlacAdi";
            this.ılacAdiDataGridViewTextBoxColumn.Name = "ılacAdiDataGridViewTextBoxColumn";
            // 
            // sonKullanimTarihiDataGridViewTextBoxColumn
            // 
            this.sonKullanimTarihiDataGridViewTextBoxColumn.DataPropertyName = "SonKullanimTarihi";
            this.sonKullanimTarihiDataGridViewTextBoxColumn.HeaderText = "SonKullanimTarihi";
            this.sonKullanimTarihiDataGridViewTextBoxColumn.Name = "sonKullanimTarihiDataGridViewTextBoxColumn";
            // 
            // kutuSayisiDataGridViewTextBoxColumn
            // 
            this.kutuSayisiDataGridViewTextBoxColumn.DataPropertyName = "KutuSayisi";
            this.kutuSayisiDataGridViewTextBoxColumn.HeaderText = "KutuSayisi";
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
            this.kullanimNedeniDataGridViewTextBoxColumn.HeaderText = "KullanimNedeni";
            this.kullanimNedeniDataGridViewTextBoxColumn.Name = "kullanimNedeniDataGridViewTextBoxColumn";
            // 
            // yanEtkileriDataGridViewTextBoxColumn
            // 
            this.yanEtkileriDataGridViewTextBoxColumn.DataPropertyName = "YanEtkileri";
            this.yanEtkileriDataGridViewTextBoxColumn.HeaderText = "YanEtkileri";
            this.yanEtkileriDataGridViewTextBoxColumn.Name = "yanEtkileriDataGridViewTextBoxColumn";
            // 
            // ılacBilgiBindingSource
            // 
            this.ılacBilgiBindingSource.DataMember = "IlacBilgi";
            this.ılacBilgiBindingSource.DataSource = this.eczaneDataSet6;
            // 
            // eczaneDataSet6
            // 
            this.eczaneDataSet6.DataSetName = "EczaneDataSet6";
            this.eczaneDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ilacBilgiTableAdapter
            // 
            this.ilacBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(335, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(335, 250);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(345, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "İlaç Ara ( İsme Göre )";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(348, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hasta Ara (TC Göre)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Müşteri Tc:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(123, 521);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(382, 612);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(629, 478);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 462);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "İşlem Yapan Personel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 59);
            this.button1.TabIndex = 23;
            this.button1.Text = "Satış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 615);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Toplam Fiyat";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 640);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Listeyi Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TcKimlik,
            this.AdSoyad,
            this.Telefon,
            this.Adres,
            this.SosyalGuvence});
            this.dataGridView3.Location = new System.Drawing.Point(148, 54);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(547, 150);
            this.dataGridView3.TabIndex = 26;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // TcKimlik
            // 
            this.TcKimlik.HeaderText = "TcKimlik";
            this.TcKimlik.Name = "TcKimlik";
            // 
            // AdSoyad
            // 
            this.AdSoyad.HeaderText = "AdSoyad";
            this.AdSoyad.Name = "AdSoyad";
            // 
            // Telefon
            // 
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            // 
            // Adres
            // 
            this.Adres.HeaderText = "Adres";
            this.Adres.Name = "Adres";
            // 
            // SosyalGuvence
            // 
            this.SosyalGuvence.HeaderText = "SosyalGuvence";
            this.SosyalGuvence.Name = "SosyalGuvence";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barkod,
            this.IlacAdi,
            this.SonKullanimTarihi,
            this.KutuSayisi,
            this.Fiyat,
            this.KullanimNedeni,
            this.YanEtkileri});
            this.dataGridView4.Location = new System.Drawing.Point(45, 276);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(744, 150);
            this.dataGridView4.TabIndex = 27;
            this.dataGridView4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellClick);
            // 
            // Barkod
            // 
            this.Barkod.HeaderText = "Barkod";
            this.Barkod.Name = "Barkod";
            // 
            // IlacAdi
            // 
            this.IlacAdi.HeaderText = "IlacAdi";
            this.IlacAdi.Name = "IlacAdi";
            // 
            // SonKullanimTarihi
            // 
            this.SonKullanimTarihi.HeaderText = "SonKullanimTarihi";
            this.SonKullanimTarihi.Name = "SonKullanimTarihi";
            // 
            // KutuSayisi
            // 
            this.KutuSayisi.HeaderText = "KutuSayisi";
            this.KutuSayisi.Name = "KutuSayisi";
            // 
            // Fiyat
            // 
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.Name = "Fiyat";
            // 
            // KullanimNedeni
            // 
            this.KullanimNedeni.HeaderText = "KullanimNedeni";
            this.KullanimNedeni.Name = "KullanimNedeni";
            // 
            // YanEtkileri
            // 
            this.YanEtkileri.HeaderText = "YanEtkileri";
            this.YanEtkileri.Name = "YanEtkileri";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(252, 438);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(307, 164);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Barkod";
            this.columnHeader1.Width = 97;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İlaç Adı";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fiyatı";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adet";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(45, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 33);
            this.button3.TabIndex = 29;
            this.button3.Text = "İlaç Yan Etkiklerini Göster";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // IlacSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 672);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IlacSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IlacSatis";
            this.Load += new System.EventHandler(this.IlacSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ılacBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private EczaneDataSet5 eczaneDataSet5;
        private System.Windows.Forms.BindingSource hastaBilgiBindingSource;
        private EczaneDataSet5TableAdapters.HastaBilgiTableAdapter hastaBilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcKimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sosyalGuvenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private EczaneDataSet6 eczaneDataSet6;
        private System.Windows.Forms.BindingSource ılacBilgiBindingSource;
        private EczaneDataSet6TableAdapters.IlacBilgiTableAdapter ilacBilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılacAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonKullanimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kutuSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanimNedeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yanEtkileriDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TcKimlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn SosyalGuvence;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn IlacAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SonKullanimTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KutuSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullanimNedeni;
        private System.Windows.Forms.DataGridViewTextBoxColumn YanEtkileri;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button3;
    }
}
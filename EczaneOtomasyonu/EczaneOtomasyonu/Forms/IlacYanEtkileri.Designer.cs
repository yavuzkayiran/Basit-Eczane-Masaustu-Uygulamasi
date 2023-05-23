
namespace EczaneOtomasyonu.Forms
{
    partial class IlacYanEtkileri
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
            this.eczaneDataSet7 = new EczaneOtomasyonu.EczaneDataSet7();
            this.ılacYanEtkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ilacYanEtkiTableAdapter = new EczaneOtomasyonu.EczaneDataSet7TableAdapters.IlacYanEtkiTableAdapter();
            this.ılacAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yanEtkileriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ılacYanEtkiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ılacAdiDataGridViewTextBoxColumn,
            this.yanEtkileriDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ılacYanEtkiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 172);
            this.dataGridView1.TabIndex = 0;
            // 
            // eczaneDataSet7
            // 
            this.eczaneDataSet7.DataSetName = "EczaneDataSet7";
            this.eczaneDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ılacYanEtkiBindingSource
            // 
            this.ılacYanEtkiBindingSource.DataMember = "IlacYanEtki";
            this.ılacYanEtkiBindingSource.DataSource = this.eczaneDataSet7;
            // 
            // ilacYanEtkiTableAdapter
            // 
            this.ilacYanEtkiTableAdapter.ClearBeforeFill = true;
            // 
            // ılacAdiDataGridViewTextBoxColumn
            // 
            this.ılacAdiDataGridViewTextBoxColumn.DataPropertyName = "IlacAdi";
            this.ılacAdiDataGridViewTextBoxColumn.HeaderText = "IlacAdi";
            this.ılacAdiDataGridViewTextBoxColumn.Name = "ılacAdiDataGridViewTextBoxColumn";
            // 
            // yanEtkileriDataGridViewTextBoxColumn
            // 
            this.yanEtkileriDataGridViewTextBoxColumn.DataPropertyName = "YanEtkileri";
            this.yanEtkileriDataGridViewTextBoxColumn.HeaderText = "YanEtkileri";
            this.yanEtkileriDataGridViewTextBoxColumn.Name = "yanEtkileriDataGridViewTextBoxColumn";
            this.yanEtkileriDataGridViewTextBoxColumn.Width = 250;
            // 
            // IlacYanEtkileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 196);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IlacYanEtkileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IlacYanEtkileri";
            this.Load += new System.EventHandler(this.IlacYanEtkileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ılacYanEtkiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private EczaneDataSet7 eczaneDataSet7;
        private System.Windows.Forms.BindingSource ılacYanEtkiBindingSource;
        private EczaneDataSet7TableAdapters.IlacYanEtkiTableAdapter ilacYanEtkiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılacAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yanEtkileriDataGridViewTextBoxColumn;
    }
}
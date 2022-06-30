
namespace TokoPunakawan
{
    partial class Pemesanan
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
            this.button2 = new System.Windows.Forms.Button();
            this.cb_Kasir = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cb_Menu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idPemesananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKasirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaMakananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisMenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pemesanananBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.toko_Punakawan1DataSet = new TokoPunakawan.Toko_Punakawan1DataSet();
            this.Jenis_Menu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Id_Pemesanan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Harga = new System.Windows.Forms.TextBox();
            this.Nama_Makanan = new System.Windows.Forms.TextBox();
            this.pemesanananBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pemesanananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pemesanananTableAdapter = new TokoPunakawan.Toko_Punakawan1DataSetTableAdapters.PemesanananTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanananBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_Punakawan1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanananBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanananBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 62;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // cb_Kasir
            // 
            this.cb_Kasir.FormattingEnabled = true;
            this.cb_Kasir.Location = new System.Drawing.Point(301, 114);
            this.cb_Kasir.Name = "cb_Kasir";
            this.cb_Kasir.Size = new System.Drawing.Size(121, 24);
            this.cb_Kasir.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 60;
            this.label6.Text = "ID Kasir";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(278, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 63;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // cb_Menu
            // 
            this.cb_Menu.FormattingEnabled = true;
            this.cb_Menu.Location = new System.Drawing.Point(301, 153);
            this.cb_Menu.Name = "cb_Menu";
            this.cb_Menu.Size = new System.Drawing.Size(121, 24);
            this.cb_Menu.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "ID Pemesanan";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(373, 315);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 57;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 56;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPemesananDataGridViewTextBoxColumn,
            this.idKasirDataGridViewTextBoxColumn,
            this.idMenuDataGridViewTextBoxColumn,
            this.namaMakananDataGridViewTextBoxColumn,
            this.jenisMenuDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pemesanananBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(98, 355);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1096, 191);
            this.dataGridView1.TabIndex = 55;
            // 
            // idPemesananDataGridViewTextBoxColumn
            // 
            this.idPemesananDataGridViewTextBoxColumn.DataPropertyName = "Id_Pemesanan";
            this.idPemesananDataGridViewTextBoxColumn.HeaderText = "Id_Pemesanan";
            this.idPemesananDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPemesananDataGridViewTextBoxColumn.Name = "idPemesananDataGridViewTextBoxColumn";
            // 
            // idKasirDataGridViewTextBoxColumn
            // 
            this.idKasirDataGridViewTextBoxColumn.DataPropertyName = "Id_Kasir";
            this.idKasirDataGridViewTextBoxColumn.HeaderText = "Id_Kasir";
            this.idKasirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idKasirDataGridViewTextBoxColumn.Name = "idKasirDataGridViewTextBoxColumn";
            // 
            // idMenuDataGridViewTextBoxColumn
            // 
            this.idMenuDataGridViewTextBoxColumn.DataPropertyName = "Id_Menu";
            this.idMenuDataGridViewTextBoxColumn.HeaderText = "Id_Menu";
            this.idMenuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idMenuDataGridViewTextBoxColumn.Name = "idMenuDataGridViewTextBoxColumn";
            // 
            // namaMakananDataGridViewTextBoxColumn
            // 
            this.namaMakananDataGridViewTextBoxColumn.DataPropertyName = "Nama_Makanan";
            this.namaMakananDataGridViewTextBoxColumn.HeaderText = "Nama_Makanan";
            this.namaMakananDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaMakananDataGridViewTextBoxColumn.Name = "namaMakananDataGridViewTextBoxColumn";
            // 
            // jenisMenuDataGridViewTextBoxColumn
            // 
            this.jenisMenuDataGridViewTextBoxColumn.DataPropertyName = "Jenis_Menu";
            this.jenisMenuDataGridViewTextBoxColumn.HeaderText = "Jenis_Menu";
            this.jenisMenuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jenisMenuDataGridViewTextBoxColumn.Name = "jenisMenuDataGridViewTextBoxColumn";
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            // 
            // pemesanananBindingSource2
            // 
            this.pemesanananBindingSource2.DataMember = "Pemesananan";
            this.pemesanananBindingSource2.DataSource = this.toko_Punakawan1DataSet;
            // 
            // toko_Punakawan1DataSet
            // 
            this.toko_Punakawan1DataSet.DataSetName = "Toko_Punakawan1DataSet";
            this.toko_Punakawan1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Jenis_Menu
            // 
            this.Jenis_Menu.Location = new System.Drawing.Point(301, 235);
            this.Jenis_Menu.Name = "Jenis_Menu";
            this.Jenis_Menu.Size = new System.Drawing.Size(121, 22);
            this.Jenis_Menu.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Harga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "Jenis Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Nama Makanan / Minuman";
            // 
            // Id_Pemesanan
            // 
            this.Id_Pemesanan.Location = new System.Drawing.Point(301, 77);
            this.Id_Pemesanan.Name = "Id_Pemesanan";
            this.Id_Pemesanan.Size = new System.Drawing.Size(121, 22);
            this.Id_Pemesanan.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "ID Menu";
            // 
            // Harga
            // 
            this.Harga.Location = new System.Drawing.Point(301, 278);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(121, 22);
            this.Harga.TabIndex = 54;
            // 
            // Nama_Makanan
            // 
            this.Nama_Makanan.Location = new System.Drawing.Point(301, 195);
            this.Nama_Makanan.Name = "Nama_Makanan";
            this.Nama_Makanan.Size = new System.Drawing.Size(121, 22);
            this.Nama_Makanan.TabIndex = 47;
            // 
            // pemesanananBindingSource1
            // 
            this.pemesanananBindingSource1.DataMember = "Pemesananan";
            // 
            // pemesanananBindingSource
            // 
            this.pemesanananBindingSource.DataMember = "Pemesananan";
            // 
            // pemesanananTableAdapter
            // 
            this.pemesanananTableAdapter.ClearBeforeFill = true;
            // 
            // Pemesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 622);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cb_Kasir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cb_Menu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Jenis_Menu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Id_Pemesanan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Harga);
            this.Controls.Add(this.Nama_Makanan);
            this.Name = "Pemesanan";
            this.Text = "Pemesanan";
            this.Load += new System.EventHandler(this.Pemesanan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanananBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_Punakawan1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanananBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanananBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_Kasir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource pemesanananBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource pemesanananBindingSource1;
        private System.Windows.Forms.ComboBox cb_Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Jenis_Menu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Id_Pemesanan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Harga;
        private System.Windows.Forms.TextBox Nama_Makanan;
        private Toko_Punakawan1DataSet toko_Punakawan1DataSet;
        private System.Windows.Forms.BindingSource pemesanananBindingSource2;
        private Toko_Punakawan1DataSetTableAdapters.PemesanananTableAdapter pemesanananTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPemesananDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKasirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaMakananDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisMenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
    }
}
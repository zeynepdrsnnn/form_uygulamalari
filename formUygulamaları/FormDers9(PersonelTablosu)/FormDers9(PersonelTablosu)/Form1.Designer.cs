namespace FormDers9_PersonelTablosu_
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.maskedMaas = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textMeslek = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnBekar = new System.Windows.Forms.RadioButton();
            this.Btnevli = new System.Windows.Forms.RadioButton();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.textAd = new System.Windows.Forms.TextBox();
            this.comboŞehir = new System.Windows.Forms.ComboBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.Btnİstatistik = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelŞehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelMaaşDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.personelMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet = new FormDers9_PersonelTablosu_.PersonelVeriTabaniDataSet();
            this.tbl_PersonelTableAdapter = new FormDers9_PersonelTablosu_.PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedMaas
            // 
            this.maskedMaas.Location = new System.Drawing.Point(181, 205);
            this.maskedMaas.Mask = "00000";
            this.maskedMaas.Name = "maskedMaas";
            this.maskedMaas.Size = new System.Drawing.Size(110, 22);
            this.maskedMaas.TabIndex = 5;
            this.maskedMaas.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Personel Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şehir:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(38, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Maaş:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(38, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Durum:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textMeslek);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.BtnBekar);
            this.groupBox1.Controls.Add(this.Btnevli);
            this.groupBox1.Controls.Add(this.textSoyad);
            this.groupBox1.Controls.Add(this.textAd);
            this.groupBox1.Controls.Add(this.comboŞehir);
            this.groupBox1.Controls.Add(this.textId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maskedMaas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 298);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // textMeslek
            // 
            this.textMeslek.Location = new System.Drawing.Point(181, 267);
            this.textMeslek.Name = "textMeslek";
            this.textMeslek.Size = new System.Drawing.Size(110, 22);
            this.textMeslek.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(38, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Meslek:";
            // 
            // BtnBekar
            // 
            this.BtnBekar.AutoSize = true;
            this.BtnBekar.Location = new System.Drawing.Point(237, 233);
            this.BtnBekar.Name = "BtnBekar";
            this.BtnBekar.Size = new System.Drawing.Size(64, 20);
            this.BtnBekar.TabIndex = 7;
            this.BtnBekar.TabStop = true;
            this.BtnBekar.Text = "Bekar";
            this.BtnBekar.UseVisualStyleBackColor = true;
            this.BtnBekar.CheckedChanged += new System.EventHandler(this.BtnBekar_CheckedChanged);
            // 
            // Btnevli
            // 
            this.Btnevli.AutoSize = true;
            this.Btnevli.Location = new System.Drawing.Point(181, 233);
            this.Btnevli.Name = "Btnevli";
            this.Btnevli.Size = new System.Drawing.Size(50, 20);
            this.Btnevli.TabIndex = 6;
            this.Btnevli.TabStop = true;
            this.Btnevli.Text = "Evli";
            this.Btnevli.UseVisualStyleBackColor = true;
            this.Btnevli.CheckedChanged += new System.EventHandler(this.Btnevli_CheckedChanged);
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(181, 124);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(110, 22);
            this.textSoyad.TabIndex = 3;
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(181, 86);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(110, 22);
            this.textAd.TabIndex = 2;
            // 
            // comboŞehir
            // 
            this.comboŞehir.FormattingEnabled = true;
            this.comboŞehir.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.comboŞehir.Location = new System.Drawing.Point(181, 164);
            this.comboŞehir.Name = "comboŞehir";
            this.comboŞehir.Size = new System.Drawing.Size(110, 24);
            this.comboŞehir.TabIndex = 4;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(181, 40);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(110, 22);
            this.textId.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnGüncelle);
            this.groupBox2.Controls.Add(this.Btnİstatistik);
            this.groupBox2.Controls.Add(this.BtnSil);
            this.groupBox2.Controls.Add(this.BtnKaydet);
            this.groupBox2.Location = new System.Drawing.Point(430, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 298);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGüncelle.Location = new System.Drawing.Point(20, 164);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(172, 35);
            this.BtnGüncelle.TabIndex = 6;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // Btnİstatistik
            // 
            this.Btnİstatistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnİstatistik.Location = new System.Drawing.Point(20, 227);
            this.Btnİstatistik.Name = "Btnİstatistik";
            this.Btnİstatistik.Size = new System.Drawing.Size(172, 34);
            this.Btnİstatistik.TabIndex = 4;
            this.Btnİstatistik.Text = "İstatistik";
            this.Btnİstatistik.UseVisualStyleBackColor = true;
            this.Btnİstatistik.Click += new System.EventHandler(this.Btnİstatistik_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(20, 105);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(172, 35);
            this.BtnSil.TabIndex = 2;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(20, 33);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(172, 41);
            this.BtnKaydet.TabIndex = 1;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelIDDataGridViewTextBoxColumn,
            this.personelAdDataGridViewTextBoxColumn,
            this.personelSoyadDataGridViewTextBoxColumn,
            this.personelŞehirDataGridViewTextBoxColumn,
            this.personelMaaşDataGridViewTextBoxColumn,
            this.personelDurumDataGridViewCheckBoxColumn,
            this.personelMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 337);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(929, 248);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.Tag = "s";
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            this.personelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelAdDataGridViewTextBoxColumn
            // 
            this.personelAdDataGridViewTextBoxColumn.DataPropertyName = "PersonelAd";
            this.personelAdDataGridViewTextBoxColumn.HeaderText = "PersonelAd";
            this.personelAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelAdDataGridViewTextBoxColumn.Name = "personelAdDataGridViewTextBoxColumn";
            this.personelAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelSoyadDataGridViewTextBoxColumn
            // 
            this.personelSoyadDataGridViewTextBoxColumn.DataPropertyName = "PersonelSoyad";
            this.personelSoyadDataGridViewTextBoxColumn.HeaderText = "PersonelSoyad";
            this.personelSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelSoyadDataGridViewTextBoxColumn.Name = "personelSoyadDataGridViewTextBoxColumn";
            this.personelSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelŞehirDataGridViewTextBoxColumn
            // 
            this.personelŞehirDataGridViewTextBoxColumn.DataPropertyName = "PersonelŞehir";
            this.personelŞehirDataGridViewTextBoxColumn.HeaderText = "PersonelŞehir";
            this.personelŞehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelŞehirDataGridViewTextBoxColumn.Name = "personelŞehirDataGridViewTextBoxColumn";
            this.personelŞehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelMaaşDataGridViewTextBoxColumn
            // 
            this.personelMaaşDataGridViewTextBoxColumn.DataPropertyName = "PersonelMaaş";
            this.personelMaaşDataGridViewTextBoxColumn.HeaderText = "PersonelMaaş";
            this.personelMaaşDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelMaaşDataGridViewTextBoxColumn.Name = "personelMaaşDataGridViewTextBoxColumn";
            this.personelMaaşDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelDurumDataGridViewCheckBoxColumn
            // 
            this.personelDurumDataGridViewCheckBoxColumn.DataPropertyName = "PersonelDurum";
            this.personelDurumDataGridViewCheckBoxColumn.HeaderText = "PersonelDurum";
            this.personelDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.personelDurumDataGridViewCheckBoxColumn.Name = "personelDurumDataGridViewCheckBoxColumn";
            this.personelDurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // personelMeslekDataGridViewTextBoxColumn
            // 
            this.personelMeslekDataGridViewTextBoxColumn.DataPropertyName = "PersonelMeslek";
            this.personelMeslekDataGridViewTextBoxColumn.HeaderText = "PersonelMeslek";
            this.personelMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelMeslekDataGridViewTextBoxColumn.Name = "personelMeslekDataGridViewTextBoxColumn";
            this.personelMeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelVeriTabaniDataSet;
            // 
            // personelVeriTabaniDataSet
            // 
            this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.personelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(944, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1000, 654);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedMaas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.ComboBox comboŞehir;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textMeslek;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton BtnBekar;
        private System.Windows.Forms.RadioButton Btnevli;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button Btnİstatistik;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelVeriTabaniDataSet personelVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelŞehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelMaaşDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn personelDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnGüncelle;
    }
}


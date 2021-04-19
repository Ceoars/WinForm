namespace WindowsFormsApp1
{
    partial class Ceoars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ceoars));
            this.txtToplamOrtakAlan = new System.Windows.Forms.TextBox();
            this.txtToplamNetAlan = new System.Windows.Forms.TextBox();
            this.txtArsaPayda = new System.Windows.Forms.TextBox();
            this.txtArsaPay = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTapuBirimNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtArsam2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDaireNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Sonuçlar = new System.Windows.Forms.GroupBox();
            this.lblDaireninArsaPayi = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDaireBrüt = new System.Windows.Forms.Label();
            this.lblDaireOrtakNet = new System.Windows.Forms.Label();
            this.lblDaireNet = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.toplamsifirla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Sonuçlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtToplamOrtakAlan
            // 
            this.txtToplamOrtakAlan.Location = new System.Drawing.Point(577, 23);
            this.txtToplamOrtakAlan.Name = "txtToplamOrtakAlan";
            this.txtToplamOrtakAlan.Size = new System.Drawing.Size(67, 20);
            this.txtToplamOrtakAlan.TabIndex = 4;
            // 
            // txtToplamNetAlan
            // 
            this.txtToplamNetAlan.Location = new System.Drawing.Point(397, 22);
            this.txtToplamNetAlan.Name = "txtToplamNetAlan";
            this.txtToplamNetAlan.Size = new System.Drawing.Size(67, 20);
            this.txtToplamNetAlan.TabIndex = 3;
            // 
            // txtArsaPayda
            // 
            this.txtArsaPayda.Location = new System.Drawing.Point(857, 22);
            this.txtArsaPayda.Name = "txtArsaPayda";
            this.txtArsaPayda.Size = new System.Drawing.Size(67, 20);
            this.txtArsaPayda.TabIndex = 6;
            // 
            // txtArsaPay
            // 
            this.txtArsaPay.Location = new System.Drawing.Point(711, 22);
            this.txtArsaPay.Name = "txtArsaPay";
            this.txtArsaPay.Size = new System.Drawing.Size(67, 20);
            this.txtArsaPay.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toplamsifirla);
            this.groupBox1.Controls.Add(this.txtTapuBirimNo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtArsam2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDaireNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnHesapla);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtToplamNetAlan);
            this.groupBox1.Controls.Add(this.txtArsaPayda);
            this.groupBox1.Controls.Add(this.txtArsaPay);
            this.groupBox1.Controls.Add(this.txtToplamOrtakAlan);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1064, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgileri Giriniz";
            // 
            // txtTapuBirimNo
            // 
            this.txtTapuBirimNo.Location = new System.Drawing.Point(217, 22);
            this.txtTapuBirimNo.Name = "txtTapuBirimNo";
            this.txtTapuBirimNo.Size = new System.Drawing.Size(67, 20);
            this.txtTapuBirimNo.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tapu Birim No :";
            // 
            // txtArsam2
            // 
            this.txtArsam2.Location = new System.Drawing.Point(992, 22);
            this.txtArsam2.Name = "txtArsam2";
            this.txtArsam2.Size = new System.Drawing.Size(67, 20);
            this.txtArsam2.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(935, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Arsa m2 :";
            // 
            // txtDaireNo
            // 
            this.txtDaireNo.Location = new System.Drawing.Point(67, 22);
            this.txtDaireNo.Name = "txtDaireNo";
            this.txtDaireNo.Size = new System.Drawing.Size(67, 20);
            this.txtDaireNo.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Daire No :";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(460, 71);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(150, 23);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(790, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Arsa Payda :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Arsa Pay :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Toplam Ortak Alan :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Katların Brüt Alanı :";
            // 
            // Sonuçlar
            // 
            this.Sonuçlar.Controls.Add(this.lblDaireninArsaPayi);
            this.Sonuçlar.Controls.Add(this.label10);
            this.Sonuçlar.Controls.Add(this.lblDaireBrüt);
            this.Sonuçlar.Controls.Add(this.lblDaireOrtakNet);
            this.Sonuçlar.Controls.Add(this.lblDaireNet);
            this.Sonuçlar.Controls.Add(this.label);
            this.Sonuçlar.Controls.Add(this.label6);
            this.Sonuçlar.Controls.Add(this.label5);
            this.Sonuçlar.Location = new System.Drawing.Point(12, 118);
            this.Sonuçlar.Name = "Sonuçlar";
            this.Sonuçlar.Size = new System.Drawing.Size(1064, 70);
            this.Sonuçlar.TabIndex = 5;
            this.Sonuçlar.TabStop = false;
            this.Sonuçlar.Text = "Son Kayıt";
            // 
            // lblDaireninArsaPayi
            // 
            this.lblDaireninArsaPayi.AutoSize = true;
            this.lblDaireninArsaPayi.Location = new System.Drawing.Point(131, 31);
            this.lblDaireninArsaPayi.Name = "lblDaireninArsaPayi";
            this.lblDaireninArsaPayi.Size = new System.Drawing.Size(13, 13);
            this.lblDaireninArsaPayi.TabIndex = 7;
            this.lblDaireninArsaPayi.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Dairenin Arsa Payı :";
            // 
            // lblDaireBrüt
            // 
            this.lblDaireBrüt.AutoSize = true;
            this.lblDaireBrüt.Location = new System.Drawing.Point(956, 31);
            this.lblDaireBrüt.Name = "lblDaireBrüt";
            this.lblDaireBrüt.Size = new System.Drawing.Size(13, 13);
            this.lblDaireBrüt.TabIndex = 5;
            this.lblDaireBrüt.Text = "0";
            // 
            // lblDaireOrtakNet
            // 
            this.lblDaireOrtakNet.AutoSize = true;
            this.lblDaireOrtakNet.Location = new System.Drawing.Point(667, 31);
            this.lblDaireOrtakNet.Name = "lblDaireOrtakNet";
            this.lblDaireOrtakNet.Size = new System.Drawing.Size(13, 13);
            this.lblDaireOrtakNet.TabIndex = 4;
            this.lblDaireOrtakNet.Text = "0";
            // 
            // lblDaireNet
            // 
            this.lblDaireNet.AutoSize = true;
            this.lblDaireNet.Location = new System.Drawing.Point(398, 31);
            this.lblDaireNet.Name = "lblDaireNet";
            this.lblDaireNet.Size = new System.Drawing.Size(13, 13);
            this.lblDaireNet.TabIndex = 3;
            this.lblDaireNet.Text = "0";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(890, 31);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(60, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Daire Brüt :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(574, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Daire Ortak Net :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Daire Net :";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1064, 299);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column10,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column9,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(7, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1043, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Daire No";
            this.Column1.Name = "Column1";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Tapu Birim No";
            this.Column10.Name = "Column10";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Toplam Net Alan";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Toplam Ortak Alan";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Arsa Pay";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Arsa Payda";
            this.Column5.Name = "Column5";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Dairenin Arsa Payı";
            this.Column9.Name = "Column9";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Daire Net";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Daire Ortak Net";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Daire Brüt";
            this.Column8.Name = "Column8";
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(926, 526);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(150, 23);
            this.btnKapat.TabIndex = 8;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseMnemonic = false;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(472, 498);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(150, 23);
            this.btntemizle.TabIndex = 9;
            this.btntemizle.Text = "Listeyi Yenile";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(16, 504);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Created by Ceoars";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(978, 503);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(13, 13);
            this.lblToplam.TabIndex = 11;
            this.lblToplam.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(902, 504);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Brüt Toplam :";
            // 
            // toplamsifirla
            // 
            this.toplamsifirla.Location = new System.Drawing.Point(938, 71);
            this.toplamsifirla.Name = "toplamsifirla";
            this.toplamsifirla.Size = new System.Drawing.Size(111, 23);
            this.toplamsifirla.TabIndex = 13;
            this.toplamsifirla.Text = "Alanları Temizle";
            this.toplamsifirla.UseVisualStyleBackColor = true;
            this.toplamsifirla.Click += new System.EventHandler(this.toplamsifirla_Click);
            // 
            // Ceoars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 552);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Sonuçlar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ceoars";
            this.Text = "CeoARS v1.1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Sonuçlar.ResumeLayout(false);
            this.Sonuçlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToplamOrtakAlan;
        private System.Windows.Forms.TextBox txtToplamNetAlan;
        private System.Windows.Forms.TextBox txtArsaPayda;
        private System.Windows.Forms.TextBox txtArsaPay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Sonuçlar;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDaireOrtakNet;
        private System.Windows.Forms.Label lblDaireNet;
        private System.Windows.Forms.Label lblDaireBrüt;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDaireNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTapuBirimNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtArsam2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label lblDaireninArsaPayi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button toplamsifirla;
    }
}


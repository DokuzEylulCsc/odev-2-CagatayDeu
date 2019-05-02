namespace Odev2
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
            this.listfakulte = new System.Windows.Forms.ListBox();
            this.listbolumler = new System.Windows.Forms.ListBox();
            this.listdersler = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.listOgrenciler = new System.Windows.Forms.ListBox();
            this.listOgretimElemanlari = new System.Windows.Forms.ListBox();
            this.labelogrenciler = new System.Windows.Forms.Label();
            this.labelgorevliler = new System.Windows.Forms.Label();
            this.panelbuttons = new System.Windows.Forms.Panel();
            this.panelkaydet = new System.Windows.Forms.Panel();
            this.ogrenciEkle = new System.Windows.Forms.Button();
            this.ogrenciKaldir = new System.Windows.Forms.Button();
            this.GorevliEkle = new System.Windows.Forms.Button();
            this.gorevliKaldir = new System.Windows.Forms.Button();
            this.dosyayaYazdir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboSube = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboOgrenciTip = new System.Windows.Forms.ComboBox();
            this.ogrenciKaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TcNo = new System.Windows.Forms.TextBox();
            this.hazırBilgiYukle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelbuttons.SuspendLayout();
            this.panelkaydet.SuspendLayout();
            this.SuspendLayout();
            // 
            // listfakulte
            // 
            this.listfakulte.FormattingEnabled = true;
            this.listfakulte.ItemHeight = 25;
            this.listfakulte.Location = new System.Drawing.Point(24, 83);
            this.listfakulte.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listfakulte.Name = "listfakulte";
            this.listfakulte.Size = new System.Drawing.Size(504, 529);
            this.listfakulte.TabIndex = 6;
            this.listfakulte.Visible = false;
            // 
            // listbolumler
            // 
            this.listbolumler.FormattingEnabled = true;
            this.listbolumler.ItemHeight = 25;
            this.listbolumler.Location = new System.Drawing.Point(24, 83);
            this.listbolumler.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listbolumler.Name = "listbolumler";
            this.listbolumler.Size = new System.Drawing.Size(504, 529);
            this.listbolumler.TabIndex = 7;
            this.listbolumler.Visible = false;
            // 
            // listdersler
            // 
            this.listdersler.FormattingEnabled = true;
            this.listdersler.ItemHeight = 25;
            this.listdersler.Location = new System.Drawing.Point(24, 83);
            this.listdersler.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listdersler.Name = "listdersler";
            this.listdersler.Size = new System.Drawing.Size(504, 529);
            this.listdersler.TabIndex = 8;
            this.listdersler.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 83);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(410, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Fakülte Aç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(610, 158);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(410, 44);
            this.button2.TabIndex = 10;
            this.button2.Text = "Fakülteye Git";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(610, 231);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(410, 44);
            this.button3.TabIndex = 11;
            this.button3.Text = "Lütfen Seçiniz.";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(204, 37);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(196, 31);
            this.textBoxName.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.kaydet);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Location = new System.Drawing.Point(1100, 83);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 192);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fakülte İsmi:";
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(154, 119);
            this.kaydet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(150, 44);
            this.kaydet.TabIndex = 13;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(722, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Deu";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(175, 6);
            this.button4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 44);
            this.button4.TabIndex = 15;
            this.button4.Text = ">Geri Git<";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listOgrenciler
            // 
            this.listOgrenciler.FormattingEnabled = true;
            this.listOgrenciler.ItemHeight = 25;
            this.listOgrenciler.Location = new System.Drawing.Point(24, 83);
            this.listOgrenciler.Name = "listOgrenciler";
            this.listOgrenciler.Size = new System.Drawing.Size(252, 529);
            this.listOgrenciler.TabIndex = 16;
            this.listOgrenciler.Visible = false;
            // 
            // listOgretimElemanlari
            // 
            this.listOgretimElemanlari.FormattingEnabled = true;
            this.listOgretimElemanlari.ItemHeight = 25;
            this.listOgretimElemanlari.Location = new System.Drawing.Point(276, 83);
            this.listOgretimElemanlari.Name = "listOgretimElemanlari";
            this.listOgretimElemanlari.Size = new System.Drawing.Size(252, 529);
            this.listOgretimElemanlari.TabIndex = 17;
            this.listOgretimElemanlari.Visible = false;
            // 
            // labelogrenciler
            // 
            this.labelogrenciler.AutoSize = true;
            this.labelogrenciler.Location = new System.Drawing.Point(94, 52);
            this.labelogrenciler.Name = "labelogrenciler";
            this.labelogrenciler.Size = new System.Drawing.Size(111, 25);
            this.labelogrenciler.TabIndex = 18;
            this.labelogrenciler.Text = "Öğrenciler";
            this.labelogrenciler.Visible = false;
            // 
            // labelgorevliler
            // 
            this.labelgorevliler.AutoSize = true;
            this.labelgorevliler.Location = new System.Drawing.Point(304, 52);
            this.labelgorevliler.Name = "labelgorevliler";
            this.labelgorevliler.Size = new System.Drawing.Size(190, 25);
            this.labelgorevliler.TabIndex = 19;
            this.labelgorevliler.Text = "Öğretim Görevlileri";
            this.labelgorevliler.Visible = false;
            // 
            // panelbuttons
            // 
            this.panelbuttons.Controls.Add(this.dosyayaYazdir);
            this.panelbuttons.Controls.Add(this.gorevliKaldir);
            this.panelbuttons.Controls.Add(this.GorevliEkle);
            this.panelbuttons.Controls.Add(this.ogrenciKaldir);
            this.panelbuttons.Controls.Add(this.ogrenciEkle);
            this.panelbuttons.Location = new System.Drawing.Point(610, 84);
            this.panelbuttons.Name = "panelbuttons";
            this.panelbuttons.Size = new System.Drawing.Size(236, 291);
            this.panelbuttons.TabIndex = 20;
            this.panelbuttons.Visible = false;
            // 
            // panelkaydet
            // 
            this.panelkaydet.Controls.Add(this.TcNo);
            this.panelkaydet.Controls.Add(this.label7);
            this.panelkaydet.Controls.Add(this.ogrenciKaydet);
            this.panelkaydet.Controls.Add(this.comboOgrenciTip);
            this.panelkaydet.Controls.Add(this.label6);
            this.panelkaydet.Controls.Add(this.comboSube);
            this.panelkaydet.Controls.Add(this.label5);
            this.panelkaydet.Controls.Add(this.textBox2);
            this.panelkaydet.Controls.Add(this.label4);
            this.panelkaydet.Controls.Add(this.label3);
            this.panelkaydet.Controls.Add(this.textBox1);
            this.panelkaydet.Location = new System.Drawing.Point(1029, 52);
            this.panelkaydet.Name = "panelkaydet";
            this.panelkaydet.Size = new System.Drawing.Size(447, 298);
            this.panelkaydet.TabIndex = 21;
            this.panelkaydet.Visible = false;
            // 
            // ogrenciEkle
            // 
            this.ogrenciEkle.Location = new System.Drawing.Point(19, 16);
            this.ogrenciEkle.Name = "ogrenciEkle";
            this.ogrenciEkle.Size = new System.Drawing.Size(202, 48);
            this.ogrenciEkle.TabIndex = 0;
            this.ogrenciEkle.Text = "Öğrenci Ekle";
            this.ogrenciEkle.UseVisualStyleBackColor = true;
            this.ogrenciEkle.Click += new System.EventHandler(this.ogrenciEkle_Click);
            // 
            // ogrenciKaldir
            // 
            this.ogrenciKaldir.Location = new System.Drawing.Point(19, 69);
            this.ogrenciKaldir.Name = "ogrenciKaldir";
            this.ogrenciKaldir.Size = new System.Drawing.Size(202, 48);
            this.ogrenciKaldir.TabIndex = 1;
            this.ogrenciKaldir.Text = "Öğrenci Kaldır";
            this.ogrenciKaldir.UseVisualStyleBackColor = true;
            this.ogrenciKaldir.Click += new System.EventHandler(this.ogrenciKaldir_Click);
            // 
            // GorevliEkle
            // 
            this.GorevliEkle.Location = new System.Drawing.Point(19, 122);
            this.GorevliEkle.Name = "GorevliEkle";
            this.GorevliEkle.Size = new System.Drawing.Size(202, 48);
            this.GorevliEkle.TabIndex = 2;
            this.GorevliEkle.Text = "Öğretmen Ekle";
            this.GorevliEkle.UseVisualStyleBackColor = true;
            this.GorevliEkle.Click += new System.EventHandler(this.GorevliEkle_Click);
            // 
            // gorevliKaldir
            // 
            this.gorevliKaldir.Location = new System.Drawing.Point(19, 175);
            this.gorevliKaldir.Name = "gorevliKaldir";
            this.gorevliKaldir.Size = new System.Drawing.Size(202, 48);
            this.gorevliKaldir.TabIndex = 3;
            this.gorevliKaldir.Text = "Öğretmen Kaldır";
            this.gorevliKaldir.UseVisualStyleBackColor = true;
            this.gorevliKaldir.Click += new System.EventHandler(this.gorevliKaldir_Click);
            // 
            // dosyayaYazdir
            // 
            this.dosyayaYazdir.Location = new System.Drawing.Point(19, 228);
            this.dosyayaYazdir.Name = "dosyayaYazdir";
            this.dosyayaYazdir.Size = new System.Drawing.Size(202, 48);
            this.dosyayaYazdir.TabIndex = 4;
            this.dosyayaYazdir.Text = "Dosyaya Yazdır";
            this.dosyayaYazdir.UseVisualStyleBackColor = true;
            this.dosyayaYazdir.Click += new System.EventHandler(this.dosyayaYazdir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 31);
            this.textBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "İsim Soyisim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Yaş";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(170, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 31);
            this.textBox2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şube";
            // 
            // comboSube
            // 
            this.comboSube.DisplayMember = "1";
            this.comboSube.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSube.FormattingEnabled = true;
            this.comboSube.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboSube.Location = new System.Drawing.Point(170, 151);
            this.comboSube.Name = "comboSube";
            this.comboSube.Size = new System.Drawing.Size(200, 33);
            this.comboSube.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Öğrenci Tipi";
            // 
            // comboOgrenciTip
            // 
            this.comboOgrenciTip.DisplayMember = "1";
            this.comboOgrenciTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOgrenciTip.FormattingEnabled = true;
            this.comboOgrenciTip.Items.AddRange(new object[] {
            "Lisans",
            "Yüksek Lisans",
            "Doktora"});
            this.comboOgrenciTip.Location = new System.Drawing.Point(170, 202);
            this.comboOgrenciTip.Name = "comboOgrenciTip";
            this.comboOgrenciTip.Size = new System.Drawing.Size(200, 33);
            this.comboOgrenciTip.TabIndex = 24;
            // 
            // ogrenciKaydet
            // 
            this.ogrenciKaydet.Location = new System.Drawing.Point(71, 248);
            this.ogrenciKaydet.Margin = new System.Windows.Forms.Padding(6);
            this.ogrenciKaydet.Name = "ogrenciKaydet";
            this.ogrenciKaydet.Size = new System.Drawing.Size(150, 44);
            this.ogrenciKaydet.TabIndex = 16;
            this.ogrenciKaydet.Text = "Kaydet";
            this.ogrenciKaydet.UseVisualStyleBackColor = true;
            this.ogrenciKaydet.Click += new System.EventHandler(this.ogrenciKaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Tc No";
            // 
            // TcNo
            // 
            this.TcNo.Location = new System.Drawing.Point(170, 110);
            this.TcNo.Name = "TcNo";
            this.TcNo.Size = new System.Drawing.Size(200, 31);
            this.TcNo.TabIndex = 26;
            // 
            // hazırBilgiYukle
            // 
            this.hazırBilgiYukle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hazırBilgiYukle.ForeColor = System.Drawing.Color.Coral;
            this.hazırBilgiYukle.Location = new System.Drawing.Point(160, 621);
            this.hazırBilgiYukle.Name = "hazırBilgiYukle";
            this.hazırBilgiYukle.Size = new System.Drawing.Size(232, 62);
            this.hazırBilgiYukle.TabIndex = 22;
            this.hazırBilgiYukle.Text = "Hazır Bilgileri Yükle";
            this.hazırBilgiYukle.UseVisualStyleBackColor = false;
            this.hazırBilgiYukle.Click += new System.EventHandler(this.hazırBilgiYukle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 865);
            this.Controls.Add(this.hazırBilgiYukle);
            this.Controls.Add(this.panelkaydet);
            this.Controls.Add(this.labelgorevliler);
            this.Controls.Add(this.labelogrenciler);
            this.Controls.Add(this.listOgretimElemanlari);
            this.Controls.Add(this.listOgrenciler);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listdersler);
            this.Controls.Add(this.listbolumler);
            this.Controls.Add(this.listfakulte);
            this.Controls.Add(this.panelbuttons);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelbuttons.ResumeLayout(false);
            this.panelkaydet.ResumeLayout(false);
            this.panelkaydet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listfakulte;
        private System.Windows.Forms.ListBox listbolumler;
        private System.Windows.Forms.ListBox listdersler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listOgrenciler;
        private System.Windows.Forms.ListBox listOgretimElemanlari;
        private System.Windows.Forms.Label labelogrenciler;
        private System.Windows.Forms.Label labelgorevliler;
        private System.Windows.Forms.Panel panelbuttons;
        private System.Windows.Forms.Button dosyayaYazdir;
        private System.Windows.Forms.Button gorevliKaldir;
        private System.Windows.Forms.Button GorevliEkle;
        private System.Windows.Forms.Button ogrenciKaldir;
        private System.Windows.Forms.Button ogrenciEkle;
        private System.Windows.Forms.Panel panelkaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboSube;
        private System.Windows.Forms.ComboBox comboOgrenciTip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ogrenciKaydet;
        private System.Windows.Forms.TextBox TcNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button hazırBilgiYukle;
    }
}


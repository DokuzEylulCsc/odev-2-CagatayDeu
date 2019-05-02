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
            this.panel1.SuspendLayout();
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
            this.button4.Location = new System.Drawing.Point(175, 6);
            this.button4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 44);
            this.button4.TabIndex = 15;
            this.button4.Text = "Başa Geri Dön";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 865);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}


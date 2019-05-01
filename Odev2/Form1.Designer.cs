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
            this.kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listfakulte
            // 
            this.listfakulte.FormattingEnabled = true;
            this.listfakulte.Location = new System.Drawing.Point(12, 43);
            this.listfakulte.Name = "listfakulte";
            this.listfakulte.Size = new System.Drawing.Size(254, 277);
            this.listfakulte.TabIndex = 6;
            this.listfakulte.Visible = false;
            // 
            // listbolumler
            // 
            this.listbolumler.FormattingEnabled = true;
            this.listbolumler.Location = new System.Drawing.Point(12, 43);
            this.listbolumler.Name = "listbolumler";
            this.listbolumler.Size = new System.Drawing.Size(254, 277);
            this.listbolumler.TabIndex = 7;
            this.listbolumler.Visible = false;
            // 
            // listdersler
            // 
            this.listdersler.FormattingEnabled = true;
            this.listdersler.Location = new System.Drawing.Point(12, 43);
            this.listdersler.Name = "listdersler";
            this.listdersler.Size = new System.Drawing.Size(254, 277);
            this.listdersler.TabIndex = 8;
            this.listdersler.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Fakülte Aç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Fakülteye Git";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(305, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Lütfen Seçiniz.";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(18, 20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kaydet);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Location = new System.Drawing.Point(442, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 99);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(166, 20);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(75, 23);
            this.kaydet.TabIndex = 13;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Deu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listdersler);
            this.Controls.Add(this.listbolumler);
            this.Controls.Add(this.listfakulte);
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
    }
}


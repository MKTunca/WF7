namespace WindowsFormsApp5
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
            this.dataTXT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sayi1 = new System.Windows.Forms.TextBox();
            this.sayi2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sonuc = new System.Windows.Forms.Button();
            this.eposta = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataTXT
            // 
            this.dataTXT.Location = new System.Drawing.Point(64, 33);
            this.dataTXT.Name = "dataTXT";
            this.dataTXT.Size = new System.Drawing.Size(100, 20);
            this.dataTXT.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "tıkla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sayi1
            // 
            this.sayi1.Location = new System.Drawing.Point(133, 120);
            this.sayi1.Name = "sayi1";
            this.sayi1.Size = new System.Drawing.Size(31, 20);
            this.sayi1.TabIndex = 2;
            // 
            // sayi2
            // 
            this.sayi2.Location = new System.Drawing.Point(198, 120);
            this.sayi2.Name = "sayi2";
            this.sayi2.Size = new System.Drawing.Size(26, 20);
            this.sayi2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "/";
            // 
            // sonuc
            // 
            this.sonuc.Location = new System.Drawing.Point(265, 116);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(75, 23);
            this.sonuc.TabIndex = 5;
            this.sonuc.Text = "sonuç";
            this.sonuc.UseVisualStyleBackColor = true;
            this.sonuc.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // eposta
            // 
            this.eposta.Location = new System.Drawing.Point(133, 201);
            this.eposta.Name = "eposta";
            this.eposta.Size = new System.Drawing.Size(100, 20);
            this.eposta.TabIndex = 6;
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(133, 238);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(100, 20);
            this.sifre.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "e-posta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "şifre";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(265, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "giriş";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.eposta);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sayi2);
            this.Controls.Add(this.sayi1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataTXT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dataTXT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sayi1;
        private System.Windows.Forms.TextBox sayi2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sonuc;
        private System.Windows.Forms.TextBox eposta;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}


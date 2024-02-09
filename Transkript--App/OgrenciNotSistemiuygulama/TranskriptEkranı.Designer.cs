namespace OgrenciNotSistemiuygulama
{
    partial class TranskriptEkranı
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
            this.cbxtranskriptOgrenci = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDonem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGoster = new System.Windows.Forms.Button();
            this.lbltoplamkredi = new System.Windows.Forms.Label();
            this.lbldonemkredi = new System.Windows.Forms.Label();
            this.lblDonemortalaması = new System.Windows.Forms.Label();
            this.lblGenelOrtalama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxtranskriptOgrenci
            // 
            this.cbxtranskriptOgrenci.FormattingEnabled = true;
            this.cbxtranskriptOgrenci.Location = new System.Drawing.Point(55, 27);
            this.cbxtranskriptOgrenci.Name = "cbxtranskriptOgrenci";
            this.cbxtranskriptOgrenci.Size = new System.Drawing.Size(121, 21);
            this.cbxtranskriptOgrenci.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Öğrenci :";
            // 
            // cbxDonem
            // 
            this.cbxDonem.FormattingEnabled = true;
            this.cbxDonem.Location = new System.Drawing.Point(518, 24);
            this.cbxDonem.Name = "cbxDonem";
            this.cbxDonem.Size = new System.Drawing.Size(121, 21);
            this.cbxDonem.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dönem :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dönem Kredi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Toplam Kredi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Genel Ortalama :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Dönem Ortalaması :";
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(270, 22);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(75, 23);
            this.btnGoster.TabIndex = 18;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // lbltoplamkredi
            // 
            this.lbltoplamkredi.AutoSize = true;
            this.lbltoplamkredi.Location = new System.Drawing.Point(164, 339);
            this.lbltoplamkredi.Name = "lbltoplamkredi";
            this.lbltoplamkredi.Size = new System.Drawing.Size(13, 13);
            this.lbltoplamkredi.TabIndex = 19;
            this.lbltoplamkredi.Text = "0";
            // 
            // lbldonemkredi
            // 
            this.lbldonemkredi.AutoSize = true;
            this.lbldonemkredi.Location = new System.Drawing.Point(164, 307);
            this.lbldonemkredi.Name = "lbldonemkredi";
            this.lbldonemkredi.Size = new System.Drawing.Size(13, 13);
            this.lbldonemkredi.TabIndex = 20;
            this.lbldonemkredi.Text = "0";
            // 
            // lblDonemortalaması
            // 
            this.lblDonemortalaması.AutoSize = true;
            this.lblDonemortalaması.Location = new System.Drawing.Point(526, 307);
            this.lblDonemortalaması.Name = "lblDonemortalaması";
            this.lblDonemortalaması.Size = new System.Drawing.Size(13, 13);
            this.lblDonemortalaması.TabIndex = 21;
            this.lblDonemortalaması.Text = "0";
            // 
            // lblGenelOrtalama
            // 
            this.lblGenelOrtalama.AutoSize = true;
            this.lblGenelOrtalama.Location = new System.Drawing.Point(526, 339);
            this.lblGenelOrtalama.Name = "lblGenelOrtalama";
            this.lblGenelOrtalama.Size = new System.Drawing.Size(13, 13);
            this.lblGenelOrtalama.TabIndex = 22;
            this.lblGenelOrtalama.Text = "0";
            // 
            // TranskriptEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGenelOrtalama);
            this.Controls.Add(this.lblDonemortalaması);
            this.Controls.Add(this.lbldonemkredi);
            this.Controls.Add(this.lbltoplamkredi);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbxDonem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxtranskriptOgrenci);
            this.Controls.Add(this.label1);
            this.Name = "TranskriptEkranı";
            this.Text = "TranskriptEkranı";
            this.Load += new System.EventHandler(this.TranskriptEkranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxtranskriptOgrenci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDonem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Label lbltoplamkredi;
        private System.Windows.Forms.Label lbldonemkredi;
        private System.Windows.Forms.Label lblDonemortalaması;
        private System.Windows.Forms.Label lblGenelOrtalama;
    }
}
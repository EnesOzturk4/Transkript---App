namespace OgrenciNotSistemiuygulama
{
    partial class ogrenciyedersekle
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
            this.btnTranskriptiGör = new System.Windows.Forms.Button();
            this.btnOgrencidenderscikar = new System.Windows.Forms.Button();
            this.dgvdersekleme = new System.Windows.Forms.DataGridView();
            this.btnOgrencidersekle = new System.Windows.Forms.Button();
            this.cbxOgrenci = new System.Windows.Forms.ComboBox();
            this.cbxDonem = new System.Windows.Forms.ComboBox();
            this.cbxDers = new System.Windows.Forms.ComboBox();
            this.cbxHarfnotu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdersekleme)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTranskriptiGör
            // 
            this.btnTranskriptiGör.Location = new System.Drawing.Point(356, 341);
            this.btnTranskriptiGör.Name = "btnTranskriptiGör";
            this.btnTranskriptiGör.Size = new System.Drawing.Size(101, 23);
            this.btnTranskriptiGör.TabIndex = 23;
            this.btnTranskriptiGör.Text = "Transkript Gör";
            this.btnTranskriptiGör.UseVisualStyleBackColor = true;
            this.btnTranskriptiGör.Click += new System.EventHandler(this.btnTranskriptiGör_Click);
            // 
            // btnOgrencidenderscikar
            // 
            this.btnOgrencidenderscikar.Location = new System.Drawing.Point(186, 341);
            this.btnOgrencidenderscikar.Name = "btnOgrencidenderscikar";
            this.btnOgrencidenderscikar.Size = new System.Drawing.Size(139, 23);
            this.btnOgrencidenderscikar.TabIndex = 22;
            this.btnOgrencidenderscikar.Text = "Öğrenciden Ders Çıkar";
            this.btnOgrencidenderscikar.UseVisualStyleBackColor = true;
            this.btnOgrencidenderscikar.Click += new System.EventHandler(this.btnOgrencidenderscikar_Click);
            // 
            // dgvdersekleme
            // 
            this.dgvdersekleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdersekleme.Location = new System.Drawing.Point(56, 139);
            this.dgvdersekleme.Name = "dgvdersekleme";
            this.dgvdersekleme.Size = new System.Drawing.Size(676, 150);
            this.dgvdersekleme.TabIndex = 21;
            this.dgvdersekleme.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdersekleme_CellClick);
            this.dgvdersekleme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdersekleme_CellContentClick);
            // 
            // btnOgrencidersekle
            // 
            this.btnOgrencidersekle.Location = new System.Drawing.Point(56, 341);
            this.btnOgrencidersekle.Name = "btnOgrencidersekle";
            this.btnOgrencidersekle.Size = new System.Drawing.Size(120, 23);
            this.btnOgrencidersekle.TabIndex = 20;
            this.btnOgrencidersekle.Text = "Öğrenciye Ders Ekle";
            this.btnOgrencidersekle.UseVisualStyleBackColor = true;
            this.btnOgrencidersekle.Click += new System.EventHandler(this.btnOgrencidersekle_Click);
            // 
            // cbxOgrenci
            // 
            this.cbxOgrenci.FormattingEnabled = true;
            this.cbxOgrenci.Location = new System.Drawing.Point(56, 89);
            this.cbxOgrenci.Name = "cbxOgrenci";
            this.cbxOgrenci.Size = new System.Drawing.Size(121, 21);
            this.cbxOgrenci.TabIndex = 19;
            // 
            // cbxDonem
            // 
            this.cbxDonem.FormattingEnabled = true;
            this.cbxDonem.Location = new System.Drawing.Point(406, 86);
            this.cbxDonem.Name = "cbxDonem";
            this.cbxDonem.Size = new System.Drawing.Size(121, 21);
            this.cbxDonem.TabIndex = 18;
            // 
            // cbxDers
            // 
            this.cbxDers.FormattingEnabled = true;
            this.cbxDers.Location = new System.Drawing.Point(221, 89);
            this.cbxDers.Name = "cbxDers";
            this.cbxDers.Size = new System.Drawing.Size(121, 21);
            this.cbxDers.TabIndex = 17;
            // 
            // cbxHarfnotu
            // 
            this.cbxHarfnotu.FormattingEnabled = true;
            this.cbxHarfnotu.Location = new System.Drawing.Point(611, 86);
            this.cbxHarfnotu.Name = "cbxHarfnotu";
            this.cbxHarfnotu.Size = new System.Drawing.Size(121, 21);
            this.cbxHarfnotu.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Harf Notu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Dönem :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ders:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Öğrenci :";
            // 
            // ogrenciyedersekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTranskriptiGör);
            this.Controls.Add(this.btnOgrencidenderscikar);
            this.Controls.Add(this.dgvdersekleme);
            this.Controls.Add(this.btnOgrencidersekle);
            this.Controls.Add(this.cbxOgrenci);
            this.Controls.Add(this.cbxDonem);
            this.Controls.Add(this.cbxDers);
            this.Controls.Add(this.cbxHarfnotu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ogrenciyedersekle";
            this.Text = "ogrenciyedersekle";
            this.Load += new System.EventHandler(this.ogrenciyedersekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdersekleme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTranskriptiGör;
        private System.Windows.Forms.Button btnOgrencidenderscikar;
        private System.Windows.Forms.DataGridView dgvdersekleme;
        private System.Windows.Forms.Button btnOgrencidersekle;
        private System.Windows.Forms.ComboBox cbxOgrenci;
        private System.Windows.Forms.ComboBox cbxDonem;
        private System.Windows.Forms.ComboBox cbxDers;
        private System.Windows.Forms.ComboBox cbxHarfnotu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
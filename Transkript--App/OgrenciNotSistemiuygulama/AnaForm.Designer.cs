namespace OgrenciNotSistemiuygulama
{
    partial class AnaForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dersEkleSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transcirptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciEkleSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersEkleSilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dönemEkleSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.öğrenciTransciptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciTranscriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dersEkleSilToolStripMenuItem,
            this.transcirptToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dersEkleSilToolStripMenuItem
            // 
            this.dersEkleSilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleSilToolStripMenuItem,
            this.dersEkleSilToolStripMenuItem1,
            this.dönemEkleSilToolStripMenuItem});
            this.dersEkleSilToolStripMenuItem.Name = "dersEkleSilToolStripMenuItem";
            this.dersEkleSilToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.dersEkleSilToolStripMenuItem.Text = "Ders Ekle/Sil";
            // 
            // transcirptToolStripMenuItem
            // 
            this.transcirptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciTransciptToolStripMenuItem,
            this.öğrenciTranscriptToolStripMenuItem});
            this.transcirptToolStripMenuItem.Name = "transcirptToolStripMenuItem";
            this.transcirptToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.transcirptToolStripMenuItem.Text = "Transcript";
            // 
            // öğrenciEkleSilToolStripMenuItem
            // 
            this.öğrenciEkleSilToolStripMenuItem.Name = "öğrenciEkleSilToolStripMenuItem";
            this.öğrenciEkleSilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öğrenciEkleSilToolStripMenuItem.Text = "Öğrenci Ekle/Sil";
            this.öğrenciEkleSilToolStripMenuItem.Click += new System.EventHandler(this.öğrenciEkleSilToolStripMenuItem_Click);
            // 
            // dersEkleSilToolStripMenuItem1
            // 
            this.dersEkleSilToolStripMenuItem1.Name = "dersEkleSilToolStripMenuItem1";
            this.dersEkleSilToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dersEkleSilToolStripMenuItem1.Text = "Ders Ekle/Sil";
            this.dersEkleSilToolStripMenuItem1.Click += new System.EventHandler(this.dersEkleSilToolStripMenuItem1_Click);
            // 
            // dönemEkleSilToolStripMenuItem
            // 
            this.dönemEkleSilToolStripMenuItem.Name = "dönemEkleSilToolStripMenuItem";
            this.dönemEkleSilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dönemEkleSilToolStripMenuItem.Text = "Dönem Ekle/Sil";
            this.dönemEkleSilToolStripMenuItem.Click += new System.EventHandler(this.dönemEkleSilToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // öğrenciTransciptToolStripMenuItem
            // 
            this.öğrenciTransciptToolStripMenuItem.Name = "öğrenciTransciptToolStripMenuItem";
            this.öğrenciTransciptToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.öğrenciTransciptToolStripMenuItem.Text = "Öğrenci-Transcript";
            this.öğrenciTransciptToolStripMenuItem.Click += new System.EventHandler(this.öğrenciTransciptToolStripMenuItem_Click);
            // 
            // öğrenciTranscriptToolStripMenuItem
            // 
            this.öğrenciTranscriptToolStripMenuItem.Name = "öğrenciTranscriptToolStripMenuItem";
            this.öğrenciTranscriptToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.öğrenciTranscriptToolStripMenuItem.Text = "Öğrenci-Ders/EkleSil";
            this.öğrenciTranscriptToolStripMenuItem.Click += new System.EventHandler(this.öğrenciTranscriptToolStripMenuItem_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dersEkleSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEkleSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersEkleSilToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dönemEkleSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transcirptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciTransciptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciTranscriptToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
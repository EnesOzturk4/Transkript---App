using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotSistemiuygulama
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        private void FormGoster(Form gosterilecekForm)
        {
            gosterilecekForm.StartPosition = 0;

            if (!MdiChildren.Contains(gosterilecekForm))
            {

                gosterilecekForm.MdiParent = this;

            }
                    

            //bu formun çocukları içerisinde dönelim,istenileni görünür yapalım
            foreach (Form altForm in MdiChildren)
            {
                if (gosterilecekForm.Text == altForm.Text)
                {

                    altForm.Show();


                }
                else
                {
                    altForm.Close();
                }
            }


        }

        private void öğrenciEkleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new frm1ogrencieklesilgun());
        }

        private void dersEkleSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGoster(new DersEkranı());

        }

        private void dönemEkleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new DonemEkranı());

        }

        private void öğrenciTransciptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new TranskriptEkranı());

        }

        private void öğrenciTranscriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new ogrenciyedersekle ());

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }
    }
}

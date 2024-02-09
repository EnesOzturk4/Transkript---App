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
    public partial class DersEkranı : Form
    {
        Ders secilenDers;
        public static List<Ders> dersler=new List<Ders>();
        public DersEkranı()
        {
            InitializeComponent();
        }

        private void DersEkranı_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dersler; 
        }

        private void button1_Click(object sender, EventArgs e)//ekle
        {
            Ders ders= new Ders();

            ders.Ad = txtDersad.Text;
            ders.Kod =Convert.ToInt32( txtDerskod.Text);
            ders.Kredi = Convert.ToInt32(txtkredi.Text);
            dersler.Add(ders);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dersler;



        }

        private void button2_Click(object sender, EventArgs e)//güncelleme
        {
            if (secilenDers != null)
            {
                secilenDers.Ad=txtDersad.Text;
                secilenDers.Kod =Convert.ToInt32( txtDerskod.Text);
                secilenDers.Kredi =Convert.ToInt32( txtkredi.Text);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dersler;





            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            dersler.Remove(secilenDers);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dersler;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenDers = (Ders)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            secilenDers.Ad = txtDersad.Text;
            secilenDers.Kod = Convert.ToInt32(txtDerskod.Text);
            secilenDers.Kredi = Convert.ToInt32(txtkredi.Text);

        }
    }
}

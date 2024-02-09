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
    public partial class DonemEkranı : Form
    {
        public static List<Donem> donemler=new List<Donem>();
        Donem secilenDonem;
        public DonemEkranı()
        {
            InitializeComponent();
        }

        private void DonemEkranı_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= donemler;



        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (secilenDonem != null)
            {
                secilenDonem.Ad = txtDonemAd.Text;
                
                secilenDonem.No =  Convert.ToInt32(txtDonemno.Text);




                dataGridView1.DataSource = null;

                dataGridView1.DataSource = donemler;


            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Donem donem = new Donem();
            donem.Ad = txtDonemAd.Text;
            donem.No = Convert.ToInt32(txtDonemno.Text);
            
            donemler.Add(donem);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = donemler;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            donemler.Remove(secilenDonem);
            dataGridView1.DataSource= null;
            dataGridView1.DataSource = donemler;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            secilenDonem = (Donem)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            txtDonemAd.Text = secilenDonem.Ad;
            txtDonemno.Text = secilenDonem.No.ToString();
              
        }
    }
}

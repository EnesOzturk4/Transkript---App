using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OgrenciNotSistemiuygulama
{
    public partial class frm1ogrencieklesilgun : Form
    {   
        
        public static List<Ogrenci> ogrenciler = new List<Ogrenci>();
        Ogrenci secilenOgrenci;
        public frm1ogrencieklesilgun()
        {
            InitializeComponent();


        }
       

        private void frm1ogrencieklesilgun_Load(object sender, EventArgs e)
        {
        //  //  Ogrenci.Columns.Add("Öğrenci Adı",typeof(string));
        //    dataTable.Columns.Add("Öğrenci Soyadı",typeof(string)); 
        //    dataTable.Columns.Add("Öğrenci Numarası" ,typeof(int));
        //    dataGridView1.DataSource= dataTable;
            dataGridView1.DataSource= ogrenciler;

        }
            
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = txtAd.Text;
            ogrenci.Soyad= txtSoyad.Text;
            ogrenci.No =Convert.ToInt32(txtNumara.Text);

            

            //2021-2022



            ogrenciler.Add(ogrenci);
            //dataGridView1.Columns.Add(ogrenci);




            //dataTable.Rows.Add(txtAd.Text,txtSoyad.Text,txtNumara.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource=ogrenciler;
            
            
       
          


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenOgrenci = (Ogrenci)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            txtAd.Text = secilenOgrenci.Ad;
            txtSoyad.Text = secilenOgrenci.Soyad;
            txtNumara.Text = secilenOgrenci.No.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
          
            if (secilenOgrenci!=null)
            {
                secilenOgrenci.Ad = txtAd.Text;
                secilenOgrenci.Soyad = txtSoyad.Text;
                secilenOgrenci.No =Convert.ToInt32(txtNumara.Text);


                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ogrenciler;

                

     
                    

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //DataGridView dataGridView=new DataGridView();
            dataGridView1.DataSource=null;
            ogrenciler.Remove(secilenOgrenci);
           
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
           
        }
    }
}

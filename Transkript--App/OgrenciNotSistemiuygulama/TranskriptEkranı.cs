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
    public partial class TranskriptEkranı : Form
    {
        public static List<OgrenciDers> transkript=new List<OgrenciDers>();

        public TranskriptEkranı()
        {
            InitializeComponent();

        }

        private void TranskriptEkranı_Load(object sender, EventArgs e)
        {
            cbxtranskriptOgrenci.DataSource = frm1ogrencieklesilgun.ogrenciler;
            cbxDonem.DataSource = DonemEkranı.donemler;

             

            

              

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            Ogrenci secilenogrenci =(Ogrenci) cbxtranskriptOgrenci.SelectedItem;
            Donem secilenDonem=(Donem) cbxDonem.SelectedItem;
            

            //OgrenciDers ogrenciDers = new OgrenciDers();
            //ogrenciDers.Ogrenci = (Ogrenci)cbxtranskriptOgrenci.SelectedItem;
            //ogrenciDers.Donem = (Donem)cbxDonem.SelectedItem;


             transkript= ogrenciyedersekle.ogrencidersleri.Where(od=>od.Donem==secilenDonem && 
             od.Ogrenci==secilenogrenci).ToList();

            //lbldonemkredi.Text = ogrenciyedersekle.ogrencidersleri.Where(s=>s.Donem==secilenDonem && s.Ogrenci==secilenogrenci).Sum(s=>s.Ders.Kredi).ToString();
          
           lbltoplamkredi.Text= ogrenciyedersekle.ogrencidersleri.Where(s => s.Ogrenci == secilenogrenci).Sum(s => s.Ders.Kredi).ToString();
            
            double toplamKredi = 0;
            double tartılıkredi = 0;
            foreach (var item in ogrenciyedersekle.ogrencidersleri)
            {
                if (secilenogrenci==item.Ogrenci&&secilenDonem==item.Donem)
                {
                   toplamKredi += item.Ders.Kredi;

                   tartılıkredi+=(((int)item.HarfNotu) / 10.0) * (item.Ders.Kredi);
                }
            

            }
       
           lbldonemkredi.Text=( tartılıkredi / toplamKredi).ToString();



            dataGridView1.DataSource = null;
            dataGridView1.DataSource = transkript;  
            
            //foreach (var item in ogrenciyedersekle.ogrencidersleri)
            //{
            //    if (item.Donem==secilenDonem && item.Ogrenci==secilenogrenci)
            //    {

            //        transkript.Add(item);

            //    }
            //    dataGridView1.DataSource = transkript;

            //}
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }
    }
}

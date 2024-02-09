using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotSistemiuygulama
{
    public partial class ogrenciyedersekle : Form
    {
        OgrenciDers ogrenciders;
        public static List<OgrenciDers> ogrencidersleri = new List<OgrenciDers>();

        public ogrenciyedersekle()
        {
            InitializeComponent();

           
        



         
        }

        private void ogrenciyedersekle_Load(object sender, EventArgs e)
        {


            cbxDers.DataSource = DersEkranı.dersler;

            cbxDonem.DataSource = DonemEkranı.donemler;

            cbxOgrenci.DataSource = frm1ogrencieklesilgun.ogrenciler;


            cbxHarfnotu.DataSource = Enum.GetValues(typeof(HarfNotu));



        }

        private void dgvdersekleme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOgrencidersekle_Click(object sender, EventArgs e)
        {
            OgrenciDers ogrenciders = new OgrenciDers();

            ogrenciders.Ogrenci =(Ogrenci)cbxOgrenci.SelectedItem;
            //ogrenciders.Ogrenci.Soyad=cbxOgrenci.SelectedItem.ToString();
            ogrenciders.Ders=(Ders)cbxDers.SelectedItem; 
            ogrenciders.Donem=(Donem)cbxDonem.SelectedItem;
            ogrenciders.HarfNotu=(HarfNotu)cbxHarfnotu.SelectedItem;

            ogrencidersleri.Add(ogrenciders);

             dgvdersekleme.DataSource = null;
             dgvdersekleme.DataSource = ogrencidersleri;
                
        }

        private void btnTranskriptiGör_Click(object sender, EventArgs e)
        {
            TranskriptEkranı transkriptekran=new  TranskriptEkranı();
            transkriptekran.Show();
        }

        private void btnOgrencidenderscikar_Click(object sender, EventArgs e)
        {
            
            //dgvdersekleme.DataSource = null;

            //ogrencidersleri.Remove();
            //dgvdersekleme.DataSource = ogrencidersleri;

        }

        private void dgvdersekleme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

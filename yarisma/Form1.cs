using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yarisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bilgiYarismasiEntities db = new bilgiYarismasiEntities();

        List<Soru> sorular = new List<Soru>();
        List<Kategori> kategoriler = new List<Kategori>();
        List<Kullanici> kullanicilar = new List<Kullanici>();
        List<Karakter> karakterler = new List<Karakter>();

        private void Form1_Load(object sender, EventArgs e)
        {
            sorular= (from x in db.Sorus select x).ToList();
            kategoriler= (from x in db.Kategoris select x).ToList();
            kullanicilar= (from x in db.Kullanicis select x).ToList(); 
            karakterler = (from x in db.Karakters select x).ToList();

           
        }
    }
}

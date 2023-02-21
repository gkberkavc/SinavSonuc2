using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFSinavSonuc
{
    public partial class Form5 : Form
    {
        
        
        public string Hesapla (int ortalama)
        {
            string harfNot = "";


            if (ortalama >= 45 && ortalama < 55)
                harfNot = "DC";
            else if (ortalama >= 55 && ortalama < 65)
                harfNot = "CC";
            else if (ortalama >= 65 && ortalama < 75)
                harfNot = "BC";
            else if (ortalama >= 75 && ortalama < 85)
                harfNot = "BB";
            else if (ortalama >= 85 && ortalama < 90)
                harfNot = "BA";
            else if (ortalama >= 90)
                harfNot = "AA";

            return harfNot;
        }
        
            
  
     
       
        public string HarfNot{ get; set; }

        public int Vize { get; set; }

        public int Final { get; set; }
        

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
            txtOrtalama.Text = (((Vize*40)/100) + ((Final*60)/100)).ToString();
            txtFinalNot.Text = Final.ToString();
            txtHarfNot.Text = HarfNot.ToString();
            txtVizeNot.Text = Vize.ToString();
        }

        private void txtVizeNot_Leave(object sender, EventArgs e)
        {
            string harf = Hesapla(Convert.ToInt32( txtOrtalama.Text));
            txtVizeNot.BackColor = Color.Bisque;

            txtHarfNot.Text=harf;
        }

        private void txtFinalNot_Leave(object sender, EventArgs e)
        {
            string harf = Hesapla(Convert.ToInt32(txtOrtalama.Text));

            txtHarfNot.Text = harf;
            txtFinalNot.BackColor= BackColor = Color.Bisque;
        }
    }
}

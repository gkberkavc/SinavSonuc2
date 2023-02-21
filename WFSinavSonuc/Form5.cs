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
        
        
        public int Hesapla (int ortalama)
        {
            switch (ortalama)
            {
              case 1: ortalama <= 45 && ortalama < 55;
                    break;
                    case 2: int o =ortalama <= 55 && ortalama < 65;
                    break;
                    case 3: int o =ortalama <= 65 && ortalama < 75;
                    break;
                    case 4: int o =ortalama <= 75 && ortalama < 80;
                    break;
                    case 5: int o =ortalama <= 80 && ortalama < 85;
                    break;
                    case 6: int o =ortalama >= 85;
                    break;

                    default:0;
                    break;
            }
            return ortalama;
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
    }
}

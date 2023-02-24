using Businness.Abstract;
using DataAccess.EntityFramework;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WFSinavSonuc
{
    
    public partial class Form5 : Form
    {
        private readonly INotService _notService;
        private readonly IKullanıcıService _kullanıcıService;
        Context context = new();
        public string Hesapla (int ortalama)
        {
            string harfNot = "";
            if (ortalama < 45)
                harfNot = "FF";
            else if (ortalama >= 45 && ortalama < 55)
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
        public int NotId { get; set; }
        public Form5(INotService notService,IKullanıcıService kullanıcıService)
        {
            InitializeComponent();
            _notService = notService;
            _kullanıcıService = kullanıcıService;
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            txtOrtalama.Text = (((Vize*40)/100) + ((Final*60)/100)).ToString();
            txtFinalNot.Text = Final.ToString();
            txtHarfNot.Text = HarfNot.ToString();
            txtVizeNot.Text = Vize.ToString();
        }
        
        private bool checkInteger(string gelenString)
        {
            int numValue;
            return int.TryParse(gelenString, out numValue);
        }
        private void txtVizeNot_Leave(object sender, EventArgs e)
        {
            if (checkInteger(txtVizeNot.Text))
            {
                string harf = Hesapla(Convert.ToInt32( txtOrtalama.Text));
                txtVizeNot.BackColor = Color.Bisque;
                txtHarfNot.Text = harf;
                txtOrtalama.Clear();
                txtOrtalama.Text = (((Convert.ToInt32(txtVizeNot.Text) * 40) / 100) + ((Convert.ToInt32(txtFinalNot.Text) * 60) / 100)).ToString();
            }
            else
            {
                MessageBox.Show("Lütfen vize notunun SAYISAL bir değer giriniz");
                return;
            }
        }
        private void txtFinalNot_Leave(object sender, EventArgs e)
        {
            if (checkInteger(txtVizeNot.Text))
            {
                string harf = Hesapla(Convert.ToInt32(txtOrtalama.Text));
                txtHarfNot.Text = harf;
                txtFinalNot.BackColor = BackColor = Color.Bisque;
                txtOrtalama.Clear();
                txtOrtalama.Text = (((Convert.ToInt32(txtVizeNot.Text) * 40) / 100) + ((Convert.ToInt32(txtFinalNot.Text) * 60) / 100)).ToString();
            }
            else
            {
                MessageBox.Show("Lütfen Final notunu SAYISAL bir değer giriniz");
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            Not yeninot = _notService.GetNot(NotId);
            yeninot.VizeNot = Convert.ToInt32(txtVizeNot.Text);
            yeninot.FinalNot = Convert.ToInt32(txtFinalNot.Text);
            yeninot.HarfNot = txtHarfNot.Text.ToString();
            _notService.Update(yeninot);
            MessageBox.Show("Güncellendi");
            
            
        }
    }
}

using Businness.Abstract;
using Businness.Concrete;
using Core.Entities;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using System.Security.Cryptography;



namespace WFSinavSonuc
{

    public partial class Form1 : Form
    {

        private readonly IKullan�c�Service _kullan�c�Service;
        private readonly INotService _notService;
        private readonly IDersService _dersService;

       

        public Form1(IKullan�c�Service kullan�c�Service,INotService notService,IDersService dersService)
        {
            InitializeComponent();
            _kullan�c�Service = kullan�c�Service;
            _notService = notService;
            _dersService = dersService;
            
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string Email = txt1.Text;
            string sifre = txt2.Text;


            var kullanici = _kullan�c�Service.Get(a => a.Email == txt1.Text.ToString().Trim());

            if (kullanici != null)
            {
                if (kullanici.IsOgrenci == true)
                {
                    if (kullanici.sifre == sifre)
                    {
                        Form2 frm = new Form2();
                        frm.Form2ye_Gidecek_Veri = "Ho�geldin" + "  " + kullanici.OgrenciNo + "  " + "Numaral� ��renci";
                        frm.dataGridWiev1.DataSource = _notService.OgrenciDersNotlari(kullanici.OgrenciNo.ToString());
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("�ifre yanl��");
                        txt2.Clear();
                        return;

                    }


                }
                else
                {
                    if (kullanici.sifre == sifre)
                    {
                        Form3 frm = new Form3(_kullan�c�Service,_notService,_dersService);

                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("�ifre yanl��");
                        txt2.Clear();
                        return;
                    }
                }
            }

            else
            {
                MessageBox.Show("B�yle bir kullan�c� bulunamad�");
                return;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
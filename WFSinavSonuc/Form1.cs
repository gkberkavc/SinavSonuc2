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
<<<<<<< Updated upstream
        
        private readonly IOgrenciService _ogrenciService;
        private readonly INotService _notService;


        public Form1(IOgrenciService ogrenciService,INotService notService)
=======
        private readonly IKullan�c�Service _kullan�c�Service;
        private readonly INotService _notService;
        private readonly IDersService _dersService;
        public Form1(IKullan�c�Service kullan�c�Service,INotService notService,IDersService dersService)
>>>>>>> Stashed changes
        {
            InitializeComponent();
            _ogrenciService = ogrenciService;
            _notService = notService;
<<<<<<< Updated upstream
            
=======
            _dersService = dersService;
>>>>>>> Stashed changes
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string OgrenciNumaras� = txt1.Text;
            string sifre = txt2.Text;
<<<<<<< Updated upstream


            Ogrenci ogrenci = _ogrenciService.Get(a => a.OgrenciNo.ToString() == OgrenciNumaras�.Trim());
            if (ogrenci != null)
=======
            var kullanici = _kullan�c�Service.Get(a => a.Email == txt1.Text.ToString().Trim());
            if (kullanici != null)
>>>>>>> Stashed changes
            {
                if (ogrenci.Sifre == sifre)
                {
<<<<<<< Updated upstream
                    Form2 frm = new Form2();
                    frm.Form2ye_Gidecek_Veri ="Ho�geldin" + "  " + OgrenciNumaras� + "  " + "Numaral� ��renci"     ;
                    frm.dataGridWiev1.DataSource = _notService.OgrenciDersNotlari(ogrenci.OgrenciNo.ToString());
                    frm.ShowDialog();
=======
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
>>>>>>> Stashed changes
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
                MessageBox.Show("��renci bulunamad�");
                txt1.Clear();
                txt2.Clear();
                return;
            }
            
            
           

            
            
                
            

            
           

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
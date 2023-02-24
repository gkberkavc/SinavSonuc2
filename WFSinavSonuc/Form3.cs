using Businness.Abstract;
using Entities;
using System.Data;

namespace WFSinavSonuc
{
    public partial class Form3 : Form
    {
        private readonly IKullanıcıService _kullanıcıService;
        private readonly INotService _notService;
        private readonly IDersService _dersService;
        public Form3(IKullanıcıService kullanıcıService, INotService notService, IDersService dersService)
        {
            InitializeComponent();
            _kullanıcıService = kullanıcıService;
            _notService = notService;
            _dersService = dersService;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _kullanıcıService.GetAll().Where(a => a.IsOgrenci).ToList();
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form4 fr4 = new Form4(_notService,_kullanıcıService);
            fr4.OgrenciNo = dataGridView1.SelectedRows[0].Cells["OgrenciNo"].Value.ToString();
            
           fr4.ShowDialog();
            
        }

        private void arabaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 fr6 = new Form6(_notService, _kullanıcıService, _dersService);
            Kullanici kullanici = _kullanıcıService.GetKullanıcı(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value));
            fr6.Kullanıcı = kullanici;
            fr6.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

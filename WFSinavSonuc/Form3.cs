using Businness.Abstract;
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {




        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //dataGridView3.DataSource = _notService.GetTumNotlars();
        }


        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Form4 frm = new Form4();
            //frm.ShowDialog();

        }

        private void notDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            Form4 fr4 = new Form4(_notService);
            fr4.OgrenciNo = dataGridView1.SelectedRows[0].Cells["OgrenciNo"].Value.ToString();
           fr4.ShowDialog();


        }

        private void arabaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

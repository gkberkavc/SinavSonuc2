using Businness.Abstract;
using Businness.Concrete;
using Core.Dtos;
using Core.Entities;
using DataAccess.EntityFramework;
using Entities;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFSinavSonuc
{
    public partial class Form4 : Form
    {
      
        public string OgrenciNo { get; set; }

        private readonly INotService _notService;
        public Form4(INotService notService)
        {
            InitializeComponent();
            _notService = notService;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
          
            

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _notService.OgrenciDersNotlari(OgrenciNo);
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Not dersnot = _notService.GetNot(Convert.ToInt32( dataGridView1.SelectedRows[0].Cells["NotId"].Value));
            if(dersnot!=null)
            {

                Form5 fm5 = new Form5();
            
                fm5.Vize = dersnot.VizeNot;
                fm5.Final = dersnot.FinalNot;
                fm5.HarfNot = dersnot.HarfNot;
                fm5.ShowDialog();

            }

            else
            {
                MessageBox.Show("Böyle bir Öğrenci Mevcut değiil");
                return;

            }

        }
    }
}

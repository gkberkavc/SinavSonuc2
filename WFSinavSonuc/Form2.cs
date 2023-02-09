using Entities;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string Form2ye_Gidecek_Veri;
        private void Form2_Load(object sender, EventArgs e)
        {
            lbl3.Text = Form2ye_Gidecek_Veri;

        }
    }
}

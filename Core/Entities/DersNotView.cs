using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public  class DersNotView
    {

        public int NotId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string OgrenciNo { get; set; }
        public string DersAd { get; set; }
        public string HarfNotu { get; set; }
        public int VizeNot { get; set; }
        public int FinalNot { get; set; }

    }
}

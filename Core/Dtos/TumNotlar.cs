using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class TumNotlar
    {
        public int id { get; set; }
        public string Kullanıcı { get; set; }
        public string Ders { get; set; }
        public int VizeNot { get; set; }
        public int FinalNot { get; set; }
        public string HarfNot { get; set; }
        public DateTime AddedDate { get; set; }
    }
}

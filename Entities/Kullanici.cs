using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Kullanici : IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public string Email { get; set; }
        public string sifre { get; set; }
        public bool IsOgrenci { get; set; }
        public int? OgrenciNo { get; set; }
        public string? Bolum { get; set; }
    }
}

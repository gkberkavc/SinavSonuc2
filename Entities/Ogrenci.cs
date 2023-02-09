using Core.Entities;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Ogrenci:IEntity
    {
      
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int OgrenciNo { get; set; }
        public string Bolum { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }

        
     
    }
}

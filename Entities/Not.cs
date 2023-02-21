using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
public  class Not : IEntity
    {
        public int Id { get; set; }
        public Kullanici Kullanıcı { get; set; }

        public Ders Ders{ get; set; }
        public int VizeNot { get; set; }
        public int FinalNot { get; set; }

        public  string HarfNot { get; set; }


        public DateTime AddedDate { get; set; }
    }
}

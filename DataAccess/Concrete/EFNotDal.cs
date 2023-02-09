using Core;
using Core.Entities;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EFNotDal : IEntityRepositoryBase<Not, Context>, INotDal
    {
        public List<DersNotView> OgrenciNotlari(string ogrenciNo)
        {
            using (var _context=new Context())
            {
                var list = from notlar in _context.Notlar join ogrenci in _context.Ogrenciler on notlar.Ogrenci.Id equals
                           ogrenci.Id join ders in _context.Dersler on notlar.Ders.Id equals ders.Id
                           where ogrenci.OgrenciNo.ToString() == ogrenciNo
                           select new DersNotView { NotId = notlar.Id, Ad = ogrenci.Ad, Soyad = ogrenci.Soyad, DersAd = ders.Name, VizeNot = notlar.VizeNot, FinalNot = notlar.FinalNot, HarfNotu = notlar.HarfNot };
                          

                return list.ToList();   
            }


             

      
        }
    }
}

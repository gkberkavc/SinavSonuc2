using Core;
using Core.Dtos;
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
                var list = from notlar in _context.Notlar join ogrenci in _context.Kullanıcılar on notlar.Kullanıcı.Id equals
                           ogrenci.Id join ders in _context.Dersler on notlar.Ders.Id equals ders.Id
                           where ogrenci.OgrenciNo.ToString() == ogrenciNo
                           select new DersNotView { NotId = notlar.Id, Ad = ogrenci.Ad, Soyad = ogrenci.SoyAd, DersAd = ders.Name,   VizeNot = notlar.VizeNot, FinalNot = notlar.FinalNot, HarfNotu = notlar.HarfNot };
                          

                return list.ToList();   
            }

        }
        public List<TumNotlar> GetTumNotlars()
        {
            using (var _context = new Context())
            {
                var list = from notlar in _context.Notlar
                           select new TumNotlar
                           {
                               FinalNot = notlar.FinalNot,
                               VizeNot = notlar.VizeNot,
                               HarfNot = notlar.HarfNot,
                               Kullanıcı = notlar.Kullanıcı.Ad + " " + notlar.Kullanıcı.SoyAd,
                               Ders = notlar.Ders.Name,
                               AddedDate = notlar.AddedDate.Date,
                               id = notlar.Id
                           };
                return list.ToList();

            }
            
        }

    }
}

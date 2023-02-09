using Businness.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Concrete
{
    public class OgrenciManager:IOgrenciService
    {
        private readonly IOgrenciDal _ogrencidal;
        public OgrenciManager(IOgrenciDal ogrencidal)
        {
            _ogrencidal = ogrencidal;
        }

        public void Add(Ogrenci ogrenci)
        {
            _ogrencidal.Add(ogrenci);
        }

        public void Delete(Ogrenci ogrenci)
        {
            _ogrencidal?.Delete(ogrenci);
        }

        public Ogrenci Get(System.Linq.Expressions.Expression<Func<Ogrenci, bool>> filter)
        {
            return _ogrencidal.Get(filter);
        }

        public List<Ogrenci> GetAll()
        {
            return _ogrencidal.GetAll();
        }

        public Ogrenci GetOgrenci(int id)
        {
            return _ogrencidal.Get(a => a.Id == id);
        }

        public void Update(Ogrenci ogrenci)
        {
            _ogrencidal.Update(ogrenci);
        }
    }
}

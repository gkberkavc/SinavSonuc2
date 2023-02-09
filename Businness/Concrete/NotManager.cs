using Businness.Abstract;
using Core.Entities;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Concrete
{
    public class NotManager : INotService
    {
        private readonly INotDal _notDal;
        public NotManager(INotDal notDal)
        {
            _notDal = notDal;
        }

        public void Add(Not not)
        {
            _notDal.Add(not);
        }

        public void Delete(Not not)
        {
           _notDal.Delete(not);
        }

        public List<Not> GetAll()
        {
            return _notDal.GetAll();
        }

        public Not GetNot(int id)
        {
            return _notDal.Get(a=>a.Id == id);
        }

        public List<DersNotView> OgrenciDersNotlari(string ogrenciNo)
        {
            return _notDal.OgrenciNotlari(ogrenciNo);
        }

        public void Update(Not not)
        {
            _notDal.Update(not);
        }

      
    }
}

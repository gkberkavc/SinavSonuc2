using Businness.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Concrete
{
    public class DersManager : IDersService
    {
        private readonly IDersDal _dersDal;
        public DersManager(IDersDal dersDal)
        {

            _dersDal=dersDal;
        }
       
        public void Add(Ders ders)
        {
           _dersDal.Add(ders);
        }

        public void Delete(Ders ders)
        {
            _dersDal.Delete(ders);
        }

        public List<Ders> GetAll()
        {
           return _dersDal.GetAll();
        }

        public Ders GetDers(int id)
        {
            return _dersDal.Get(a=>a.Id == id); 
        }

        public void Update(Ders ders)
        {
          _dersDal.Update(ders);
        }
    }
}

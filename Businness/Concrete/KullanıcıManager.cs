using Businness.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Concrete
{
    public class KullanıcıManager:IKullanıcıService
    {
        private readonly IKullanıcıDal _kullanıcıdal;
        public KullanıcıManager(IKullanıcıDal kullanıcıdal)
        {
            _kullanıcıdal = kullanıcıdal;
        }
        public void Add(Kullanici kullanıcı)
        {
            _kullanıcıdal.Add(kullanıcı);
        }

        public void Delete(Kullanici kullanıcı)
        {
            _kullanıcıdal?.Delete(kullanıcı);
        }

        public Kullanici Get(System.Linq.Expressions.Expression<Func<Kullanici, bool>> filter)
        {
            return _kullanıcıdal.Get(filter);
        }

        public List<Kullanici> GetAll(Expression<Func<Kullanici, bool>> filter=null)
        {
            return _kullanıcıdal.GetAll(filter);
        }

        public Kullanici GetKullanıcı(int Id)
        {
            return _kullanıcıdal.Get(a => a.Id == Id);
        }
   

        public void Update(Kullanici kullanıcı)
        {
            _kullanıcıdal.Update(kullanıcı);
        }
    }
}

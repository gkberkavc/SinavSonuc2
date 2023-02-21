using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Businness.Abstract
{
    public interface IKullanıcıService
    {
        void Add(Kullanici kullanıcı);
        void Update(Kullanici kullanıcı);
        void Delete(Kullanici kullanıcı);
        Kullanici Get(Expression<Func<Kullanici, bool>> filter);
        List<Kullanici> GetAll(Expression<Func<Kullanici, bool>> filter=null);
        Kullanici GetKullanıcı(int Id);
        
    }
}

using Core.Entities;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Abstract
{
    public interface IOgrenciService
    {
        void Add(Ogrenci ogrenci);

        void Update(Ogrenci  ogrenci);
        void Delete(Ogrenci ogrenci);

        Ogrenci Get(Expression<Func<Ogrenci, bool>> filter);

        List<Ogrenci> GetAll();

        Ogrenci GetOgrenci(int id);
    }
}

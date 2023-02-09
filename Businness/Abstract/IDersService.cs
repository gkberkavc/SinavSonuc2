using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Abstract
{
    public interface IDersService
    {
        void Add(Ders ders);
        void Update(Ders ders);
        void Delete(Ders ders);
        List<Ders> GetAll();

        Ders GetDers(int id);   
    }
}

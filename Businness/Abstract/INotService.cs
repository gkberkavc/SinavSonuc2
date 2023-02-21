using Core.Dtos;
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
    public interface INotService
    {
        void Add(Not not);

        void Update(Not not);

        void Delete(Not not);

        List<Not> GetAll();
        Not GetNot(int id);

        List<DersNotView> OgrenciDersNotlari(string ogrenciNo);
        public List<TumNotlar> GetTumNotlars();


    }
}

using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.Entities;
using Core.Dtos;

namespace DataAccess.Abstract
{
    public interface INotDal: IEntityRepository<Not>
    {


        List<DersNotView> OgrenciNotlari(string ogrenciNo);
        public List<TumNotlar> GetTumNotlars();
    }
}

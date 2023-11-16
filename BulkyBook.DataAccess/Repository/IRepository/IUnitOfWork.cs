using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        //base property for Category in UnitOfWork
        ICategoryRepository Category { get; } //A new repository of ICategoryRepository named Category

        ICoverTypeRepository CoverType { get; }

        IProductRepository Product { get; }
        
        void Save();
    }
}

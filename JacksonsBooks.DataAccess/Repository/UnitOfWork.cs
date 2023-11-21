using JacksonsBooks.DataAccess.Repository.IRepository;
using JacksonsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksonsBooks.DataAccess.Repository
{
    public class UnitOfWork :IUnitOfWork //make the method public to the access the class
    {
        private readonly ApplicationDbContext _db; //using the statment

        public UnitOfWork(ApplicationDbContext db)  //constructor to use the DI and inject into the repositories
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
            CoverType = new CoverTypeRepository(_db);
        }

        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }
        public ICoverTypeRepository CoverType { get; private set; } 

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save() // all changes will be saved when the Save method is called at the 'parent' level
        {
            _db.SaveChanges();
        }
    }
}

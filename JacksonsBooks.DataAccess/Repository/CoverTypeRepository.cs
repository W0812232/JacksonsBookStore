using JacksonsBooks.DataAccess.Repository.IRepository;
using JacksonsBooks.Models;
using JacksonsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksonsBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            // use .Net LINQ to retrive the first or default category object,
            // then pass the id as a generic entity which makes the category ID
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null) //save changes if not null 
            {
                objFromDb.Name = coverType.Name;
                _db.SaveChanges();
            }
        }
    }
}

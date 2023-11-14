using JacksonsBooks.DataAccess.Repository.IRepository;
using JacksonsBooks.Models;
using JacksonsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JacksonsBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            // use .NET LINQ to retrive  the first or default category object
            // then pass the id as a  generic  entity which matches the category ID
            var objFromDb = _db.Categories.FirstOrDefault(s => s.id == category.id);
            if (objFromDb !=null) //save changes if not null
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }
    }
}

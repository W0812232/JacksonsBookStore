using JacksonsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace JacksonsBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}

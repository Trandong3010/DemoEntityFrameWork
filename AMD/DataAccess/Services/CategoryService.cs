using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services
{
    public interface ICategoryService
    {
        Task<IList<Categorys>> GetAll();

        Task<Categorys> GetById(int? id);


    }

    public class CategoryService : ICategoryService
    {
        protected readonly MotelRoomContext _context;

        public async Task<IList<Categorys>> GetAll()
        {
            var list = await _context.Categoryses.AsNoTracking().ToListAsync();
            return list;
        }

        public Task<Categorys> GetById(int? id)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services
{
    public class CategoryService
    {
        public MotelRoomContext _motelRoomContext = new MotelRoomContext();

        public CategoryService() { }

        public IEnumerable<Categorys> GetList()
        {
            var list = _motelRoomContext.Categoryses.ToList();
            return list;
        }

        public void Insert(Categorys category)
        {
            if (category == null) return;

            try
            {
                _motelRoomContext.Categoryses.Add(category);
                _motelRoomContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception($"Error Invalid operation performed {e.Message}");
            }
        }

        public void Update(Categorys category)
        {
            _motelRoomContext.Update<Categorys>(category);
            _motelRoomContext.SaveChanges();
        }
        
        public void Delete(int id)
        {
            if(id == 0) return;
            var list = _motelRoomContext.Categoryses.FirstOrDefault(x => x.Id == id);
            try
            {
                _motelRoomContext.Categoryses.Remove(list);
                _motelRoomContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception($"Error Invalid operation performed {e.Message}");
            }
        }
    }
}

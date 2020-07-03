using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Context;
using DataAccess.Models;

namespace DataAccess.Services
{
    public interface IRoomService
    {
        IEnumerable<Rooms> GetList();
    }

    public class RoomService : IRoomService
    {
        protected readonly MotelRoomContext _context = new MotelRoomContext();

        public IEnumerable<Rooms> GetList()
        {
            var list = _context.Roomses.ToList();
            return list;
        }

        public void Create(Rooms room, Categorys categorys)
        {
            if (room == null && categorys == null) return;

            try
            {
                room.Categorys.Add(categorys);
                _context.Roomses.Add(room);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception($"Error Invalid operation performed {e.Message}");
            }
        }
    }
}

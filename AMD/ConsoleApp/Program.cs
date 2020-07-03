using System;
using DataAccess.Models;
using DataAccess.Services;

namespace ConsoleApp
{
   public class Program
   {
       static void Main(string[] args)
        {
            CategoryService categoryService = new CategoryService();
            RoomService roomService = new RoomService();
            Console.WriteLine("=================== Category =======================");

            Console.WriteLine("Query for a Category");
            var list = categoryService.GetList();
            foreach (var item in list)
            {
                Console.WriteLine($"CategoryName: {item.CategoryName}, Description: {item.Description}");
            }
         
            Console.WriteLine("=================== Insert Category ================");
            var category = new Categorys()
            {
                CategoryName = "Apartment",
                Description = "Apartment",
                createdBy = "",
                CreatedDate = DateTime.Now,
                UpdatedBy = "",
                UpdatedDate = DateTime.Now
            };
            //categoryService.Insert(category);
            Console.WriteLine("=================== Update Category ================");
            var categorys = new Categorys()
            {
                Id = 2,
                CategoryName = "Apartment",
                Description = "Apartment",
                createdBy = "",
                CreatedDate = DateTime.Now,
                UpdatedBy = "",
                UpdatedDate = DateTime.Now
            };
            //categoryService.Update(category);
            Console.WriteLine("================== DELETE ==================");
            //categoryService.Delete(1);
            Console.WriteLine("====================================================");

            Console.WriteLine("=================== ROOMS ==========================");
            Console.WriteLine("==================== GET LIST ======================");
            var listRoomInfo = roomService.GetList();
            foreach (var item in listRoomInfo)
            {
                Console.WriteLine($"Name: {item.RoomName}");
            }

            Console.WriteLine("====================== INSERT ROOMS======================");
            var room = new Rooms()
            {
                RoomName="Room1",
                Address = "DA LAT",
                Price = 1000000,
                Description = "room 1",
                CreatedBy = "",
                CreatedDate = DateTime.Now,
                UpdatedBy = "",
                UpdatedDate = DateTime.Now,
                CategoryId = 2,
            };
            roomService.Create(room, category);
            Console.ReadKey();
        }
   }
}

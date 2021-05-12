using SpesificationDemo.Bll.Models;
using System.Collections.Generic;
using System.Linq;

namespace SpesificationDemo.Dal.Data
{

    public class DataSeeder
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (!context.Users.Any())
            {
                var users = new List<User>()
            {
                new User { Name = "Edis", Email = "edis@mail.com" },
                new User { Name = "Ekrem", Email = "ekrem@mail.com" },
                new User { Name = "Okan", Email = "okan@mail.com" }
            };
                context.Users.AddRange(users);
                context.SaveChanges();
            }
        }
    }
}

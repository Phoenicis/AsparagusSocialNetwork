/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SocialNetwork.Models;

namespace SocialNetwork.DAL
{
    public class SocialNetworkInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SocialNetworkContext>
    {
        protected override void Seed(SocialNetworkContext context)
        {
            var users = new List<User>
            {
                new User{Name = "Alexander", Email = "example@mail.ru"},
                new User{Name = "Ivan", Email = "ivan@mail.ru"}
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
            var asparaguses = new List<Asparagus>
            {
            new Asparagus{Date=DateTime.Parse("2014-09-01")},
            new Asparagus{Date=DateTime.Parse("2014-11-01")},
            };
            asparaguses.ForEach(s => context.Asparaguses.Add(s));
            context.SaveChanges();

        }
    }
}*/
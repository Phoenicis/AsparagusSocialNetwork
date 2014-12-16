using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SocialNetwork.Models;
using SocialNetwork.DAL;




namespace SocialNetwork.ViewModel
{
     
    public class NewsfeedViewModel
    {
        
        public  string Name { get; set; }
        public int Count { get; set; }

        public DateTime Date { get; set; }

        

        public static List<NewsfeedViewModel> SetupNewsfeed(IEnumerable<User> users)
        {
            List<NewsfeedViewModel> ListUser = new List<NewsfeedViewModel> { };//создаю список  пользователей
            foreach (var item in users)
            {
                if (item.Email != null)
                {
                    var thisUser = new NewsfeedViewModel();//создаю объект,который потом добавлю в список
                    thisUser.Name = item.Name;
                    thisUser.Date = item.Asparaguses.Where(sp => sp.ID == item.ID).OrderByDescending(sp => sp.Date).Skip(0).Take(1).FirstOrDefault().Date;
                    thisUser.Count = item.Asparaguses.Count;//считаю количество вхождений данного пользователя
                    if (thisUser.Date < DateTime.Now.AddDays(+1) && thisUser.Date >= DateTime.Now.AddDays(-1))
                        ListUser.Add(thisUser);
                }
                

            }
            
            return ListUser;
        }
    }
}
//var asp = item.Asparaguses.Where(apl=>apl.Email==item.Email);
//thisUser.Date = item.Asparaguses.OrderByDescending(a=>a.Date).FirstOrDefault().Date;
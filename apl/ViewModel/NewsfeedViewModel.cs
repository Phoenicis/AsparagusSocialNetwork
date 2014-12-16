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
                var thisUser = new NewsfeedViewModel();//создаю объект,который потом добавлю в список
                thisUser.Name = item.Name;
                
                thisUser.Count = item.Asparaguses.Count;//считаю количество вхождений данного пользователя
                ListUser.Add(thisUser);

            }
            
            return ListUser;
        }
    }
}
//var asp = item.Asparaguses.Where(apl=>apl.Email==item.Email);
//thisUser.Date = item.Asparaguses.OrderByDescending(a=>a.Date).FirstOrDefault().Date;
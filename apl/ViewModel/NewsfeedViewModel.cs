using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SocialNetwork.Models;



namespace SocialNetwork.ViewModel
{
    public class NewsfeedViewModel
    {
        
        public  string Name { get; set; }
        public int Count { get; set; }

        public DateTime Date { get; set; }

        public static List<NewsfeedViewModel> SetupNewsfeed(IEnumerable<User> users)
        {
            List<NewsfeedViewModel> ListUser = new List<NewsfeedViewModel> { };
            foreach (var item in users)
            {
                var thisUser = new NewsfeedViewModel();
                thisUser.Name = item.Name;
                var asp = item.Asparaguses.OrderByDescending(a => a.Date).FirstOrDefault();
                //thisUser.Date = item.Asparaguses.OrderByDescending(a=>a.Date).FirstOrDefault().Date;
                thisUser.Count = item.Asparaguses.Count;
                ListUser.Add(thisUser);

            }
            
            return ListUser;
        }
    }
}
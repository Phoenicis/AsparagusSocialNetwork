using System;
using System.Collections.Generic;

namespace SocialNetwork.Models
{
    public class Asparagus
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public virtual User User { get; set; }
        public Asparagus(User user)
        {
            this.User = user;
            this.Date = DateTime.Now;
        }

        public Asparagus()
        {

        }
        //public static Asparagus CreateWithUser()
        //{

    
        //}
    }

   
}
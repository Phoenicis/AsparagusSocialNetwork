using System;
using System.Collections.Generic;
using System.Data.Objects.DataClasses;

namespace SocialNetwork.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }



        public virtual EntityCollection<Asparagus> Asparaguses { get; set; }


        public int GetCountOfAsparagus()
        {
            return this.Asparaguses.Count;


        }

        
    }
}
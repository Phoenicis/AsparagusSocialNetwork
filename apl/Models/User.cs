using System;
using System.Collections.Generic;

namespace SocialNetwork.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }



        public virtual ICollection<Asparagus> Asparaguses { get; set; }
    }
}
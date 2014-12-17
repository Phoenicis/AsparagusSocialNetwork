using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialNetwork.Models
{
    public class User
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }


        [EmailAddress]
        public string Email { get; set; }

        public virtual ICollection<Asparagus> Asparaguses { get; set; }
    }
}
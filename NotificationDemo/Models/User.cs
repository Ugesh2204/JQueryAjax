using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationDemo.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public String UserName { get; set; }

       
    }
}

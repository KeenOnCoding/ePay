using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestTask.Data.Models
{
    public class User : IdentityUser
    {
        #region Constructor

        public User()
        {
        }

        #endregion Constructor

        #region Properties

        public string Picture { get; set; }
        public string Gender { get; set; }
        public string Company { get; set; }

        [Phone]
        public string Phone { get; set; }

        public string Address { get; set; }
        public string About { get; set; }
        public DateTime Registered { get; set; }
        public virtual IEnumerable<Tag> Tags { get; set; }

        #endregion Properties
    }
}
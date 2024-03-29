﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetAppTemp.Models
{
    public class Role : IdentityRole
    {
        public Role() : base()
        {

        }

        public Role(string roleName) : base(roleName)
        {

        }

        public Role(string roleName, string description, string normalizedName, DateTime creationDate) : base(roleName)
        {
            this.Description = description;
            this.CreationDate = creationDate;
            this.NormalizedName = normalizedName;
        }

        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}

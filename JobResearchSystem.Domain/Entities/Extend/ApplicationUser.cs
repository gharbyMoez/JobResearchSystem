﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobResearchSystem.Domain.Entities.Extend
{
    public class ApplicationUser : IdentityUser
    {


        /*----- Relations -----*/

        [ForeignKey(nameof(JobSeeker))]
        public int? JobSeekerId { get; set; }
        public JobSeeker? JobSeeker { get; set; }

        //////////////////

        [ForeignKey(nameof(Company))]
        public int? CompanyId { get; set; }
        public Company? Company { get; set; }

        //////////////////

        [ForeignKey(nameof(UserType))]
        public int UserTypeId { get; set; }
        public UserType UserType { get; set; }
    }
}

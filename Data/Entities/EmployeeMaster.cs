﻿using System;
using System.Collections.Generic;

namespace DeviceManager.Api.Database
{
    public partial class EmployeeMaster
    {
        public EmployeeMaster()
        {
            EmployeeCourseMapping = new HashSet<EmployeeCourseMapping>();
            RatingMaster = new HashSet<RatingMaster>();
            UserComments = new HashSet<UserComments>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string EmailId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserMastercol { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageUrl { get; set; }
        public int? FkProfileId { get; set; }
        public DateTime? PasswordExpiryDate { get; set; }
        public string PasswordResetToken { get; set; }
        public bool? IsLocked { get; set; }
        public int? LoginFailureCount { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? TokenExpiryDate { get; set; }
        public string LastPassword { get; set; }

        public virtual ProfileMaster FkProfile { get; set; }
        public virtual ICollection<EmployeeCourseMapping> EmployeeCourseMapping { get; set; }
        public virtual ICollection<RatingMaster> RatingMaster { get; set; }
        public virtual ICollection<UserComments> UserComments { get; set; }
    }
}

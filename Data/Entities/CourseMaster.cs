﻿using System;
using System.Collections.Generic;

namespace DeviceManager.Api.Database
{
    public partial class CourseMaster
    {
        public CourseMaster()
        {
            CourseAttachment = new HashSet<CourseAttachment>();
            CourseCertificateMapping = new HashSet<CourseCertificateMapping>();
            EmployeeCourseMapping = new HashSet<EmployeeCourseMapping>();
            ProfileCourseMapping = new HashSet<ProfileCourseMapping>();
            RatingMaster = new HashSet<RatingMaster>();
            UserComments = new HashSet<UserComments>();
        }

        public int Id { get; set; }
        public int? FkCourseDetailsId { get; set; }
        public int? FkLevelId { get; set; }
        public bool? HasAttachment { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual CourseDetails FkCourseDetails { get; set; }
        public virtual LevelMaster FkLevel { get; set; }
        public virtual ICollection<CourseAttachment> CourseAttachment { get; set; }
        public virtual ICollection<CourseCertificateMapping> CourseCertificateMapping { get; set; }
        public virtual ICollection<EmployeeCourseMapping> EmployeeCourseMapping { get; set; }
        public virtual ICollection<ProfileCourseMapping> ProfileCourseMapping { get; set; }
        public virtual ICollection<RatingMaster> RatingMaster { get; set; }
        public virtual ICollection<UserComments> UserComments { get; set; }
    }
}

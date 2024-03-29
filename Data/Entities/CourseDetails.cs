﻿using System;
using System.Collections.Generic;

namespace DeviceManager.Api.Database
{
    public partial class CourseDetails
    {
        public CourseDetails()
        {
            CourseMaster = new HashSet<CourseMaster>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<CourseMaster> CourseMaster { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace DeviceManager.Api.Database
{
    public partial class CertificateMaster
    {
        public CertificateMaster()
        {
            CourseCertificateMapping = new HashSet<CourseCertificateMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? FkTemplateId { get; set; }
        public int? FkLevelId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual LevelMaster FkLevel { get; set; }
        public virtual TemplateMaster FkTemplate { get; set; }
        public virtual ICollection<CourseCertificateMapping> CourseCertificateMapping { get; set; }
    }
}

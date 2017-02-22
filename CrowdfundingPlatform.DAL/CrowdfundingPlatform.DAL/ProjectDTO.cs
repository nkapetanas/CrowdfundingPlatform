//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrowdfundingPlatform.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProjectDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProjectDTO()
        {
            this.FundingPackageDtoes = new HashSet<FundingPackageDto>();
            this.ProjectUpdateDtoes = new HashSet<ProjectUpdateDto>();
            this.ProjectStatsDtoes = new HashSet<ProjectStatsDto>();
            this.ProjectCommentDtoes = new HashSet<ProjectCommentDto>();
        }
    
        public long ProjectId { get; set; }
        public string ProjectCategoryDesc { get; set; }
        public Nullable<long> AttachmentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public System.DateTime FundingEndDate { get; set; }
        public decimal FundingGoal { get; set; }
        public string Status { get; set; }
        public string OwnerName { get; set; }
        public Nullable<long> OwnerId { get; set; }
        public string MainPhoto { get; set; }
        public long CategoryId { get; set; }
        public string AspNetUserId { get; set; }
    
        public virtual ProjectCategoryDto ProjectCategoryDto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FundingPackageDto> FundingPackageDtoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectUpdateDto> ProjectUpdateDtoes { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectStatsDto> ProjectStatsDtoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectCommentDto> ProjectCommentDtoes { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ResumeEditor.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class MasterExperienceType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MasterExperienceType()
        {
            this.TransactionExperienceTimelines = new HashSet<TransactionExperienceTimeline>();
        }
    
        public int Id { get; set; }
        public string ExperienceType { get; set; }
        public string ExperienceTypeTitle { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionExperienceTimeline> TransactionExperienceTimelines { get; set; }
    }
}
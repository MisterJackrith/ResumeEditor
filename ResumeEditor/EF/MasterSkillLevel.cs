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
    
    public partial class MasterSkillLevel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MasterSkillLevel()
        {
            this.TransactionOwnerSkills = new HashSet<TransactionOwnerSkill>();
        }
    
        public int Id { get; set; }
        public int SkillLevelId { get; set; }
        public string SkillLevelTitle { get; set; }
        public Nullable<double> SkillLevelScore { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionOwnerSkill> TransactionOwnerSkills { get; set; }
    }
}

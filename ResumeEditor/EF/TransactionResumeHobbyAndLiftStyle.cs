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
    
    public partial class TransactionResumeHobbyAndLiftStyle
    {
        public int Id { get; set; }
        public string ResumeDocumentId { get; set; }
        public string HobbyId { get; set; }
        public string OwnerId { get; set; }
    
        public virtual TransactionOwnerHobbyAndLiftStyle TransactionOwnerHobbyAndLiftStyle { get; set; }
        public virtual TransactionResumeDocument TransactionResumeDocument { get; set; }
    }
}

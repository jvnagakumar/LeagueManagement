//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMEntities
{
    using System;
    
    public partial class GetTeamManagement_Result
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public int TitleId { get; set; }
        public string TitleName { get; set; }
        public int TeamMemberId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string TeamMemberName { get; set; }
    }
}
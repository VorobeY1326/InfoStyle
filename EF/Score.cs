//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Score
    {
        public System.Guid Id { get; set; }
        public System.Guid TaskId { get; set; }
        public int UserId { get; set; }
        public int Value { get; set; }
    
        public virtual User User { get; set; }
    }
}

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
    
    public partial class Task
    {
        public System.Guid Id { get; set; }
        public Enums.TaskType Type { get; set; }
        public string Text { get; set; }
        public int Level { get; set; }
    }
}

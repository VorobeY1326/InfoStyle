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
    
    public partial class User
    {
        public User()
        {
            this.DailyCompares = new HashSet<DailyCompare>();
            this.DailyEdits = new HashSet<DailyEdit>();
            this.Scores = new HashSet<Score>();
            this.User_Tasks = new HashSet<User_Tasks>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public System.DateTime LastDailyEditTime { get; set; }
        public string VKLogin { get; set; }
    
        public virtual ICollection<DailyCompare> DailyCompares { get; set; }
        public virtual ICollection<DailyEdit> DailyEdits { get; set; }
        public virtual ICollection<Score> Scores { get; set; }
        public virtual ICollection<User_Tasks> User_Tasks { get; set; }
    }
}

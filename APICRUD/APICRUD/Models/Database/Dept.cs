//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APICRUD.Models.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dept
    {
        public Dept()
        {
            this.Students = new HashSet<Student>();
        }
    
        public int deptId { get; set; }
        public string deptName { get; set; }
    
        public virtual ICollection<Student> Students { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinfocusLearningApp.DataEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblRegistrationBatchTime
    {
        public int Id { get; set; }
        public string BatchTime { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public int IsDeleted { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public int ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public string Description { get; set; }
    }
}

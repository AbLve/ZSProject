//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class base_class
    {
        [Key]
        public int class_id { get; set; }
        [MaxLength(100)]
        public string class_name { get; set; }
        public int school_id { get; set; }
        [MaxLength(255)]
        public string description { get; set; }
    }
}

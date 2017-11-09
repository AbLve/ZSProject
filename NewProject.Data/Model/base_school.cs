//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewProject.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class base_school
    {
        [Key]
        public int school_id { get; set; }
        [MaxLength(100)]
        public string school_name { get; set; }
        public string type { get; set; }
        [MaxLength(100)]
        public string province { get; set; }
        [MaxLength(100)]
        public string county { get; set; }
        [MaxLength(100)]
        public string city { get; set; }
        [MaxLength(255)]
        public string address { get; set; }
        [MaxLength(100)]
        public string longitude { get; set; }
        [MaxLength(100)]
        public string latitude { get; set; }
        [MaxLength(100)]
        public string phone_number { get; set; }
        public int? dealer_id { get; set; }
        [MaxLength(255)]
        public string description { get; set; }


    }
}

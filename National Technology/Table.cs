//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace National_Technology
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Table
    {
        public int UserID { get; set; }
        [Required(ErrorMessage = "Please Provide your Password", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public int Password { get; set; }
        [Required(ErrorMessage = "Please Provide your Full name", AllowEmptyStrings = false)]
        public string Fullname { get; set; }
        [Required(ErrorMessage ="Please Provide your User name",AllowEmptyStrings =false)]
        public string UserName { get; set; }

    }
}

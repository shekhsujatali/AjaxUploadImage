//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AjaxUploadImage.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_uploadImage
    {
        public int ImageId { get; set; }
        public string ImageOldName { get; set; }
        public string ImageNewName { get; set; }
        public string ImagePath { get; set; }
        public string ImageBytes { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}

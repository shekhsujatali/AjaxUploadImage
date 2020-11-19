using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxUploadImage.ViewModel
{
    public class ImageViewModel
    {
        public string ImageDesc { get; set; }
        public HttpPostedFileWrapper FileImage { get; set; }
    }
}
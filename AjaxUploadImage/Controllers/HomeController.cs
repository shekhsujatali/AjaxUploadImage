using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxUploadImage.ViewModel;
using System.IO;
using AjaxUploadImage.Models;

namespace AjaxUploadImage.Controllers
{
    public class HomeController : Controller
    {
        private UploadImage_AjaxEntities UploadImage_AjaxEntities;
        public HomeController()
        {
            UploadImage_AjaxEntities = new UploadImage_AjaxEntities();
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Index(ImageViewModel imageViewModel)
        {
            var filename = imageViewModel.FileImage;
            filename.SaveAs(Server.MapPath("~/Images/") + Guid.NewGuid() + Path.GetExtension(filename.FileName));

            byte[] imgbyte = null;
            BinaryReader reader = new BinaryReader(filename.InputStream);
            imgbyte = reader.ReadBytes(filename.ContentLength);
            tbl_uploadImage tbl_UploadImage = new tbl_uploadImage();

            tbl_UploadImage.Description = imageViewModel.ImageDesc;
            tbl_UploadImage.ImageBytes = imgbyte.ToString();
            tbl_UploadImage.ImageNewName = Guid.NewGuid() + Path.GetExtension(filename.FileName);
            tbl_UploadImage.ImageOldName = filename.FileName;
            tbl_UploadImage.ImagePath = "~/Images/";
            tbl_UploadImage.IsActive = true;

            UploadImage_AjaxEntities.tbl_uploadImage.Add(tbl_UploadImage);
            UploadImage_AjaxEntities.SaveChanges();

            return Json(new { success = true, message = "Image Uploaded" }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
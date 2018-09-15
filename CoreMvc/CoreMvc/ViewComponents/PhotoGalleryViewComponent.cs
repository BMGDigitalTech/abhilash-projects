using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvc.ViewComponents
{
    public class PhotoGalleryViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(int n)
        {
            List<string> AllImages = new List<string>() { "/images/img1.jpg", "/images/img2.jpg", "/images/img3.jpg", "/images/img4.jpg", "/images/img5.jpg", "/images/img6.jpg", "/images/img7.jpg", "/images/img8.jpg", "/images/img9.jpg", "/images/img10.jpg" };
            List<string> SelectedImages = AllImages.Take(n).ToList();
            ViewBag.myImages = SelectedImages;
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SV20T1020607.Wed.Controllers
{
    public class ProductController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            ViewBag.Title = "Bổ sung mặt hàng";
            ViewBag.IsEdit = false;
            return View("Edit");
        }

        public IActionResult Edit(string id)
        {
            ViewBag.Title = "Cập nhật thông tin mặt hàng";
            ViewBag.IsEdit = true;
            return View();
        }
        public IActionResult Delete(string id)
        {
            ViewBag.Title = "Xóa mặt hàng";
            return View();
        }
        public IActionResult Photo(string id,string method, int photoID=0)
        {
            switch (method)
            {
                case "add":
                    ViewBag.Title = "Bổ sung ảnh cho mặt hàng";
                    ViewBag.IsEdit = true;
                    return View();
                case "edit":
                    ViewBag.Title = "Cập nhật ảnh cho mặt hàng";
                    ViewBag.IsEdit = false;
                    return View();
                case "delete":
                    //TODO: Xóa ảnh có mã là photoId(Xóa trực tiếp,không cần xác nhận
                    return RedirectToAction("Edit", new { id = id });
                default:
                    return RedirectToAction("Index");
            }
        }
        public IActionResult Attribute(string id, string method, int attributeId = 0)
        {
            switch (method)
            {
                case "add":
                    ViewBag.Title = "Bổ sung thuộc tính cho mặt hàng";
                    
                    return View();
                case "edit":
                    ViewBag.Title = "Cập nhật thuộc tính cho mặt hàng";
                    
                    return View();
                case "delete":
                    //TODO: Xóa ảnh có mã là photoId(Xóa trực tiếp,không cần xác nhận
                    return RedirectToAction("Edit", new { id = id });
                default:
                    return RedirectToAction("Index");
            }
        }


    }

}


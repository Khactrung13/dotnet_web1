    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SV20T1020067.BusinessLayers;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SV20T1020607.Wed.Controllers
{
    public class CustomerController : Controller
    {
        const int PAGE_SIZE = 20;
        // GET: /<controller>/
        public IActionResult Index(int page  = 1 , string searchValue="")
        {
            int rowCount = 0;
            var data = CommonDataService.ListOfCustomers(out rowCount, page, PAGE_SIZE, searchValue ?? "");
           
            var model = new Models.CustomerSearchResult()
            {
                Page = page,
                PageSize = PAGE_SIZE,
                SearchValue = searchValue ?? "",
                RountCount = rowCount,
                Data = data
            };
           
            return View(model);
        }

        public IActionResult Create()
        {
            ViewBag.Title = "Bổ sung khách hàng";
            ViewBag.IsEdit = false;
            return View("Edit");
        }

        public IActionResult Edit(string id)
        {
            ViewBag.Title = "Cập nhật thông tin khách hàng";
            ViewBag.IsEdit = true;
            return View();
        }
        public IActionResult Delete(string id)
        {
            return View();
        }

    }
}


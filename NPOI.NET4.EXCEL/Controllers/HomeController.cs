using NPOI.NET4.EXCEL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace NPOI.NET4.EXCEL.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            for (int i = 0; i < 10; i++)
            {
                users.Add(new Models.User() { ID = i });
            }
        }

        List<User> users;
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        //http://localhost:53581/Home/GetTest
        [HttpGet]
        public string GetTest()
        {
            return "连接成功!";
        }


        [HttpGet]

        public async Task<FileResult> GetExcel()
        {
            using (Stream stream = await Task.Run(TableToExcelByNPOI))
            {




                var actionresult = new FileStreamResult(stream, "text/csv");
                return actionresult;
            }
        }

        private Stream TableToExcelByNPOI()
        {
            MemoryStream ms = new MemoryStream();


            return ms;
        }
    }
}

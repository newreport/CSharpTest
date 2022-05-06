using NPOI.HSSF.UserModel;
using NPOI.NET4.EXCEL.Models;
using NPOI.SS.UserModel;
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
        List<User> users;

        public HomeController()
        {
            users = new List<User>();
            for (int i = 0; i < 10; i++)
            {
                users.Add(new Models.User() { ID = i });
            }
        }

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

        //http://localhost:53581/Home/GetExcel
        [HttpGet]
        public async Task<FileResult> GetExcel()
        {
            Stream stream = await Task.Run(TableToExcelByNPOI);

            stream.Position = 0;//将stream开始读取位置置为0


            var actionresult = new FileStreamResult(stream, "text/csv");
            return actionresult;

        }

        private Stream TableToExcelByNPOI()
        {
            MemoryStream ms = new MemoryStream();

            //新建工作簿
            HSSFWorkbook workbook = new HSSFWorkbook();
            foreach (var item in users)
            {
                //新建工作表
                ISheet sheet = workbook.CreateSheet(item.ID.ToString());
                IRow row1 = sheet.CreateRow(0);
                row1.CreateCell(0).SetCellValue(item.Name);
                int i = 1;
                foreach (var it in item.details)
                {
                    IRow rowTemp = sheet.CreateRow(i);
                    rowTemp.Height = 62 * 20;
                    rowTemp.CreateCell(0).SetCellValue(it.ID);
                    rowTemp.CreateCell(1).SetCellValue(it.createTime);
                    i++;
                }
            }
            workbook.Write(ms);
            return ms;
        }
    }
}

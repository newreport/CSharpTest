using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NPOI.NET4.EXCEL.Models
{
    public class User
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public bool Sex { get; set; }

        public List<Details> details { get; set; }

        public User()
        {
            Name = "名称" + new Random().Next();
            Age = new Random().Next(1, 99);
            Sex = new Random().Next() % 2 == 1 ? true : false;
            details = new List<Details>();
            for (int i = 0; i < Age; i++)
            {
                details.Add(new Details()
                {
                    ID = i,
                    createTime = DateTime.Now,
                    Txt = "随机文本" + new Random().Next()
                });
            }
        }
    }
}
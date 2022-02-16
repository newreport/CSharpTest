using EF_MySQL.DAL;
using EF_MySQL.Modules;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_MySQL.BLL
{
    public class BLL_ClassGrade
    {
        public DataTable QueryAll()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ClassId", typeof(int));
            dt.Columns.Add("ClassName", typeof(string));
            foreach (var item in new DAL_ClassGrade().QueryAll())
            {
                dt.Rows.Add(item.Id, item.ClassName);
            }
            return dt;
        }
    }
}

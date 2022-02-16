using EF_MySQL.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_MySQL.DAL
{
    public class DAL_ClassGrade
    {
        public List<ClassGrade> QueryAll()
        {
            using (var db = new DBModel())
            {
                var result = (from classGrades in db.ClassGrade
                              select classGrades).ToList();
                return result;
            }
        }
    }
}

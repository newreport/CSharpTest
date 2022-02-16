using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_MySQL.Modules
{
    public class DBModel : DbContext
    {

        public DbSet<ClassGrade> ClassGrade { get; set; }
        public DbSet<Student> Student { get; set; }

        //配置连接字符串
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=newreportTest321;database=ef_test;Character Set=utf8;", new MySqlServerVersion(new Version(8, 0, 26)));
        }

        //创建时配置
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }
    }
    public class ClassGrade
    {
        public int Id { get; set; }

        public string ClassName { get; set; }
    }
    [Table("student")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 外键
        /// </summary>
        public int ClassGradeId { get; set; }
    }



}

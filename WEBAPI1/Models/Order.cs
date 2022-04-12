using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEBAPI1.Models
{
    public class Order
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        [Key]
        public int OrderId
        {
            get; set;
        }
        /// <summary>
        /// 外键
        /// </summary>
       [ForeignKey("Id")]
        public int MainId { get; set; }
        /// <summary>
        /// 订单名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 订单类对象
        /// </summary>
        public string ClsType { get; set; }
    }
}

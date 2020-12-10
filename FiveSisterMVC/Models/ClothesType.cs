using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveSisterMVC.Models
{
    public class ClothesType
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int ClothesTypeId { get; set; }
        /// <summary>
        /// 品牌名称
        /// </summary>
        public string ClothesTypeName { get; set; }
        /// <summary>
        /// 类型父Id
        /// </summary>
        public int ClothesTypePid { get; set; }
    }
}

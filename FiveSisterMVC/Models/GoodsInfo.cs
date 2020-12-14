using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveSisterMVC.Models
{
    public class GoodsInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int GoodsInfoId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsInfoName { get; set; }
        /// <summary>
        /// 商品图片
        /// </summary>
        public string GoodsInfoImage { get; set; }
        /// <summary>
        /// 商品单价
        /// </summary>
        public string GoodsInfoPrice { get; set; }
        /// <summary>
        /// 商品售出数量
        /// </summary>
        public int GoodsInfoCount { get; set; }
        /// <summary>
        /// 商品是否上架
        /// </summary>
        public int GoodsInfoState { get; set; }
        /// <summary>
        /// 商品出产地
        /// </summary>
        public string GoodsInfoPlace { get; set; }
        /// <summary>
        /// 商品颜色
        /// </summary>
        public string GoodsInfoColor { get; set; }
        /// <summary>
        /// 商品规格
        /// </summary>
        public string GoodsInfoSize { get; set; }
        /// <summary>
        /// 所属店铺
        /// </summary>
        public int ShopIdOut { get; set; }
        /// <summary>
        /// 商品类型
        /// </summary>
        public string GoodsTypes { get; set; }
        /// <summary>
        /// 商品简介
        /// </summary>
        public string GoodsInfoDesc { get; set; }
        /// <summary>
        /// 商品品牌
        /// </summary>
        public string GoodsBrand { get; set; }
        /// <summary>
        /// 商品级别
        /// </summary>
        public int GoodsJb { get; set; }
    }
}

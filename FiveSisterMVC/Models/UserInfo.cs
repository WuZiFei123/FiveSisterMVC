using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveSisterMVC.Models
{
    public class UserInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int UserInfoId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>

        public string UserInfoName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string UserInfoPass { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string UserInfoSex { get; set; }
        /// <summary>
        /// 密保
        /// </summary>
        public string UserInfoLetter { get; set; }
        /// <summary>
        /// 收货地址
        /// </summary>
        public string UserInfoTake { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string UserInfoPhone { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string UserInfoEmil { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string UserInfoHead { get; set; }
    }
}

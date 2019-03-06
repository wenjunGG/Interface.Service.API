using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Interface.Service.Model.SysModel
{

    [Table("T_SYS_USER")]
    public class SysUser : DbSetBase
    {
        public SysUser()
        {
            Enabled = true;
        }

        /// <summary>
        /// 工号
        /// </summary>
        [MaxLength(50)]
        [MinLength(3)]
        [Required]

        public string WorkerId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [MaxLength(50)]
        [Required]
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [MaxLength(50)]
        [MinLength(5)]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// 旧密码
        /// </summary>
        [MaxLength(50)]
        [HiddenInput(DisplayValue = false)]
        public string OldPassword { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string prefix_eng { get; set; }

        /// <summary>
        /// 名
        /// </summary>
        public string f_name_eng { get; set; }
        /// <summary>
        /// 姓
        /// </summary>
        public string l_name_eng { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        [DataType("Picture")]
        [MaxLength(200)]
        public string Picture { get; set; }

        /// <summary>
        /// 手机
        /// </summary>
        [MaxLength(50)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [MaxLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        /// <summary>
        /// 是否有效
        /// </summary>
        public bool Enabled { get; set; }
    }
}


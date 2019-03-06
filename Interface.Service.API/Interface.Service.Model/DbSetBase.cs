using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Interface.Service.Model
{
    public interface IDbSetBase
    {
        /// <summary>
        /// Id
        /// </summary>
        Guid Id { get; set; }
        /// <summary>
        /// 项目Id
        /// </summary>
        Guid ProjectId { set; get; }
        /// <summary>
        /// 企业Id
        /// </summary>
        Guid EnterpriseId { get; set; }
        /// <summary>
        /// 创建用户
        /// </summary>
        Guid? UserId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        DateTime CreatedDate { get; set; }
        /// <summary>
        /// 最后更新用户
        /// </summary>
        Guid? UpdatedUserId { get; set; }
        /// <summary>
        /// 最后更新时间
        /// </summary>
        DateTime UpdatedDate { get; set; }
        /// <summary>
        /// 删除标识
        /// </summary>
        bool Deleted { get; set; }
    }

    public abstract class DbSetBase : IDbSetBase
    {
        protected DbSetBase()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            Deleted = false;
        }

        [MaxLength(200)]
        [DataType(DataType.MultilineText)]
        //[Display(Name = "Remark", ResourceType = typeof(LangResources.Resource))]

        public string Remark { get; set; }

        [Key]
        [ScaffoldColumn(false)]
        [Display(Name = "Id")]
        public Guid Id { get; set; }

        [HiddenInput(DisplayValue = false)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [ScaffoldColumn(false)]
        //[Display(Name = "UpdatedDate", ResourceType = typeof(LangResources.Resource))]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime UpdatedDate { get; set; }

        [ScaffoldColumn(false)]
        //[Display(Name = "ProjectId", ResourceType = typeof(LangResources.Resource))]
        public Guid ProjectId { get; set; }

        [ScaffoldColumn(false)]
        //[Display(Name = "EnterpriseId", ResourceType = typeof(LangResources.Resource))]
        public Guid EnterpriseId { get; set; }

        [ScaffoldColumn(false)]
        //[Display(Name = "CreatedUserId", ResourceType = typeof(LangResources.Resource))]
        public Guid? UserId { get; set; }

        [ScaffoldColumn(false)]
        //[Display(Name = "UpdatedUserId", ResourceType = typeof(LangResources.Resource))]
        public Guid? UpdatedUserId { get; set; }


        [ScaffoldColumn(false)]
        //[Display(Name = "Deleted", ResourceType = typeof(LangResources.Resource))]
        public bool Deleted { get; set; }

    }
}

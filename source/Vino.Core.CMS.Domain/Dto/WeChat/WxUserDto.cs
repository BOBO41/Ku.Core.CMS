using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vino.Core.Infrastructure.Attributes;
using Vino.Core.Infrastructure.Data;

namespace Vino.Core.CMS.Domain.Dto.WeChat
{
    public class WxUserDto : BaseDto
    {
        /// <summary>
        /// ���ں�ID
        /// </summary>
        [DataType("Hidden")]
        public long AccountId { get; set; }

        public WxAccountDto Account { get; set; }

        [MaxLength(64), Required]
        [Display(Name = "OpenId")]
        public string OpenId { set; get; }

        [MaxLength(64)]
        [Display(Name = "UnionId")]
        public string UnionId { set; get; }

        [MaxLength(100)]
        [Display(Name = "�ǳ�")]
        public string NickName { set; get; }

        [MaxLength(500)]
        [Display(Name = "ͷ��")]
        public string HeadImgUrl { set; get; }

        [Display(Name = "�Ա�")]
        public string Sxe { set; get; }

        [MaxLength(100)]
        [Display(Name = "����")]
        public string Country { set; get; }

        [MaxLength(100)]
        [Display(Name = "ʡ��")]
        public string Province { set; get; }

        [MaxLength(100)]
        [Display(Name = "����")]
        public string City { set; get; }

        [MaxLength(20)]
        [Display(Name = "����")]
        public string Language { set; get; }

        [MaxLength(30)]
        [Display(Name = "��ע��")]
        public string Remark { set; get; }

        /// <summary>
        /// ��עʱ��
        /// </summary>
        [Display(Name = "��עʱ��")]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd HH:mm:ss")]
        [DataType(DataType.DateTime)]
        public DateTime? SubscribeTime { set; get; }

        /// <summary>
        /// �û���ǩ
        /// </summary>
        [MaxLength(256)]
        [Display(Name = "�û���ǩ")]
        public string UserTags { get; set; }
    }
}

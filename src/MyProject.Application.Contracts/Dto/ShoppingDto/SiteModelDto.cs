using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace MyProject.Dto.ShoppingDto
{
    public class SiteModelDto : AuditedEntityDto<Guid>
    {
        public string AddrName { get; set; }//地址名
        public Guid AddrFatherId { get; set; }//上级id
        public string DetailedAddr { get; set; }//详细地址
        public bool State { get; set; }//是否默认
    }
}

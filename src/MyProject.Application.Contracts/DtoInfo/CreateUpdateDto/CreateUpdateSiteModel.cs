using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MyProject.DtoInfo.CreateUpdateDto
{
    public class CreateUpdateSiteModel : AuditedEntityDto<Guid>
    {
        public string AddrName { get; set; }//地址名
        public Guid AddrFatherId { get; set; }//上级id
        public string DetailedAddr { get; set; }//详细地址
        public bool State { get; set; }//是否默认
    }
}

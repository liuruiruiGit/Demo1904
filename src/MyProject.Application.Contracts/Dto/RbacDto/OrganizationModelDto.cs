using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MyProject.Dto.RbacDto
{
    public class OrganizationModelDto : AuditedEntityDto<Guid>
    {
        public Guid FatherId { get; set; }//上级id
        public string OrganizationName { get; set; }//组织名称
        public DateTime CreateDate { get; set; }//创建时间
        public string OrganizationMessage { get; set; }//组织描述
    }
}

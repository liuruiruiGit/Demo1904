using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MyProject.Dto.RbacDto
{
    public  class RoleMenuModelDto : AuditedEntityDto<Guid>
    {
        public Guid RoleId { get; set; }//角色id
        public Guid MenuId { get; set; }//权限id
    }
}

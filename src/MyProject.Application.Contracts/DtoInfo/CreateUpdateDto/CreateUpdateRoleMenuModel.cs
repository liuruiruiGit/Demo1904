using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MyProject.DtoInfo.CreateUpdateDto
{
    public class CreateUpdateRoleMenuModel : AuditedEntityDto<Guid>
    {
        public Guid RoleId { get; set; }//角色id
        public Guid MenuId { get; set; }//权限id
    }
}

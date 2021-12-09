using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MyProject.DtoInfo.CreateUpdateDto
{
    public class CreateUpdateUserRoleModel : AuditedEntityDto<Guid>
    {
        public Guid UserId { get; set; }//用户id
        public Guid RoleId { get; set; }//角色id
    }
}

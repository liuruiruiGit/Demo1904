using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.DtoInfo.CreateUpdateDto
{
    public class CreateUpdateRoleMenuModel
    {
        public Guid RoleId { get; set; }//角色id
        public Guid MenuId { get; set; }//权限id
    }
}

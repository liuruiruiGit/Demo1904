using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyProject.Rbac
{
    public class UserRoleModel : AuditedAggregateRoot<Guid>
    {
        public Guid UserId { get; set; }//用户id
        public Guid RoleId { get; set; }//角色id
    }
}

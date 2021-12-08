using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyProject.Rbac
{
    public   class OrganizationModel : AuditedAggregateRoot<Guid>
    {

        public Guid FatherId { get; set; }//上级id
        public string OrganizationName { get; set; }//组织名称
        public DateTime CreateDate { get; set; }//创建时间
        public string OrganizationMessage { get; set; }//组织描述
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyProject.Shopping
{
    public class GoodsSpecificationModel : AuditedAggregateRoot<Guid>
    {
        public Guid GoodId { get; set; }//商品id
        public Guid SpecId { get; set; }//规格id
    }
}

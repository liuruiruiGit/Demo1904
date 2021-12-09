using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MyProject.DtoInfo.CreateUpdateDto
{
    public  class CreateUpdateGoodsSpecificationModel : AuditedEntityDto<Guid>
    {
        public Guid GoodId { get; set; }//商品id
        public Guid SpecId { get; set; }//规格id
    }
}

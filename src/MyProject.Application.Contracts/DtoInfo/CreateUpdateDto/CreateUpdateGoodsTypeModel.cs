using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MyProject.DtoInfo.CreateUpdateDto
{
    public class CreateUpdateGoodsTypeModel : AuditedEntityDto<Guid>
    {
        public Guid GoodId { get; set; }//商品id
        public Guid TypeId { get; set; }//类型id
    }
}

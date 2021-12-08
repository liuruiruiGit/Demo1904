using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.DtoInfo.CreateUpdateDto
{
    public  class CreateUpdateGoodsSpecificationModel
    {
        public Guid GoodId { get; set; }//商品id
        public Guid SpecId { get; set; }//规格id
    }
}

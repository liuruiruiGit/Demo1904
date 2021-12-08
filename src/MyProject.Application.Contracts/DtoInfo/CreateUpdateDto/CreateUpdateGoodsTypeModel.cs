using System;
using System.Collections.Generic;
using System.Text;
namespace MyProject.DtoInfo.CreateUpdateDto
{
    public class CreateUpdateGoodsTypeModel
    {
        public Guid GoodId { get; set; }//商品id
        public Guid TypeId { get; set; }//类型id
    }
}

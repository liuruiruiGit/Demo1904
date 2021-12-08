using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.DtoInfo.CreateUpdateDto
{
    public class CreateUpdateIndentModel
    {
        public string OrderInfoId { get; set; }//订单号ID
        public string GoodId { get; set; }//商品id
        public decimal Price { get; set; }//价格(购买时)
        public int Num { get; set; }//销售数量
        public string Name { get; set; }//商品名称
        public string SmallImage { get; set; }//商品图片
    }
}

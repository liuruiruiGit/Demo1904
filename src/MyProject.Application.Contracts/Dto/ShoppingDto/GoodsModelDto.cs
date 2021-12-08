using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MyProject.Dto.ShoppingDto
{
    public class GoodsModelDto : AuditedEntityDto<Guid>
    {
        public string GoodsName { get; set; }//商品名称
        public decimal GoodPrice { get; set; }//商品价格
        public string GoodMessAge { get; set; }//商品描述
        public int GoodNum { get; set; }//商品库存
        public bool GoodState { get; set; }//商品状态
        public DateTime CreateDate { get; set; }//创建时间
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyProject.Shopping
{
    public class GoodsModel : AuditedAggregateRoot<Guid>
    {
        public string GoodsName { get; set; }//商品名称
        public decimal GoodPrice { get; set; }//商品价格
        public string GoodMessAge { get; set; }//商品描述
        public int GoodNum { get; set; }//商品库存
        public bool GoodState { get; set; }//商品状态
        public DateTime CreateDate { get; set; }//创建时间
    }
}

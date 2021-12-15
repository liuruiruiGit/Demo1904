using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Dto.PayMentDto
{
    public class PayDto
    {
        public string Subject { get; set; }//实训标题
        public string OutTradeNo { get; set; }//订单号
        public string TotalAmount { get; set; }//金额
        public string ReturnUrl { get; set; }//返回URL
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Dto.PayMentDto
{
    public class PayReturnDto
    {
        public string Charset { get; set; }//字符串
        public string Outtradeno { get; set; }//自动贸易
        public string Method { get; set; }//方法
        public string Totalamount { get; set; }//总数
        public string Sign { get; set; }//签名



        //商户网站唯一订单号
        public string Tradeno { get; set; }//翻译
        public string Authappid { get; set; }//AppID 认证
        public string Version { get; set; }//版本
        public string Appid { get; set; }//AppId
        public string Sign_type { get; set; }//签名类型
        public string Sellerid { get; set; }//店家Id
        public string Timestamp { get; set; }//时间戳
    }
}

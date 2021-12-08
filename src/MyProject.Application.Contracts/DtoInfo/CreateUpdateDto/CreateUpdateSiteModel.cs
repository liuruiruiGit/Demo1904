using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.DtoInfo.CreateUpdateDto
{
    public class CreateUpdateSiteModel
    {
        public string AddrName { get; set; }//地址名
        public Guid AddrFatherId { get; set; }//上级id
        public string DetailedAddr { get; set; }//详细地址
        public bool State { get; set; }//是否默认
    }
}

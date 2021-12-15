using MyProject.Dto.PayMentDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.IService
{
    public interface IMyPayment
    {
        void Pay(PayDto dto);
        string ReturnUrl(PayReturnDto dto);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MyProject.DtoInfo.CreateUpdateDto
{
    public class CreateUpdateLogModel : AuditedEntityDto<Guid>
    {
        public int OpenType { get; set; }//操作类型
        public string OpenMessAge { get; set; }//操作内容
        public Guid OpenPeople { get; set; }//操作人
        public DateTime OpenDate { get; set; } = DateTime.Now;//操作时间
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MyProject.DtoInfo.CreateUpdateDto
{
    public class CreateUpdateUserImgModel : AuditedEntityDto<Guid>
    {
        public Guid UserId { get; set; }//用户id
        public Guid ImgId { get; set; }//图片id
    }
}

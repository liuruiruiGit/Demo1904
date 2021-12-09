using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MyProject.DtoInfo.CreateUpdateDto
{
    public  class CreateUpdateImgModel : AuditedEntityDto<Guid>
    {
        public string ImgUrl { get; set; }//图片路径
        public DateTime ImgDate { get; set; }//图片上传时间
    }
}

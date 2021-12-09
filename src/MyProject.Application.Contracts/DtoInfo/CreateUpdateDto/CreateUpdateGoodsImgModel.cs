using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MyProject.DtoInfo.CreateUpdateDto
{
    public class CreateUpdateGoodsImgModel : AuditedEntityDto<Guid>
    {
        public Guid UserId { get; set; }//商品id
        public Guid ImgId { get; set; }//图片id
    }
}

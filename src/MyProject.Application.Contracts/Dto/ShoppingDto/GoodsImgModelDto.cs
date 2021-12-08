using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MyProject.Dto.ShoppingDto
{
    public class GoodsImgModelDto : AuditedEntityDto<Guid>
    {
        public Guid UserId { get; set; }//商品id
        public Guid ImgId { get; set; }//图片id
    }
}

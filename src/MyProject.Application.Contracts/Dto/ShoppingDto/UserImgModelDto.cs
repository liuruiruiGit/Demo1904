using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace MyProject.Dto.ShoppingDto
{
    public  class UserImgModelDto : AuditedEntityDto<Guid>
    {
        public Guid UserId { get; set; }//用户id
        public Guid ImgId { get; set; }//图片id
    }
}

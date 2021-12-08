using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.DtoInfo.CreateUpdateDto
{
    public class CreateUpdateUserImgModel
    {
        public Guid UserId { get; set; }//用户id
        public Guid ImgId { get; set; }//图片id
    }
}

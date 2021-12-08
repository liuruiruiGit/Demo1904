using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.DtoInfo.CreateUpdateDto
{
    public  class CreateUpdateImgModel
    {
        public string ImgUrl { get; set; }//图片路径
        public DateTime ImgDate { get; set; }//图片上传时间
    }
}

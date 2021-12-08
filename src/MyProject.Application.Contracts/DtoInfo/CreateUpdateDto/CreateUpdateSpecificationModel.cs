using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.DtoInfo.CreateUpdateDto
{
    public  class CreateUpdateSpecificationModel
    {
        public string SpeciColor { get; set; }//颜色
        public string SpeciEdition { get; set; }//版本
        public decimal SpeciWeight { get; set; }//重量
        public string SpeciSize { get; set; }//大小/尺寸
    }
}

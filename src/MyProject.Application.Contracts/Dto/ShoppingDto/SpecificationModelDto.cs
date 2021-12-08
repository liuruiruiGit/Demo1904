using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace MyProject.Dto.ShoppingDto
{
    public class SpecificationModelDto : AuditedEntityDto<Guid>
    {
        public string SpeciColor { get; set; }//颜色
        public string SpeciEdition { get; set; }//版本
        public decimal SpeciWeight { get; set; }//重量
        public string SpeciSize { get; set; }//大小/尺寸
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MyProject.DtoInfo.CreateUpdateDto
{
    public class CreateUpdateMenuModel : AuditedEntityDto<Guid>
    {
        [Required]
        public Guid FatherId { get; set; }//父级id
        [Required]
        public string MenuName { get; set; }//权限名称
        [Required]
        public string MenuMessage { get; set; }//权限描述
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyProject.DtoInfo.CreateUpdateDto
{
    public class CreateUpdateOrganizationModel
    {
        [Required]
        public Guid FatherId { get; set; }//上级id
        [Required]
        public string OrganizationName { get; set; }//组织名称
        [Required]
        public DateTime CreateDate { get; set; }//创建时间
        [Required]
        public string OrganizationMessage { get; set; }//组织描述
    }
}

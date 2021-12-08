using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyProject.Shopping
{
    public class ImgModel : AuditedAggregateRoot<Guid>
    {

        public string ImgUrl { get; set; }//图片路径
        public DateTime ImgDate { get; set; }//图片上传时间
    }
}

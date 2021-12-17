using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Dto.ShoppingDto;
using MyProject.DtoInfo.CreateUpdateDto;
using MyProject.IService;
using MyProject.Shopping;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MyProject.Service
{
    //图片上传
    public class MyImgService :CrudAppService<ImgModel, ImgModelDto, Guid, PagedAndSortedResultRequestDto,CreateUpdateImgModel>,IMyImgService
    {
        Microsoft.AspNetCore.Hosting.IWebHostEnvironment _host;
        ImgModel model;
        public MyImgService(IRepository<ImgModel, Guid> repository, Microsoft.AspNetCore.Hosting.IWebHostEnvironment host, ImgModel _model) : base(repository)
        {
            //
            model = _model;
            _host = host;
        }

       [HttpPost,Route("upload")]
        public  string FileUplode(IFormFile file)
        {
            string Rootdir = AppContext.BaseDirectory.Split(@"\bin\")[0];
            string FileName = DateTime.Now.ToString("yyyyMMddHHmmssffff") + System.IO.Path.GetExtension(file.FileName);
            var Path = Rootdir + @"\Upload\" + FileName;
            using (System.IO.FileStream fs = System.IO.File.Create(Path))
            {
                file.CopyTo(fs);
                fs.Flush();//清空文件流
            }
            var url = "https://localhost:44335/" + Path;
            return url;
        }

    }
}

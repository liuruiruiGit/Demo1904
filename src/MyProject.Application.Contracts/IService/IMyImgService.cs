﻿using Microsoft.AspNetCore.Http;
using MyProject.Dto.ShoppingDto;
using MyProject.DtoInfo.CreateUpdateDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MyProject.IService
{
    public interface IMyImgService : ICrudAppService<ImgModelDto, Guid, PagedAndSortedResultRequestDto,CreateUpdateImgModel>,IApplicationService
    {
       
    }
}

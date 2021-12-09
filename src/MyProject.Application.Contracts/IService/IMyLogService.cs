using MyProject.Dto.ShoppingDto;
using MyProject.DtoInfo.CreateUpdateDto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MyProject.IService
{
    public interface IMyLogService : ICrudAppService<LogModelDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateLogModel>
    {
    }
}

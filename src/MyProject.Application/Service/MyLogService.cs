using MyProject.Dto.ShoppingDto;
using MyProject.DtoInfo.CreateUpdateDto;
using MyProject.IService;
using MyProject.Shopping;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MyProject.Service
{
    public class MyLogService :CrudAppService<LogModel, LogModelDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateLogModel>, IMyLogService
    {
        public MyLogService(IRepository<LogModel, Guid> repository) : base(repository)
        {
            //
        }
    }
}

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
    public class MyIndentService :CrudAppService<IndentModel, IndentModelDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateIndentModel>,IMyIndentService
    {
        public MyIndentService(IRepository<IndentModel,Guid> repository) : base(repository)
        {
            //
        }
    }
}

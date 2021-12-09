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
    public class MySpecificationService : CrudAppService<SpecificationModel, SpecificationModelDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateSpecificationModel>, IMySpecificationService
    {
        public MySpecificationService(IRepository<SpecificationModel, Guid> repository) : base(repository)
        {
            //
        }
    }
}

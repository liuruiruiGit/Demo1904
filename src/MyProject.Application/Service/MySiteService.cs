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
    public class MySiteService : CrudAppService<SiteModel, SiteModelDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateSiteModel>,IMySiteService
    {
        public MySiteService(IRepository<SiteModel, Guid> repository) : base(repository)
        {
            //
        }
    }
}

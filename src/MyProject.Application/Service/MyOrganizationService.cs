using MyProject.Dto.RbacDto;
using MyProject.DtoInfo.CreateUpdateDto;
using MyProject.IService;
using MyProject.Rbac;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MyProject.Service
{
    public class MyOrganizationService:CrudAppService<OrganizationModel, OrganizationModelDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateOrganizationModel>,IMyOrganizationService
    {
        public MyOrganizationService(IRepository<OrganizationModel, Guid> repository) :base(repository)
        {

        }
    }
}

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
    public class MyRoleService : CrudAppService<RoleModel, RoleModelDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateRoleModel>, IMyRoleService
    {
        public MyRoleService(IRepository<RoleModel, Guid> repository) : base(repository)
        {
            //
        }
    }
}

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
    public class MyRoleMenuService:CrudAppService<RoleMenuModel, RoleMenuModelDto, Guid, PagedAndSortedResultRequestDto,CreateUpdateRoleMenuModel>, IMyRoleMenuService
    {
        public MyRoleMenuService(IRepository<RoleMenuModel, Guid> repository) : base(repository)
        {
            //
        }
    }
}

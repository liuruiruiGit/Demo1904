using MyProject.Dto.RbacDto;
using MyProject.DtoInfo.CreateUpdateDto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MyProject.IService
{
    public interface IMyRoleService : ICrudAppService<RoleModelDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateRoleModel>
    {

    }
}

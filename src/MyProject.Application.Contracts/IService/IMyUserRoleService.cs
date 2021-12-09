using MyProject.Dto.RbacDto;
using MyProject.DtoInfo.CreateUpdateDto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MyProject.IService
{
    public interface IMyUserRoleService : ICrudAppService<UserRoleModelDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateUserRoleModel>
    {
    }
}

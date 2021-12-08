using MyProject.Dto.RbacDto;
using MyProject.DtoInfo.CreateUpdateDto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MyProject.IService
{
    public interface IMyUserService:ICrudAppService<UserModelDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateUserModel>
    {
        //注册
        int UserAdd(UserModelDto model);
        //登录
        List<UserModelDto> Login(UserModelDto model);
    }
}

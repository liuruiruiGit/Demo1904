using MyProject.Dto.RbacDto;
using MyProject.DtoInfo.CreateUpdateDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;


namespace MyProject.IService
{
    public interface IMyUserService:ICrudAppService<UserModelDto, Guid, PagedAndSortedResultRequestDto,CreateUpdateUserModel>
    {
        Task<int> AddUser(CreateUpdateUserModel model);
        Task<string> Login(UserModelDto model);
    }
}

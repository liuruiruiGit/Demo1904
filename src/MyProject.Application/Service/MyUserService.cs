using MyProject.Dto.RbacDto;
using MyProject.DtoInfo.CreateUpdateDto;
using MyProject.IService;
using MyProject.Rbac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MyProject.Service
{
    /// <summary>
    /// 服务实现
    /// </summary>
    public class MyUserService:CrudAppService<UserModel, UserModelDto, Guid, PagedAndSortedResultRequestDto,CreateUpdateUserModel>,IMyUserService
    {
       
        public MyUserService( IRepository<UserModel,Guid> repository):base(repository) 
        {
            //
        }

        public List<UserModelDto> Login(UserModelDto model)
        {
            throw new NotImplementedException();
        }

        public int UserAdd(UserModelDto model)
        {
            throw new NotImplementedException();
        }
    }
}

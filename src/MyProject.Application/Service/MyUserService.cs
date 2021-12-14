

using IdentityModel.Client;
using Microsoft.Extensions.Configuration;
using MyProject.Dto.RbacDto;
using MyProject.DtoInfo.CreateUpdateDto;
using MyProject.IService;
using MyProject.Rbac;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MyProject.Service
{
    /// <summary>
    /// 服务实现
    /// </summary>
    public class MyUserService:CrudAppService<UserModel,UserModelDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateUserModel>,IMyUserService
    {

        private IConfiguration _configuration;
        private readonly IRepository<UserModel,Guid> user;
      
        public MyUserService(IRepository<UserModel,Guid> repository,IConfiguration configuration) :base(repository){
            user = repository;
            _configuration = configuration;
        }
        //用户注册(密码加入数据库MD5加密)
        public async Task<int> AddUser(CreateUpdateUserModel model)
        {
            model.LoginPwd =Comnn.Md5.GetMd5(model.LoginPwd);
            model.UserName = "普通用户";
            var a = ObjectMapper.Map<CreateUpdateUserModel,UserModel>(model);
            await user.InsertAsync(a);
            return 1;
        }
         //token
        public async Task<LiveShopResData<string>> GetLogin(string userName, string userPwd)
        {
            Ids4 ids4Service = new Ids4(_configuration);
            string token = await ids4Service.GetIdsTokenAsync(userName, userPwd);
            return new LiveShopResData<string>() { Status = ShopStatus.Succeed, Msg = "获取token成功", Info = token };
        }

     



    }
}

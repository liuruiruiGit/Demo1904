

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
        //前端后台管理员登录
        public async Task<string> Login(UserModelDto model)
        {
            
            var client = new HttpClient();
            var idsTokenUrl = _configuration.GetSection("AuthServer:Authority").Value;
            var AppClientId = _configuration.GetSection("AuthServer:AuthoritId").Value;
            var AppClientSecret = _configuration.GetSection("AuthServer:AppClientSecret").Value;
            var disco = client.GetDiscoveryDocumentAsync(idsTokenUrl);
            var tokenRequest = await client.RequestPasswordTokenAsync(
                new PasswordTokenRequest {
                    Address=disco.Result.TokenEndpoint,
                    ClientId=AppClientId,
                    ClientSecret=AppClientSecret,
                    UserName=model.LoginName,
                    Password=model.LoginPwd
                });
            if (tokenRequest.IsError)
            {
                return string.Empty;
            }
            return tokenRequest.AccessToken;
        }
       

    }
}

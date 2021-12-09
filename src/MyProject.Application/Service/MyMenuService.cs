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
    public class MyMenuService:CrudAppService<MenuModel, MenuModelDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateMenuModel>, IMyMenuService
    {
        public MyMenuService(IRepository<MenuModel, Guid> repository) : base(repository)
        {
            //
        }
    }
}

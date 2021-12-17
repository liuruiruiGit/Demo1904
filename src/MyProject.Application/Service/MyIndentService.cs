using Microsoft.AspNetCore.Mvc;
using MyProject.Dto.ShoppingDto;
using MyProject.DtoInfo.CreateUpdateDto;
using MyProject.IService;
using MyProject.Shopping;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MyProject.Service
{
    public class MyIndentService : CrudAppService<IndentModel, IndentModelDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateIndentModel>, IMyIndentService
    {
        IndentModel order;
        public MyIndentService(IRepository<IndentModel, Guid> repository, IndentModel _order) : base(repository)
        {
            order = _order;
        }

        //地址
        //商品信息
        [HttpGet]
        public int Order(IndentDetailModelDto dto) 
        {
            return 1;
        }

    }
    
}

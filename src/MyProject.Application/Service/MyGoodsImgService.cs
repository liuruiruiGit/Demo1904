using MyProject.Dto.ShoppingDto;
using MyProject.DtoInfo.CreateUpdateDto;
using MyProject.IService;
using MyProject.Shopping;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MyProject.Service
{
    public class MyGoodsImgService:CrudAppService<GoodsImgModel, GoodsImgModelDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateGoodsImgModel>, IMyGoodsImgService
    {
        public MyGoodsImgService(IRepository<GoodsImgModel,Guid> repository) : base(repository)
        {
            //
        }
    }
}

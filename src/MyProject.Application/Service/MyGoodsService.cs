using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Dto;
using MyProject.Dto.ShoppingDto;
using MyProject.DtoInfo.CreateUpdateDto;
using MyProject.IService;
using MyProject.Shopping;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MyProject.Service
{
    public class MyGoodsService:CrudAppService<GoodsModel,GoodsModelDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateGoodsModel>,IMyGoodsService
    {
        public MyGoodsService(IRepository<GoodsModel,Guid> repository):base(repository)
        {
            //

        }
        /// <summary>
        /// 下载nugetCSRedis
        /// </summary>
        CSRedis.CSRedisClient client = new CSRedis.CSRedisClient("127.0.0.1:6379");

        [HttpPost,Route("CarAdd")]
        //加入购物车
        public int CarAdd(CarModel model)
        {
            var flag = 0;
            var list = new List<CarModel>();
            //redis键
            var key = $"user{model.UserId}";
            //redis值
            var _list = client.Get(key);

            if (_list!= null)
            {
                var ss = JsonConvert.DeserializeObject<List<CarModel>>(_list);
                //查询购物车有没有该商品
                var g = ss.Where(x => x.GoodId == model.GoodId).FirstOrDefault();
                if (g == null)
                {
                    ss.Add(model);
                }
                else
                {
                    g.Number += 1;
                }
                client.Set(key, ss);
                flag = 1;
            }
            else
            {
                list.Add(model);
                client.Set(key, list);
                flag = 1;
            }
            return flag;
        }
        [HttpPost, Route("upload")]
        public  string FileUplode(IFormFile file)
        {
            //字符串截取
            string Rootdir = AppContext.BaseDirectory.Split(@"\bin\")[0];

            string FileName = DateTime.Now.ToString("yyyyMMddHHmmssffff") + System.IO.Path.GetExtension(file.FileName);
            //存取路径
            var Path = Rootdir + @"\Upload\" + FileName;
            using (System.IO.FileStream fs = System.IO.File.Create(Path))
            {
                file.CopyTo(fs);
                fs.Flush();//清空文件流
            }
            var url = "https://localhost:44335/" + Path;
            return url;
        }
    }
}

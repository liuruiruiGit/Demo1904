using Microsoft.AspNetCore.Mvc;
using MyProject.Dto;
using MyProject.Dto.RbacDto;
using MyProject.DtoInfo.CreateUpdateDto;
using MyProject.Rbac;
using MyProject.Shopping;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MyProject.Service
{
    /// <summary>
    /// 购物车
    /// </summary>
     public class ShoppingCarService 
    {
        List<GoodsModel> good;
        List<GoodsImgModel> goodimg;
        List<ImgModel> img;
        public ShoppingCarService(List<GoodsModel> _good, List<ImgModel> _img, List<GoodsImgModel> _goodimg)
        {
            good = _good;
            goodimg = _goodimg;
            img = _img;
        }
        /// <summary>
        /// 下载nugetCSRedis
        /// </summary>
        CSRedis.CSRedisClient client = new CSRedis.CSRedisClient("127.0.0.1:6379");

        //购物车显示
        [HttpGet,Route("CarShow")]
        public Task<List<string>> CarShow(string userid) 
        {
            List<CarModel> list = new List<CarModel>();
            //redis键
            var key = $"user{userid}";
            //redis值
            var _list=client.Get(key);
            //redis获取到的该用户下购物车所拥有的商品
            var qs = JsonConvert.DeserializeObject<List<CarModel>>(_list);
            //商品数据
            var goodlist = good.ToList();
            //图片数据
            var imglist = img.ToList();
            //商品图片关系表
            var goodimglist = goodimg.ToList();


            var _img = (from c in goodlist
                   join d in goodimglist on c.CreatorId equals d.UserId
                   join e in imglist on d.ImgId equals e.CreatorId
                   select new
                   {
                       e.ImgUrl
                   });
            //联查
            var q = (from a in goodlist
                     join b in qs on a.CreatorId equals b.UserId
                     select new
                     {
                         goodname = a.GoodsName,
                         number = b.Number,
                         price = a.GoodPrice,
                         img = _img
                     }).ToList();
            return null;
        }
    
    }
   
}

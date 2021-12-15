using Alipay.EasySDK.Factory;
using Alipay.EasySDK.Kernel;
using Alipay.EasySDK.Kernel.Util;
using Alipay.EasySDK.Payment.Page.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Dto.PayMentDto;
using MyProject.IService;
using MyProject.Shopping;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MyProject.Service
{
    public class MyPayment : ApplicationService, IMyPayment
    {
        private readonly IRepository<IndentDetailModel, Guid> _indentDetailModels;
        private readonly IHttpContextAccessor _contextAccessor;
        public MyPayment(IHttpContextAccessor contextAccessor, IRepository<IndentDetailModel,Guid>  indentDetailModels)
        {
            _indentDetailModels = indentDetailModels;
            _contextAccessor = contextAccessor;
        }
        [HttpGet]
        public async void Pay(PayDto dto)
        {
            #region 
            var config = new Config()
            {
                Protocol = "https",
                //"openapi.alipay.com",沙箱
                GatewayHost = "openapi.alipay.com",
                SignType = "RSA2",
                AppId = "2021000118669903",
                //应用私钥
                MerchantPrivateKey = "MIIEowIBAAKCAQEAg22/hVxCpfEUrkXwyc6PMgRw/ApX2OpGfkhv+6S23vlBIROgFaaiCHBCPqQtFHxUSA4FTuoq17BcpKIzOekTJ/f7VIZWDg2UbvfESUs4v5rqQDlNHTgkkzP+5P6Qk53OthhGtRBWuTHVvsjeJD8oG7LDkKJaievxFQE8pScnN+i+Bjo3F/dMXS7Cd5l47yTwEqZc6d5RAGZph5ADmqhFJqqPdVxy1QZU/rTnZnqNRGkTgObJF23RKn6AtRzn6gMa7iLf2Zt8Owyk5uw2hPykme8M425xmfHC+SJW7GfCQ6fQ5CaUCIJltpdyQvJINsBUcK3DDX9Xra6X0Ukh5lnsawIDAQABAoIBAG+/5VTTeaf3MIpt1asCAyeYNylW8hLyQDYoCW+CQiuc7A/fzAIcyTE7olf46Iu+mzsZENJksUDsKBmkAMKAt1UIuZ7JCmqwiUFBUpivaPUiF4O8NSFfF1pCn7y95thdGeIjChvyZIrbIM8zpA5V1RiYC0jzguA6yaX+gz456FLURvb6HdVIJRqOXoTcrnPP2tTMRJ0Kzbp8QfotHE2wYclWjyIeCZ1Rbrfku5R/6XxcNox9tJ4UCpHKBGf15Q+nIX9P5LjmJY9PNTHHx33tT4isp2NFPq3syLQv+iLpYxaaFXQye/3vnMhyucXyqPsxnWQdJ72s6lq8bE8HzZUeOaECgYEA5QtiXxGAFYP7RddFCbsZ1Z1Shxpw9FkR8XKSd8/gCdd3dFI6CETgfl6/0P1Y3/0DZ2MN1wpUPvQE42XnZzsGrHvKYVcxyXVoKdDkVFDFEV9hX8lSkx5ol9+Ikc/6OGTIixP9Zisfffy0UlKgoqL/vq/RZvOGHlsOiaUNug8Ms0UCgYEAkuVpUz2yGWplAYbv/iZvL9Oxnwr8xq3KDokrYizj1dPf838aNAspu+ZN5wygr0Mk+XWJs67c//v7DAR2SvG1n1D8gJnGOuDkGODv7ve3+1ul83JeA8WYPkMSo3Nnr4rCLsuosPpGkyh/DkH2d/VtvfPl/VcgdQdl+On3dze9w+8CgYAXOwNcLxM1m3BF0iKfbQmev9kZ+NWSAuKuAXfXjQ7lEKR9+MUIB6xZRNThpoB4H1pUBxjlQZfv1qIUSkahEryHi/qnyscy7qSE8TnnT1XdgDYJGAs2/rOPC833NAfl5lrsuDdQQHluNs43N0gxlqSnu39amMJ2m7eqwEHXKCWanQKBgCHFglhz161GK6CVQDmi5m8NcUmKQiD/NXPwDzxL67luM4+Mih6q7lZXlVNoMMz6V9bOMfFQY1iqusXBhNyoA0R0XwjF0bAZofciR6cd5ntwT4/PnFOrqtutmexgDNdrxEbz5X2CnJUae1Nw0NQ1ZZyFJTwAOuMM52G5kH4lH4ibAoGBAI+vvwUML39mfhwtBYwZerZ0+Y22M1uoA9dsd7d3gXOJVeejHRF4pUJ9/z1R0VIDAQKKCGzdJVt5eprry8LCfrki6usvxsNWZr6Q4ETzC3XRUQlXKEzMFalBhfQv9vqsYT01djYqbUYXcCjJa4c795ax/UbE7kYh5N8+xRMgmHcb",
                //支付宝公钥
                AlipayPublicKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAjcdH85kHHrExP/1Ly/gxiyLZv2P6kPYpcoJe8aviAj0Ya2rix7irdIm1Z8mY2VtzVLPDIWwyT9x7e4BsfZ6ey2e/9Uiv3oKIE4/jshiTizzf1J03DDdWHV7+vRwT+K6IZY3fNq9ceng1Jkdoqx8VUjWgAMD2JR4huFeN+8jZsrRlAIbh15dVh2UGJXid18WBadkqKTrvgl7MTwGoOyd3sD0fIBGiKyqqpWpizw1JbEQ+u/ng3tenwaIhO2Tre5Q2Rkc95EDUUHlAat8XDGmK51ftUttkjYhnSQiuvSz4nOiQ5oWxWCJNVDYFW1zTyoDVSwUJu2oa16uSqRwCZIMHFQIDAQAB",
                //异步回调地址
                NotifyUrl = "https://localhost:44335/api/app/my-payment/notify-url",
            };
            Factory.SetOptions(config);
            #endregion
            try
            {
                // 2. 发起API调用
                AlipayTradePagePayResponse response = Factory.Payment.Page().Pay(dto.Subject, dto.OutTradeNo, dto.TotalAmount, "https://localhost:44335/api/app/my-payment/return-url");
                // 3. 处理响应或异常
                if (ResponseChecker.Success(response))
                {
                    //把返回的html直接变成网页显示
                    var data = Encoding.UTF8.GetBytes(response.Body);
                    _contextAccessor.HttpContext.Response.ContentType = "text/html";
                    await _contextAccessor.HttpContext.Response.Body.WriteAsync(data,0,data.Length);
                }
                else
                {
                    Console.WriteLine("调用失败，原因：" + response.Body);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("调用遭遇异常，原因：" + ex.Message);
            }
        }
        [HttpGet]
        public string ReturnUrl(PayReturnDto dto)
        {
            var parameters = JsonConvert.DeserializeObject<Dictionary<string, string>>(JsonConvert.SerializeObject(dto));
            if (Factory.Payment.Common().VerifyNotify(parameters) == true)
            {
                //TODO:更新此条订单状态为已付款,并修改付款成功时间,加商户网站唯一订单号字段更新进去,后续如果需要查询或退款,再调支付宝接口时需要传入商户网站唯一订单号
                //if()先查一下这条订单,是不是已经改过已付款或更往后的状态了,注意不要重复更新,因为支付宝可能会多次回调
                //update
                var list = _indentDetailModels.Where(o => o.Id.ToString().Equals(dto.Outtradeno)).FirstOrDefault();
                //更改审核状态
                list.OrderInfoAuditState = 30;
                //更改订单状态
                list.OrderInfoState = 30;
                _indentDetailModels.UpdateAsync(list);
                return "success";
            }
            return "";
        }
        //回调方法
        [HttpGet]
        public string NotifyUrl(PayReturnDto dto)
        {
            var parameters = JsonConvert.DeserializeObject<Dictionary<string, string>>(JsonConvert.SerializeObject(dto));
            if (Factory.Payment.Common().VerifyNotify(parameters) == true)
            {
                //TODO:更新此条订单状态为已付款,并修改付款成功时间,加商户网站唯一订单号字段更新进去,后续如果需要查询或退款,再调支付宝接口时需要传入商户网站唯一订单号
                //先查一下这条订单,是不是已经改过已付款或更往后的状态了,注意不要重复更新,因为支付宝可能会多次回调
                //update
                //再循环返回库存
                //update

                return "success";
            }
            return "";
        }
    }
}

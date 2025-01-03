﻿using Interface.Service.RouteQuery;
using Model.ManhowErpTable.TestTable;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Response;
using Model.Service.RouteQuery;
using Service.RouteQuery;
using Swashbuckle.AspNetCore.Annotations;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sunlit.PointToPoint.Api.Controllers
{
    /// <summary>
    /// 路線查詢頁面API
    /// </summary>
    [Route("api/RouteQuery")]
    [ApiController]
    public class RouteQueryController : Controller
    {
       
        private readonly ITestManhowErpService _testManhowErpService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="routeQueryService"></param>
        /// <param name="menuService"></param>
        public RouteQueryController( ITestManhowErpService testManhowErpService)
        {
            
            _testManhowErpService = testManhowErpService;
        }

        

       
        /// <summary>
        /// 測試用API
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Test")]
        [SwaggerResponse(200, Description = "成功", Type = typeof(ResponseModel<List<MenuModel<int>>>))]
        [SwaggerResponse(400, Description = "失敗", Type = typeof(ResponseModel<string>))]
        public async Task<IActionResult> Test()
        {
            var result = new ResponseModel<List<MenuModel<int>>>()
            {
                statusCode = 200,
                message = "",
                data = await _testManhowErpService.TestGet()
            };

            return Ok(result);
        }

        /// <summary>
        /// 公司基本資料維護
        /// </summary>
        /// <param name="require">公司別</param>
        /// <returns></returns>
        [HttpGet]
        [Route("Test")]
        [SwaggerResponse(200, Description = "成功", Type = typeof(ResponseModel<List<MenuModel<int>>>))]
        [SwaggerResponse(400, Description = "失敗", Type = typeof(ResponseModel<string>))]
        public async Task<IActionResult> CompanyInformation(int require)
        {
            var result = new ResponseModel<List<CompanyInfo>>()
            {
                statusCode = 200,
                message = "",
                data = await _testManhowErpService.GetCompanyInformation(require)
            };

            return Ok(result);
        }

       

    }
}

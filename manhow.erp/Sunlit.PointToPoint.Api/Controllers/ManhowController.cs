using Interface.Service.RouteQuery;
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
    public class ManhowController : Controller
    {
       
        private readonly IManhowErpService _ManhowErpService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="routeQueryService"></param>
        /// <param name="menuService"></param>
        public ManhowController( IManhowErpService testManhowErpService)
        {
            
            _ManhowErpService = testManhowErpService;
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
                data = await _ManhowErpService.TestGet()
            };

            return Ok(result);
        }

        /// <summary>
        /// 獲得公司詳細資料
        /// </summary>
        /// <param name="require">查詢編號</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetCompanyInfo")]
        [SwaggerResponse(200, Description = "成功", Type = typeof(ResponseModel<List<CompanyEum>>))]
        [SwaggerResponse(400, Description = "失敗", Type = typeof(ResponseModel<string>))]
        public async Task<IActionResult> GetCompanyInformation(int require)
        {
            var result = new ResponseModel<List<CompanyInfo>>()
            {
                statusCode = 200,
                message = "",
                data = await _ManhowErpService.GetCompanyInformation(require)
            };

            return Ok(result);
        }
        /// <summary>
        /// 新增公司詳細資料
        /// </summary>
        /// <param name="require">新增資料</param>
        /// <returns></returns>
        [HttpPost]
        [Route("CreatCompanyInformation")]
        [SwaggerResponse(200, Description = "成功", Type = typeof(ResponseModel<List<CompanyEum>>))]
        [SwaggerResponse(400, Description = "失敗", Type = typeof(ResponseModel<string>))]
        public async Task<IActionResult> CreatCompanyInformation(CompanyEum require)
        {
            var result = new ResponseModel<string>()
            {
                statusCode = 200,
                message = "",
                data = await _ManhowErpService.CreatCompanyInformation(require)
            };

            return Ok(result);
        }


        /// <summary>
        /// 更新公司詳細資料
        /// </summary>
        /// <param name="require">更新資料</param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateCompanyInformation")]
        [SwaggerResponse(200, Description = "成功", Type = typeof(ResponseModel<List<CompanyEum>>))]
        [SwaggerResponse(400, Description = "失敗", Type = typeof(ResponseModel<string>))]
        public async Task<IActionResult> UpdateCompanyInformation(CompanyEum require)
        {
            var result = new ResponseModel<string>()
            {
                statusCode = 200,
                message = "",
                data = await _ManhowErpService.UpdateCompanyInformation(require)
            };

            return Ok(result);
        }
        /// <summary>
        /// 刪除公司詳細資料
        /// </summary>
        /// <param name="require">刪除的公司編號</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteCompanyInformation")]
        [SwaggerResponse(200, Description = "成功", Type = typeof(ResponseModel<string>))]
        [SwaggerResponse(400, Description = "失敗", Type = typeof(ResponseModel<string>))]
        public async Task<IActionResult> DeleteCompanyInformation(int require)
        {
            var result = new ResponseModel<string>()
            {
                statusCode = 200,
                message = "",
                data = await _ManhowErpService.DeleteCompanyInformation(require)
            };

            return Ok(result);
        }

       

    }
}

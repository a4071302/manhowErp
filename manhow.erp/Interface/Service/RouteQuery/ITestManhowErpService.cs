using Model.ManhowErpTable.TestTable;
using Model.Response;
using Model.Service.RouteQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Service.RouteQuery
{
    public interface ITestManhowErpService
    {

        Task<List<MenuModel<int>>> TestGet();


        /// <summary>
        /// 獲取公司基本資料
        /// </summary>
        /// <param name="require"></param>
        /// <returns></returns>
        Task<List<CompanyInfo>> GetCompanyInformation();

    }
}

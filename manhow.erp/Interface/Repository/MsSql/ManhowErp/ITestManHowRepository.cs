using Model;
using Model.ManhowErpTable.TestTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Repository.MsSql.ManhowErp
{
    public interface ITestManHowRepository
    {

        /// <summary>
        /// 取得有效資料
        /// </summary>
        /// <param name="typeCode"></param>
        /// <returns></returns>
        Task<List<TestCarPallet>> GetTestCarPallet(string typeCode);

        /// <summary>
        /// 取得公司基本資料
        /// </summary>
        /// <param name="typeCode"></param>
        /// <returns></returns>
        Task<List<TestEum>> GetTestConponyInfo();
    }
}

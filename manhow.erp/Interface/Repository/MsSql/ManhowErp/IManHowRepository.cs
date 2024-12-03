using Model;
using Model.ManhowErpTable.TestTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Repository.MsSql.ManhowErp
{
    public interface IManHowRepository
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
        /// <param name="require">查詢編號</param>
        /// <returns></returns>
        Task<List<CompanyEum>> GetConponyInfo(int require);

        /// <summary>
        /// 依照公司類別取得公司基本資料
        /// </summary>
        /// <param name="require">公司編號</param>
        /// <returns></returns>
        Task<CompanyEum> GetCompanyModelByCompanyCategory(int require);

        /// <summary>
        /// 新增公司基本資料
        /// </summary>
        /// <param name="require">新增的公司詳細資料</param>
        /// <returns></returns>
        Task<int> CreateCompanyModel(CompanyEum require);
        /// <summary>
        /// 更新公司基本資料
        /// </summary>
        /// <param name="require">更新的公司詳細資料</param>
        /// <returns></returns>
        Task<int> UpdateCompanyModel(CompanyEum require);

        /// <summary>
        /// 刪除公司基本資料
        /// </summary>
        /// <param name="require">刪除的公司編號</param>
        /// <returns></returns>
        Task<int> DeleteCompanyModel(int require);
    }
}

using Interface.Repository.MsSql.ManhowErp;
using Interface.Service.RouteQuery;
using Model.Response;
using Model.ManhowErpTable.TestTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Service.RouteQuery;

namespace Service.RouteQuery
{
    public class ManhowErpService : IManhowErpService
    {
        private readonly IManHowRepository _ManHowRepository;
        public ManhowErpService(IManHowRepository testManHowRepository)
        {
            _ManHowRepository = testManHowRepository;
            
        }

        public async Task<List<MenuModel<int>>> TestGet()
        {
            var items = await _ManHowRepository.GetTestCarPallet("38E5A41F-EC6C-46A6-A0C6-2D9EB2A6829E");

            return items.Select(x => new MenuModel<int>()
            {
                key = x.SeqNo,
                value = x.Driver
            }).ToList();
        }
        
        public async Task<List<CompanyInfo>> GetCompanyInformation(int require)
        {
            var items = await _ManHowRepository.GetConponyInfo(require);
            //return items;


            return items
               .GroupBy(s => (s.CompanyCategory).ToString())
               .Select(g => new CompanyInfo
               {
                   branNo = g.Key,
                   dealerInfo = g.GroupBy(s => s.CompanyName)
                      .Select(x => new DealerInfo
                      {
                          dealerNo = x.Key,
                          custInfo = x.Select(s => new CustInfo
                          {
                              tesyt03 = s.test03,
                              tesyt04 = s.test04,
                              tesyt05 = s.test05,
                              tesyt06   = s.test06
                          }).ToList()
                      }).ToList()
               }).ToList();
        }

        public async Task<string> CreatCompanyInformation(CompanyEum require)
        {
            var CompanyModel = await _ManHowRepository.GetCompanyModelByCompanyCategory(require.CompanyCategory);
            if (CompanyModel.CompanyCategory == 0)
            {
                var newCompanyData = new CompanyEum()
                {
                    CompanyCategory = require.CompanyCategory,
                    CompanyName = require.CompanyName,
                    test03 = require.test03,
                    test04 = require.test04,
                    test05 = require.test05,
                    test06 = require.test06,
                    test07 = require.test07,
                    test08 = require.test08,
                    test09 = require.test09,
                    test10 = require.test10,
                    test11 = require.test11,
                    test12 = require.test12,
                    test13 = require.test13,
                    test14 = require.test14,
                    test15 = require.test15,

                };
                var result = await _ManHowRepository.CreateCompanyModel(newCompanyData);

                if (result > 0) return "成功新增";
                throw new Exception("新增失敗，因資料不全導致新增失敗");
            }
            else
            {
                throw new Exception("新增失敗，已有相同資料存在");
            }

        }

        public async Task<string> UpdateCompanyInformation(CompanyEum require)
        {
            var CompanyModel = await _ManHowRepository.GetCompanyModelByCompanyCategory(require.CompanyCategory);
            if (CompanyModel.CompanyNo != 0)
            {
                
                var result = await _ManHowRepository.UpdateCompanyModel(require);

                if (result > 0) return "成功新增";
                throw new Exception("(公司別(代碼)、公司簡稱、統一編號 )輸入錯誤");
            }
            else
            {
                throw new Exception("新增失敗，已有相同資料存在");
            }

        }
        
        public async Task<string> DeleteCompanyInformation(int require)
        {
            var CompanyModel = await _ManHowRepository.GetCompanyModelByCompanyCategory(require);
            if (CompanyModel.CompanyNo != 0)
            {
                
                var result = await _ManHowRepository.DeleteCompanyModel(require);

                if (result > 0) return "成功刪除";
                throw new Exception("(某些問題導致)輸入錯誤");
            }
            else
            {
                throw new Exception("刪除失敗，未找到相符的資料");
            }

        }

    }
}

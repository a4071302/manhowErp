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
    public class TestManhowErpService : ITestManhowErpService
    {
        private readonly ITestManHowRepository _testManHowRepository;
        public TestManhowErpService(ITestManHowRepository testManHowRepository)
        {
            _testManHowRepository = testManHowRepository;
            
        }

        public async Task<List<MenuModel<int>>> TestGet()
        {
            var items = await _testManHowRepository.GetTestCarPallet("38E5A41F-EC6C-46A6-A0C6-2D9EB2A6829E");

            return items.Select(x => new MenuModel<int>()
            {
                key = x.SeqNo,
                value = x.Driver
            }).ToList();
        }
        
        public async Task<List<CompanyInfo>> GetCompanyInformation()
        {
            var items = await _testManHowRepository.GetTestConponyInfo();
            //return items;


            return items
               .GroupBy(s => s.test01)
               .Select(g => new CompanyInfo
               {
                   branNo = g.Key,
                   dealerInfo = g.GroupBy(s => s.tesyt02)
                      .Select(x => new DealerInfo
                      {
                          dealerNo = x.Key,
                          custInfo = x.Select(s => new CustInfo
                          {
                              tesyt03 = s.tesyt03,
                              tesyt04 = s.tesyt04,
                              tesyt05 = s.tesyt05,
                              tesyt06   = s.tesyt06
                          }).ToList()
                      }).ToList()
               }).ToList();
        }

    }
}

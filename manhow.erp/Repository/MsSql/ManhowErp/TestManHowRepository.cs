using Interface.Repository.MsSql;
using Interface.Repository.MsSql.ManhowErp;
using Model;
using Model.ManhowErpTable.TestTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.MsSql.ManhowErp
{
    public class TestManHowRepository : ITestManHowRepository
    {
        private readonly IPointToPointDbContext _db;
        private int _chunkSize = 200;

        public TestManHowRepository(IPointToPointDbContext db)
        {
            _db = db;
        }

        public async Task<List<TestCarPallet>> GetTestCarPallet(string typeCode)
        {

            string sql = @"SELECT * 
FROM CarPallet 
WHERE Id = @typeCode;";

            var tmp = await _db.QueryAsync<TestCarPallet>(sql, new
            {
                typeCode
            });

            return tmp.Any() ? tmp.ToList() : new List<TestCarPallet>();

        }

        public async Task<List<TestEum>> GetTestConponyInfo()
        {

            string sql = @"SELECT * 
FROM CarPallet;";

            var tmp = await _db.QueryAsync<TestEum>(sql);

            return tmp.Any() ? tmp.ToList() : new List<TestEum>();

        }
       

    }
}

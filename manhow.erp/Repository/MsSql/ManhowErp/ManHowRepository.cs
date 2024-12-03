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
    public class ManHowRepository : IManHowRepository
    {
        private readonly IPointToPointDbContext _db;
        private readonly IErpDbContext _Erpdb;
        private int _chunkSize = 200;

        public ManHowRepository(IPointToPointDbContext db, IErpDbContext erpdb)
        {
            _db = db;
            _Erpdb = erpdb;
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

        public async Task<List<CompanyEum>> GetConponyInfo(int require)
        {

            string sql = @"SELECT * 
FROM TestCompanyInfo 
WHERE CompanyNo = @require;";

            var tmp = await _Erpdb.QueryAsync<CompanyEum>(sql, new {
                require
            });

            return tmp.Any() ? tmp.ToList() : new List<CompanyEum>();

        }
        
        public async Task<CompanyEum> GetCompanyModelByCompanyCategory(int companyCategory)
        {

            string sql = @"SELECT * 
FROM TestCompanyInfo 
WHERE CompanyCategory = @companyCategory;";

            var tmp = await _Erpdb.QueryAsync<CompanyEum>(sql, new {
                companyCategory
            });

            return tmp.Any() ? tmp.First() : new CompanyEum();

        }
        
        public async Task<int> CreateCompanyModel(CompanyEum companyEum)
        {

            string sql = @"INSERT INTO SunlitERP.dbo.TestCompanyInfo 
    (CompanyCategory, CompanyName, CompanyLongCHName, CompanyLongENName, UnifiedNo, TaxNo, 
     CompanyResponsibleName, CompanyAddress, CompanyPhoneNo, FactoryAddress, FactoryPhoneNo, 
     CompanyType, StartTime, EndTime, TaxMethod, IsValid)
VALUES 
    (@CompanyCategory, 
     @CompanyName, 
     @test03, 
     @test04, 
     @test05, 
     @test06, 
     @test07, 
     @test08, 
     @test09, 
     @test10, 
     @test11, 
     @test12, 
     @test13, 
     @test14, 
     @test15, 
     @IsValid);";

            return await _Erpdb.ExecuteAsync(sql, companyEum);

        }
        public async Task<int> UpdateCompanyModel(CompanyEum companyEum)
        {

            string sql = @"
UPDATE SunlitERP.dbo.TestCompanyInfo
SET 
    CompanyCategory = @CompanyCategory, 
    CompanyName = @CompanyName, 
    CompanyLongCHName = @test03, 
    CompanyLongENName = @test04, 
    UnifiedNo = @test05, 
    TaxNo = @test06, 
    CompanyResponsibleName = @test07, 
    CompanyAddress = @test08, 
    CompanyPhoneNo = @test09, 
    FactoryAddress = @test10, 
    FactoryPhoneNo = @test11, 
    CompanyType = @test12, 
    StartTime = @test13, 
    EndTime = @test14, 
    TaxMethod = @test15, 
    IsValid = @IsValid
WHERE 
    CompanyName = @CompanyName AND
    CompanyCategory = @CompanyCategory;
";

            return await _Erpdb.ExecuteAsync(sql, companyEum);

        }


        public async Task<int> DeleteCompanyModel(int companyCategory)
        {

            string sql = @"
DELETE FROM SunlitERP.dbo.TestCompanyInfo
WHERE 
    CompanyCategory = @CompanyCategory;
";

            return await _Erpdb.ExecuteAsync(sql, new
            {
                companyCategory
            });

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service.RouteQuery
{
    public class CompanyInfo
    {

        /// <summary>
        /// 公司別
        /// </summary>
        public string branNo { get; set; }

        /// <summary>
        /// 公司基本資料
        /// </summary>
        public List<DealerInfo> dealerInfo { get; set; }
    }
    public class DealerInfo
    {
        /// <summary>
        /// 公司簡稱
        /// </summary>
        public string dealerNo { get; set; }
        /// <summary>
        /// 公司詳細資料
        /// </summary>
        public List<CustInfo> custInfo { get; set; }
    }
    public class CustInfo
    {
        /// <summary>
        /// 公司全名
        /// </summary>
        public string tesyt03 { get; set; }

        /// <summary>
        /// 英文全名
        /// </summary>
        public string tesyt04 { get; set; }
        /// <summary>
        /// 統一編號
        /// </summary>
        public int tesyt05 { get; set; }
        /// <summary>
        /// 稅及編號
        /// </summary>
        public int tesyt06 { get; set; }
        /// <summary>
        /// 負責人
        /// </summary>
        public string tesyt07 { get; set; }
        /// <summary>
        /// 公司地址
        /// </summary>
        public string tesyt08 { get; set; }
        /// <summary>
        /// 公司電話
        /// </summary>
        public int tesyt09 { get; set; }
        /// <summary>
        /// 工廠地址
        /// </summary>
        public string tesyt10 { get; set; }

        /// <summary>
        /// 工廠電話
        /// </summary>
        public int tesyt11 { get; set; }

        /// <summary>
        /// 公司類別
        /// </summary>
        public string tesyt12 { get; set; }

        /// <summary>
        /// 本期起日
        /// </summary>
        public DateTime tesyt13 { get; set; }

        /// <summary>
        /// 本期起日2
        /// </summary>
        public DateTime tesyt14 { get; set; }
        /// <summary>
        /// 計稅方式
        /// </summary>
        public string tesyt015 { get; set; }
    }


}

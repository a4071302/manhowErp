﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service.RouteQuery
{
    public class CodeRulesInfo
    {

        /// <summary>
        /// 代碼欄位
        /// </summary>
        public string test01 { get; set; }

        /// <summary>
        /// 代碼基本資料
        /// </summary>
        public List<CodeInfo01> dealerInfo { get; set; }
    }
    public class CodeInfo01
    {
        /// <summary>
        /// 代碼名稱
        /// </summary>
        public string tesyt02 { get; set; }
        /// <summary>
        /// 公司詳細資料
        /// </summary>
        public List<CodeInfo02> custInfo { get; set; }
    }
    public class CodeInfo02
    {
       
       
        /// <summary>
        /// 代碼長度
        /// </summary>
        public int tesyt03 { get; set; }

        /// <summary>
        /// 說明長度
        /// </summary>
        public int tesyt04 { get; set; }
        /// <summary>
        /// 備註欄名
        /// </summary>
        public string tesyt05 { get; set; }
        /// <summary>
        /// 備註屬性(以代號標註)
        /// </summary>
        public int tesyt06 { get; set; }
        /// <summary>
        /// 備註長度
        /// </summary>
        public int tesyt07 { get; set; }
        /// <summary>
        /// 系統歸屬
        /// </summary>
        public string tesyt08 { get; set; }
        /// <summary>
        /// 系統維護
        /// </summary>
        public int tesyt09 { get; set; }
        /// <summary>
        /// 狀態
        /// </summary>
        public string tesyt10 { get; set; }

    }
}
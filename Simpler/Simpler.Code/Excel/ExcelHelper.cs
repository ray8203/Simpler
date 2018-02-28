/*******************************************************************************
 * Copyright © 2016 Simpler.Framework 版权所有
 * Author: Simpler
 * Description: Simpler快速开发平台
 * Website：http://www.Simpler.cn
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simpler.Code.Excel;

namespace Simpler.Code
{
    public static class ExcelHelper
    {
        public static bool DataTableToExcel(DataTable dt, string title, string sheetName, string path)
        {
            NPOIExcel excel = new NPOIExcel();
            return excel.ToExcel(dt, title, sheetName, path);
        }

        public static DataTable ExcelToDataTable(string path)
        {
            NPOIExcel excel = new NPOIExcel();
            return excel.ToTable(path);
        }
    }
}

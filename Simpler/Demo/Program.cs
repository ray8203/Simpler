using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simpler.Code;
using Simpler.Code.Excel;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var dt = new DataTable();
            dt.Columns.Add("A", typeof(string));
            dt.Columns.Add("B", typeof(string));
            dt.Columns.Add("C", typeof(string));
            dt.Columns.Add("D", typeof(string));
            dt.Columns.Add("E", typeof(string));
            dt.Columns.Add("F", typeof(string));
            dt.Columns.Add("G", typeof(string));
            for (int i = 0; i < 100000; i++)
            {
                var dr = dt.NewRow();
                dr.SetField("A", "123");
                dr.SetField("B", "456");
                dr.SetField("C", "789");
                dr.SetField("D", "111");
                dt.Rows.Add(dr);
            }
            //ExcelHelper.DataTableToExcel(dt, "AAAA", "A",Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "工作簿1.xlsx"));
          var result=  ExcelHelper.ExcelToDataTable(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "工作簿1.xlsx"));
           
        }
    }
}

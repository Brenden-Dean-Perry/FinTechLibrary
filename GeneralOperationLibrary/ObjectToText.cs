using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GeneralOperationalLibrary
{
    public static class ObjectToText
    {
        public static string NumberWithCommas(decimal value, int Digits)
        {
            string formatString = "N" + Digits.ToString();
            return value.ToString(formatString);
        }

        public static string Percent(decimal value, int Digits)
        {
            string formatString = "P" + Digits.ToString();
            return value.ToString(formatString);
        }

        public static List<string> DataTableToMessageOutput(DataTable dataTable)
        {
            StringBuilder columnHeaders = new StringBuilder();
            foreach (DataColumn dataColumn in dataTable.Columns)
            {
                columnHeaders.Append(" | " + dataColumn.ColumnName);
            }
            List<string> resultList = new List<string>();
            resultList.Add(columnHeaders.ToString());

            foreach (DataRow dataRow in dataTable.Rows)
            {
                StringBuilder rowData = new StringBuilder();
                foreach (var item in dataRow.ItemArray)
                {
                    rowData.Append(" | " + item.ToString());
                }
                resultList.Add(rowData.ToString());
            }
            return resultList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;

namespace DataToZPL
{
    public static class DataFromCSV
    {
        public static string ValuePackHeader { get; set; }
        public static string ValuePackDetail { get; set; }

        public static DataTable ConvertCSVtoDataTable(string strFilePath)
        {

            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(strFilePath))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                    ValuePackHeader = header;
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }

        public static int CountHeader(string strFilePath)
        {
            using (StreamReader sr = new StreamReader(strFilePath))
            {
                return sr.ReadLine().Split(';').Length;
            }
        }

        public static void SpliterHeader(int limit)
        {
            for (int i = 0; i < limit; i++)
            {
                Data._HEADER_.Add(ValuePackHeader.Split(Config.SplitChar)[i]);
            }
        }

        public static void SpliterDetail(int limit)
        {
            for (int i = 0; i < limit; i++)
            {
                Data._DETAIL_.Add(ValuePackDetail.Split(Config.SplitChar)[i]);
            }
        }
    }
}

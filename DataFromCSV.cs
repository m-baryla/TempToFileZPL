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

        public static List<string> _HEADER_ = new List<string>();
        public static string ValuePackDetail { get; set; }

        public static List<string> _DETAIL_ = new List<string>();

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
                _HEADER_.Add(ValuePackHeader.Split(Config.SplitChar)[i]);
            }
        }

        public static void SpliterDetail(int limit)
        {
            for (int i = 0; i < limit; i++)
            {
                _DETAIL_.Add(ValuePackDetail.Split(Config.SplitChar)[i]);
            }
        }
    }
}
//public static DataTable ConvertCSVtoDataTable(string strFilePath)
//{

//    DataTable dt = new DataTable();
//    using (StreamReader sr = new StreamReader(strFilePath))
//    {
//        string[] headers = sr.ReadLine().Split('#');
//        string[] headers_1 = sr.ReadLine().Split(';');
//        foreach (string header in headers)
//        {
//            dt.Columns.Add(header);
//            LabelTempValuesHeader.ValuePackHeader = header;
//            CountRow = headers_1.Length;
//        }
//        while (!sr.EndOfStream)
//        {
//            string[] rows = sr.ReadLine().Split('#');
//            DataRow dr = dt.NewRow();
//            for (int i = 0; i < headers.Length; i++)
//            {
//                dr[i] = rows[i];
//            }
//            dt.Rows.Add(dr);
//        }
//    }
//    return dt;
//}


//public static DataTable LabelDetailsFromCSV(string strFilePath)
//{
//    DataTable dt = new DataTable();
//    using (StreamReader sr = new StreamReader(strFilePath))
//    {
//        string[] headers = sr.ReadLine().Split(',');
//        foreach (string header in headers)
//        {
//            dt.Columns.Add(header);
//            LabelTempValuesHeader.ValuePackHeader = header;
//        }
//        while (!sr.EndOfStream)
//        {
//            string[] rows = sr.ReadLine().Split(',');
//            DataRow dr = dt.NewRow();
//            for (int i = 0; i < headers.Length; i++)
//            {
//                dr[i] = rows[i];
//            }
//            dt.Rows.Add(dr);
//        }
//    }
//    return dt;
//}

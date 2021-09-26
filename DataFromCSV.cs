using System.Data;
using System.IO;
using _Excel = Microsoft.Office.Interop.Excel;

namespace DataToZPL
{
    public static class DataFromCSV
    {
        
        public static System.Data.DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            using (StreamReader sr = new StreamReader(strFilePath))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
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
    }
}

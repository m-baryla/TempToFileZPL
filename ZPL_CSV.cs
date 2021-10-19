﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;

namespace DataToZPL
{
    public class ZPL_CSV:BaseEngineZPL
    {
       
        public void ZPLGeneratorFromCSV(DataTable dataTableDetail, EnumLabelType type, int limit)
        {
            int i = 0;

            foreach (DataRow dataRow in dataTableDetail.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    DataFromCSV.ValuePackDetail = item.ToString();           
                    DataFromCSV.SpliterData(limit);
                    GetFilesScriptName(type, i);
                    GeneratorZPLFiles(GetFilesZPLTemScript(type), limit);
                }
                i++;
            }
        }
    }
}

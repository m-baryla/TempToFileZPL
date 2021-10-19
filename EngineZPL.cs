using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;

namespace DataToZPL
{
    public class EngineZPL
    {
        public string GetFilesScriptName(EnumLabelType type, int i)
        {
            if (type == EnumLabelType.BOX)
            { 
               return Config.FileNameScripTxt = "BOX_" + i + ".txt";
            }
            if (type == EnumLabelType.PALLET)
            {
                return Config.FileNameScripTxt = "PALLET_" + i + ".txt";
            }
            if (type == EnumLabelType.TEST)
            {
                return Config.FileNameScripTxt = "TEST_" + i + ".txt";
            }

            return "";
        }
        public string GetFilesZPLTemScript(EnumLabelType type)
        {
            if (type == EnumLabelType.BOX)
            {
                return Config.BOX_FileNameTempTxtData;
            }
            if (type == EnumLabelType.PALLET)
            {
                return Config.PALLET_FileNameTempTxtData;
            }
            if (type == EnumLabelType.TEST)
            {
                return Config.TEST_FileNameTempTxtData;
            }
            return "";
        }
        public void ZPLGenerator(DataTable dataTableDetail, EnumLabelType type, int limit)
        {
            int i = 0;

            foreach (DataRow dataRow in dataTableDetail.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    DataFromCSV.ValuePackDetail = item.ToString();           
                    DataFromCSV.SpliterDetail(limit);
                    DataFromCSV.SpliterHeader(limit);

                    GetFilesScriptName(type, i);
                    var filesName = GetFilesZPLTemScript(type);

                    try
                    {
                        File.Copy(Config.BaseDirTempZPLFiles + filesName, Config.BaseDirScriptFiles + Config.FileNameScripTxt, true);
                    }
                    catch (IOException iox)
                    {
                        Console.WriteLine(iox.Message);
                    }

                    string editFiles = File.ReadAllText(Config.BaseDirScriptFiles + Config.FileNameScripTxt);
                    
                    for (int j = 0; j < limit; j++)
                    {

                        editFiles = editFiles.Replace(Data._HEADER_[j], Data._DETAIL_[j]);

                        File.WriteAllText(Config.BaseDirScriptFiles + Config.FileNameScripTxt, editFiles);
                    }

                }
                Data._HEADER_ = new List<string>();
                Data._DETAIL_ = new List<string>();
                i++;
            }
        }
    }
}

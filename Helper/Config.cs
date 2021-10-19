using System;
using System.Configuration;

namespace Helper
{
    public static class Config
    {
        public static string FileNameScripTxt = "";
        public static char SplitChar = Convert.ToChar(ConfigurationManager.AppSettings["Split_char"]);

        //STATIC VALUES TO BASE DIRECTION FOLDER NAMES
        public static string BaseDirTempZPLFiles = AppDomain.CurrentDomain.BaseDirectory + @"\" + ConfigurationManager.AppSettings["Temp_folder"] + @"\";
        public static string BaseDirDataCSVFiles = AppDomain.CurrentDomain.BaseDirectory + @"\" + ConfigurationManager.AppSettings["CSV_folder"] + @"\";
        public static string BaseDirScriptFiles = AppDomain.CurrentDomain.BaseDirectory + @"\" + ConfigurationManager.AppSettings["Script_folder"] + @"\";

        
        //VALUES TO EDIT WHEN WE WANT ADD NEW DATA CSV AND TEMPLEMATE ZPL CODE
        public static string BOX_FileNameCSVData = ConfigurationManager.AppSettings["CSV_file_name_BOX"];
        public static string PALLET_FileNameCSVData = ConfigurationManager.AppSettings["CSV_file_name_PALLET"];
        public static string TEST_FileNameCSVData = ConfigurationManager.AppSettings["CSV_file_name_TEST"];

        public static string BOX_FileNameTempTxtData = ConfigurationManager.AppSettings["Temp_file_BOX"];
        public static string PALLET_FileNameTempTxtData = ConfigurationManager.AppSettings["Temp_file_PALLET"];
        public static string TEST_FileNameTempTxtData = ConfigurationManager.AppSettings["Temp_file_TEST"];



    }
}

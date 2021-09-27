using System;
using System.Configuration;

namespace DataToZPL
{
    public static class Config
    {
        public static string FileNameScripTxt = "";

        public static string BOX_FileNameCSVData = ConfigurationManager.AppSettings["CSV_file_name_BOX"];
        public static string PALLET_FileNameCSVData = ConfigurationManager.AppSettings["CSV_file_name_PALLET"];
        public static string BOX_FileNameTempTxtData = ConfigurationManager.AppSettings["Temp_file_BOX"];
        public static string PALLET_FileNameTempTxtData = ConfigurationManager.AppSettings["Temp_file_PALLET"];

        public static char SplitChar = Convert.ToChar(ConfigurationManager.AppSettings["Split_char"]);

        public static string FolderNameScripTxt = ConfigurationManager.AppSettings["Script_folder"];
        public static string FolderNameCSVData = ConfigurationManager.AppSettings["CSV_folder"];
        public static string FolderNameTempTxtData = ConfigurationManager.AppSettings["Temp_folder"];
    }
}

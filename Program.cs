using System;
using System.IO;
using System.Data;

namespace DataToZPL
{
    class Program
    {
        static void Main(string[] args)
        {

            EngineZPL engine = new EngineZPL();
            var data_detail = DataFromCSV.LabelDetailsFromCSV(AppDomain.CurrentDomain.BaseDirectory + @"\" + Config.FolderNameExelData + @"\" + Config.FileNameCSVData);
            engine.ZPLGenerator(data_detail, EnumLabelType.BOX);
            engine.ZPLGenerator(data_detail, EnumLabelType.PALLET);
            Console.ReadKey();
        }
    }
}

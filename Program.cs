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
            var data = DataFromCSV.ConvertCSVtoDataTable(AppDomain.CurrentDomain.BaseDirectory + @"\" + Config.FolderNameExelData + @"\" + Config.FileNameCSVData);
            engine.ZPLGenerator(data, LabelType.BOX);
            engine.ZPLGenerator(data, LabelType.PALLET);
            Console.ReadKey();
        }
    }
}

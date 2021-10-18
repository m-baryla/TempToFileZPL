using System;
using System.Linq;

namespace DataToZPL
{
    class Program
    {
        static void Main(string[] args)
        {
            int choise = 0;
            EngineZPL engine = new EngineZPL();

            Console.WriteLine("1 - BOX");
            Console.WriteLine("2 - PALLET");
            Console.WriteLine("3 - TEST");

            choise = Convert.ToInt32(Console.ReadLine());

            switch (choise)
            {
                case 1:
                {
                    var data_detail_BOX = DataFromCSV.ConvertCSVtoDataTable(AppDomain.CurrentDomain.BaseDirectory + @"\" + Config.FolderNameCSVData + @"\" + Config.BOX_FileNameCSVData);
                    engine.ZPLGenerator(data_detail_BOX, EnumLabelType.BOX, DataFromCSV.CountHeader(AppDomain.CurrentDomain.BaseDirectory + @"\" + Config.FolderNameCSVData + @"\" + Config.BOX_FileNameCSVData));
                } break;
                case 2:
                {
                    var data_detail_PALLET = DataFromCSV.ConvertCSVtoDataTable(AppDomain.CurrentDomain.BaseDirectory + @"\" + Config.FolderNameCSVData + @"\" + Config.PALLET_FileNameCSVData);
                    engine.ZPLGenerator(data_detail_PALLET, EnumLabelType.PALLET, DataFromCSV.CountHeader(AppDomain.CurrentDomain.BaseDirectory + @"\" + Config.FolderNameCSVData + @"\" + Config.PALLET_FileNameCSVData));
                } break;
                case 3:
                {
                    var data_detail_TEST = DataFromCSV.ConvertCSVtoDataTable(AppDomain.CurrentDomain.BaseDirectory + @"\" + Config.FolderNameCSVData + @"\" + Config.TEST_FileNameCSVData);
                    engine.ZPLGenerator(data_detail_TEST, EnumLabelType.TEST, DataFromCSV.CountHeader(AppDomain.CurrentDomain.BaseDirectory + @"\" + Config.FolderNameCSVData + @"\" + Config.TEST_FileNameCSVData));
                } break;
                default:
                {
                    // code block
                }break;
            }
            Console.WriteLine("KONIEC");
            Console.ReadKey();
        }
    }
}

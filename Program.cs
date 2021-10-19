using System;
using System.Linq;

namespace DataToZPL
{
    class Program
    {
        static void Main(string[] args)
        {
            int choise = 0;

            var dir_BOX = Config.BaseDirDataCSVFiles + Config.BOX_FileNameCSVData;
            var dir_PALLET = Config.BaseDirDataCSVFiles + Config.PALLET_FileNameCSVData;
            var dir_TEST = Config.BaseDirDataCSVFiles + Config.TEST_FileNameCSVData;

            ZPL_CSV zplCsv = new ZPL_CSV();

            Console.WriteLine("1 - BOX");
            Console.WriteLine("2 - PALLET");
            Console.WriteLine("3 - TEST");

            choise = Convert.ToInt32(Console.ReadLine());

            switch (choise)
            {
                case 1:
                {
                    var data_detail_BOX = DataFromCSV.ConvertCSVtoDataTable(dir_BOX);
                    zplCsv.ZPLGeneratorFromCSV(data_detail_BOX, EnumLabelType.BOX, DataFromCSV.CountHeader(dir_BOX));
                } break;
                case 2:
                {
                    var data_detail_PALLET = DataFromCSV.ConvertCSVtoDataTable(dir_PALLET);
                    zplCsv.ZPLGeneratorFromCSV(data_detail_PALLET, EnumLabelType.PALLET, DataFromCSV.CountHeader(dir_PALLET));
                } break;
                case 3:
                {
                    var data_detail_TEST = DataFromCSV.ConvertCSVtoDataTable(dir_TEST);
                    zplCsv.ZPLGeneratorFromCSV(data_detail_TEST, EnumLabelType.TEST, DataFromCSV.CountHeader(dir_TEST));
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

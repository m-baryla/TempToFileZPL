using System;
using CSV_ZPLGenerator;
using Helper;

namespace DataToZPL
{
    class Program
    {
        static void Main(string[] args)
        {       
            int choise = 0;

            while (choise != 999)
            {

                var dir_BOX = Config.BaseDirDataCSVFiles + Config.BOX_FileNameCSVData;
                var dir_PALLET = Config.BaseDirDataCSVFiles + Config.PALLET_FileNameCSVData;
                var dir_TEST = Config.BaseDirDataCSVFiles + Config.TEST_FileNameCSVData;

                ZPL_CSV zplCsv = new ZPL_CSV();

                Console.WriteLine("1 - BOX");
                Console.WriteLine("2 - PALLET");
                Console.WriteLine("3 - TEST");
                Console.WriteLine("999 - KONIEC");

                choise = Convert.ToInt32(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                    {
                        zplCsv.ZPLGeneratorFromCSV(DataFromCSV.ConvertCSVtoDataTable(dir_BOX), EnumLabelType.BOX, DataFromCSV.CountHeader(dir_BOX));
                            Console.WriteLine("Wygenerowano " + DataFromCSV.CountHeader(dir_BOX) + " etykiet w lokalizacji " + dir_BOX);
                            Console.WriteLine();
                    } break;
                    case 2:
                    {
                        zplCsv.ZPLGeneratorFromCSV(DataFromCSV.ConvertCSVtoDataTable(dir_PALLET), EnumLabelType.PALLET, DataFromCSV.CountHeader(dir_PALLET));
                            Console.WriteLine("Wygenerowano " + DataFromCSV.CountHeader(dir_PALLET) + " etykiet w lokalizacji " + dir_PALLET);
                            Console.WriteLine();
                    } break;
                    case 3:
                    {
                        zplCsv.ZPLGeneratorFromCSV(DataFromCSV.ConvertCSVtoDataTable(dir_TEST), EnumLabelType.TEST, DataFromCSV.CountHeader(dir_TEST));
                            Console.WriteLine("Wygenerowano " + DataFromCSV.CountHeader(dir_TEST) + " etykiet w lokalizacji " + dir_TEST);
                            Console.WriteLine();
                    } break;
                    default:
                    {
                        // code block
                    }break;
                }  
                
            }
            Console.WriteLine("KONIEC");
            Console.ReadKey();
        }
    }
}

using System;

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

            choise = Convert.ToInt32(Console.ReadLine());

            switch (choise)
            {
                case 1:
                {
                    var data_detail_BOX = DataFromCSV.LabelDetailsFromCSV(AppDomain.CurrentDomain.BaseDirectory + @"\" + Config.FolderNameCSVData + @"\" + Config.BOX_FileNameCSVData);
                    engine.ZPLGenerator(data_detail_BOX, EnumLabelType.BOX);
                } break;
                case 2:
                {
                    var data_detail_PALLET = DataFromCSV.LabelDetailsFromCSV(AppDomain.CurrentDomain.BaseDirectory + @"\" + Config.FolderNameCSVData + @"\" + Config.PALLET_FileNameCSVData);
                    engine.ZPLGenerator(data_detail_PALLET, EnumLabelType.PALLET);
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

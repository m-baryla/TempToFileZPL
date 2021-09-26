using System;
using System.Data;
using System.IO;

namespace DataToZPL
{
    public class EngineZPL
    {

        public void ZPLGenerator(System.Data.DataTable dataTable,LabelType type)
        {
            foreach (DataRow dataRow in dataTable.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    LabelTemp.ValuePack = item.ToString();

                    if (type == LabelType.BOX)
                    {
                        Config.FileNameScripTxt = "BOX_" + LabelTemp.ItemNumberCetes + ".txt";
                    }
                    if (type == LabelType.PALLET)
                    {
                        Config.FileNameScripTxt = "PALLET_" + LabelTemp.ItemNumberCetes + ".txt";
                    }

                    using (StreamWriter streamWriter = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\" + Config.FolderNameScripTxt + @"\" + Config.FileNameScripTxt))
                    {
                        StreamReader streamReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"\" + Config.FolderNameTempTxtData + @"\" + Config.FileNameTempTxtData);
                        string t = null;

                        while ((t = streamReader.ReadLine()) != null)
                        {
                            switch (t)
                            {
                                case ("<0>"):
                                    streamWriter.WriteLine(LabelTemp.ItemNumberCetes);
                                    break;
                                case ("<1>"):
                                    streamWriter.WriteLine(LabelTemp.ItemNumberCustomer);
                                    break;
                                case ("<2>"):
                                    streamWriter.WriteLine(LabelTemp.ItemDescription);
                                    break;
                                case ("<3>"):
                                    streamWriter.WriteLine(LabelTemp.Pieces);
                                    break;
                                case ("<4>"):
                                    streamWriter.WriteLine(LabelTemp.PiecesPerPackage);
                                    break;
                                case ("<5>"):
                                    streamWriter.WriteLine(LabelTemp.Batch);
                                    break;
                                case ("<6>"):
                                    streamWriter.WriteLine(LabelTemp.GTINCase);
                                    break;
                                case ("<7>"):
                                    streamWriter.WriteLine(LabelTemp.SSCC);
                                    break;
                                case ("<8>"):
                                    streamWriter.WriteLine(LabelTemp.Lot);
                                    break;
                                default:
                                    streamWriter.WriteLine(t);
                                    break;
                            }
                        }

                        streamReader.Close();
                        streamWriter.Close();

                        Console.WriteLine(Config.FileNameScripTxt + " - zrobione");
                    }
                }
            }
        }
    }
}

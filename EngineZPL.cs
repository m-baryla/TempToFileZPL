using System;
using System.CodeDom;
using System.Data;
using System.IO;
using System.Linq;

namespace DataToZPL
{
    public class EngineZPL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="type"></param>
        public void ZPLGenerator(DataTable dataTableDetail, EnumLabelType type)
        {
            foreach (DataRow dataRow in dataTableDetail.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    LabelTempValuesDetail.ValuePackDetail = item.ToString();

                    if (type == EnumLabelType.BOX)
                    {
                        Config.FileNameScripTxt = "BOX_" + LabelTempValuesDetail._0_ + ".txt";
                    }
                    if (type == EnumLabelType.PALLET)
                    {
                        Config.FileNameScripTxt = "PALLET_" + LabelTempValuesDetail._0_ + ".txt";
                    }

                    using (StreamWriter streamWriter = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\" + Config.FolderNameScripTxt + @"\" + Config.FileNameScripTxt))
                    {
                        string filesName = "";
                        if (type == EnumLabelType.BOX)
                        {
                            filesName = Config.BOX_FileNameTempTxtData;
                        }
                        if (type == EnumLabelType.PALLET)
                        {
                            filesName = Config.PALLET_FileNameTempTxtData;
                        }

                        StreamReader streamReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"\" + Config.FolderNameTempTxtData + @"\" + filesName);
                        string t = null;


                        while ((t = streamReader.ReadLine()) != null)
                        {

                            if (t == LabelTempValuesHeader._0_)
                            {
                                streamWriter.WriteLine(LabelTempValuesDetail._0_);
                            }
                            else if (t == LabelTempValuesHeader._1_)
                            {
                                streamWriter.WriteLine(LabelTempValuesDetail._1_);
                            }
                            else if (t == LabelTempValuesHeader._2_)
                            {
                                streamWriter.WriteLine(LabelTempValuesDetail._2_);
                            }
                            else if (t == LabelTempValuesHeader._3_)
                            {
                                streamWriter.WriteLine(LabelTempValuesDetail._3_);
                            }
                            else if (t == LabelTempValuesHeader._4_)
                            {
                                streamWriter.WriteLine(LabelTempValuesDetail._4_);
                            }
                            else if (t == LabelTempValuesHeader._5_)
                            {
                                streamWriter.WriteLine(LabelTempValuesDetail._5_);
                            }
                            else if (t == LabelTempValuesHeader._6_)
                            {
                                streamWriter.WriteLine(LabelTempValuesDetail._6_);
                            }
                            else if (t == LabelTempValuesHeader._7_)
                            {
                                streamWriter.WriteLine(LabelTempValuesDetail._7_);
                            }
                            else if (t == LabelTempValuesHeader._8_)
                            {
                                streamWriter.WriteLine(LabelTempValuesDetail._8_);
                            }
                            else
                            {
                                streamWriter.WriteLine(t);
                            }
                            //switch (t)
                            //{
                            //    case ("<0>"):
                            //        streamWriter.WriteLine(LabelTempValuesDetail._0_);
                            //        break;
                            //    case ("<1>"):
                            //        streamWriter.WriteLine(LabelTempValuesDetail._1_);
                            //        break;
                            //    case ("<2>"):
                            //        streamWriter.WriteLine(LabelTempValuesDetail._2_);
                            //        break;
                            //    case ("<3>"):
                            //        streamWriter.WriteLine(LabelTempValuesDetail._3_);
                            //        break;
                            //    case ("<4>"):
                            //        streamWriter.WriteLine(LabelTempValuesDetail._4_);
                            //        break;
                            //    case ("<5>"):
                            //        streamWriter.WriteLine(LabelTempValuesDetail._5_);
                            //        break;
                            //    case ("<6>"):
                            //        streamWriter.WriteLine(LabelTempValuesDetail._6_);
                            //        break;
                            //    case ("<7>"):
                            //        streamWriter.WriteLine(LabelTempValuesDetail._7_);
                            //        break;
                            //    case ("<8>"):
                            //        streamWriter.WriteLine(LabelTempValuesDetail._8_);
                            //        break;
                            //    default:
                            //        streamWriter.WriteLine(t);
                            //        break;
                            //}
                        }

                        streamReader.Close();
                        streamWriter.Close();
                    }
                }
            }
        }
    }
}

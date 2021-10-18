using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;

namespace DataToZPL
{
    public class EngineZPL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="type"></param>
        public void ZPLGenerator(DataTable dataTableDetail, EnumLabelType type,int limit)
        {
            int i = 0;

            foreach (DataRow dataRow in dataTableDetail.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    //LabelTempValuesDetail.ValuePackDetail = item.ToString();
                    //LabelTempValuesDetail.SpliterDetail(limit);
                    //LabelTempValuesHeader.SpliterHeader(limit);
                    DataFromCSV.ValuePackDetail = item.ToString();           
                    DataFromCSV.SpliterDetail(limit);
                    DataFromCSV.SpliterHeader(limit);


                    if (type == EnumLabelType.BOX)
                    {
                        Config.FileNameScripTxt = "BOX_"+ i +".txt";
                    }
                    if (type == EnumLabelType.PALLET)
                    {
                        Config.FileNameScripTxt = "PALLET_MALA_" + i + ".txt";
                    }
                    if (type == EnumLabelType.TEST)
                    {
                        Config.FileNameScripTxt = "TEST_" + i + ".txt";
                    }

                    string filesName = null;
                    if (type == EnumLabelType.BOX)
                    {
                        filesName = Config.BOX_FileNameTempTxtData;
                    }
                    if (type == EnumLabelType.PALLET)
                    {
                        filesName = Config.PALLET_FileNameTempTxtData;
                    }
                    if (type == EnumLabelType.TEST)
                    {
                        filesName = Config.TEST_FileNameTempTxtData;
                    }

                    try
                    {
                        File.Copy(AppDomain.CurrentDomain.BaseDirectory + @"\" + Config.FolderNameTempTxtData + @"\" + filesName,
                            AppDomain.CurrentDomain.BaseDirectory + @"\" + Config.FolderNameScripTxt + @"\" + Config.FileNameScripTxt, true);
                    }
                    catch (IOException iox)
                    {
                        Console.WriteLine(iox.Message);
                    }

                    string editFiles = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\" + Config.FolderNameScripTxt + @"\" + Config.FileNameScripTxt);
                    
                    for (int j = 0; j < limit; j++)
                    {

                        //editFiles = editFiles.Replace(LabelTempValuesHeader._x_[j], LabelTempValuesDetail._x_[j]);
                        editFiles = editFiles.Replace(DataFromCSV._HEADER_[j], DataFromCSV._DETAIL_[j]);

                        File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\" + Config.FolderNameScripTxt + @"\" + Config.FileNameScripTxt, editFiles);
                    }

                }
                //LabelTempValuesHeader._x_ = new List<string>();
                //LabelTempValuesDetail._x_ = new List<string>();
                DataFromCSV._HEADER_ = new List<string>();
                DataFromCSV._DETAIL_ = new List<string>();
                i++;
            }
        }
    }
}
//using (StreamWriter streamWriter = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory +
//                                                    @"\" + Config.FolderNameScripTxt + @"\" +
//                                                    Config.FileNameScripTxt))
//{
//    using (StreamReader streamReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory +
//                                                        @"\" + Config.FolderNameTempTxtData + @"\" + filesName))
//    {
//        string t = null;

//        while ((t = streamReader.ReadLine()) != null)
//        {
//            for (int j = 0; j < limit; j++)
//            {
//                if (t == LabelTempValuesHeader._x_[j])
//                {
//                    streamWriter.WriteLine(LabelTempValuesDetail._x_[j]);
//                }
//            }
//            //if (t == LabelTempValuesHeader._x_[i])
//            //{
//            //    streamWriter.WriteLine(LabelTempValuesDetail._x_[i]);
//            //}
//            //else
//            //{
//            //    streamWriter.WriteLine(t);
//            //}
//        }
//        LabelTempValuesHeader._x_ = new List<string>();
//        LabelTempValuesDetail._x_ = new List<string>();
//        streamReader.Close();
//    }
//    streamWriter.Close();
//}
//}
/*
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
      else if (t == LabelTempValuesHeader._9_)
      {
          streamWriter.WriteLine(LabelTempValuesDetail._9_);
      }
      else if (t == LabelTempValuesHeader._10_)
      {
          streamWriter.WriteLine(LabelTempValuesDetail._10_);
      }
      else if (t == LabelTempValuesHeader._11_)
      {
          streamWriter.WriteLine(LabelTempValuesDetail._11_);
      }
      else if (t == LabelTempValuesHeader._12_)
      {
          streamWriter.WriteLine(LabelTempValuesDetail._12_);
      }
      else if (t == LabelTempValuesHeader._13_)
      {
          streamWriter.WriteLine(LabelTempValuesDetail._13_);
      }
      else if (t == LabelTempValuesHeader._14_)
      {
          streamWriter.WriteLine(LabelTempValuesDetail._14_);
      }
      else if (t == LabelTempValuesHeader._15_)
      {
          streamWriter.WriteLine(LabelTempValuesDetail._15_);
      }
      else if (t == LabelTempValuesHeader._16_)
      {
          streamWriter.WriteLine(LabelTempValuesDetail._16_);
      }
      else if (t == LabelTempValuesHeader._17_)
      {
          streamWriter.WriteLine(LabelTempValuesDetail._17_);
      }
      else if (t == LabelTempValuesHeader._18_)
      {
          streamWriter.WriteLine(LabelTempValuesDetail._18_);
      }
      else if (t == LabelTempValuesHeader._19_)
      {
          streamWriter.WriteLine(LabelTempValuesDetail._19_);
      }
      else if (t == LabelTempValuesHeader._20_)
      {
          streamWriter.WriteLine(LabelTempValuesDetail._20_);
      }
      else
      {
          streamWriter.WriteLine(t);
      }
      */
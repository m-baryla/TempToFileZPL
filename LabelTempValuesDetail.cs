using System.Collections.Generic;

namespace DataToZPL
{
    public static class LabelTempValuesDetail
    {
        public static string ValuePackDetail { get; set; }

        public static List<string> _x_ = new List<string>();

        public static void SpliterDetail(int limit)
        {
            for (int i = 0; i < limit; i++)
            {
                _x_.Add(ValuePackDetail.Split(Config.SplitChar)[i]);
            }
        }

        ///// <summary>
        ///// <0> - maping value from csv files to script ZPL
        ///// </summary>
        //public static string _0_
        //{
        //    get
        //    {
        //        return ValuePackDetail.Split(Config.SplitChar)[0];
        //    }
        //    set
        //    {
        //        if (ValuePackDetail.Split(Config.SplitChar)[0] != null)
        //            ValuePackDetail.Split(Config.SplitChar)[0] = value;
        //    }
        //}
        ///// <summary>
        ///// <1> - maping value from csv files to script ZPL
        ///// </summary>
        //public static string _1_
        //{
        //    get
        //    {
        //        return ValuePackDetail.Split(Config.SplitChar)[1];
        //    }
        //    set
        //    {
        //        if (ValuePackDetail.Split(Config.SplitChar)[1] != null)
        //            ValuePackDetail.Split(Config.SplitChar)[1] = value;
        //    }
        //}
        ///// <summary>
        ///// <2> - maping value from csv files to script ZPL
        ///// </summary>
        //public static string _2_
        //{
        //    get
        //    {
        //        return ValuePackDetail.Split(Config.SplitChar)[2];
        //    }
        //    set
        //    {
        //        if (ValuePackDetail.Split(Config.SplitChar)[2] != null)
        //            ValuePackDetail.Split(Config.SplitChar)[2] = value;
        //    }
        //}
        ///// <summary>
        ///// <3> - maping value from csv files to script ZPL
        ///// </summary>
        //public static string _3_
        //{
        //    get
        //    {
        //        return ValuePackDetail.Split(Config.SplitChar)[3];
        //    }
        //    set
        //    {
        //        if (ValuePackDetail.Split(Config.SplitChar)[3] != null)
        //            ValuePackDetail.Split(Config.SplitChar)[3] = value;
        //    }
        //}
        ///// <summary>
        ///// <4> - maping value from csv files to script ZPL
        ///// </summary>
        //public static string _4_
        //{
        //    get
        //    {
        //        return ValuePackDetail.Split(Config.SplitChar)[4];
        //    }
        //    set
        //    {
        //        if (ValuePackDetail.Split(Config.SplitChar)[4] != null)
        //            ValuePackDetail.Split(Config.SplitChar)[4] = value;
        //    }
        //}
        ///// <summary>
        ///// <5> - maping value from csv files to script ZPL
        ///// </summary>
        //public static string _5_
        //{
        //    get
        //    {
        //        return ValuePackDetail.Split(Config.SplitChar)[5];
        //    }
        //    set
        //    {
        //        if (ValuePackDetail.Split(Config.SplitChar)[5] != null)
        //            ValuePackDetail.Split(Config.SplitChar)[5] = value;
        //    }
        //}
        ///// <summary>
        ///// <6> - maping value from csv files to script ZPL
        ///// </summary>
        //public static string _6_
        //{
        //    get
        //    {
        //        return ValuePackDetail.Split(Config.SplitChar)[6];
        //    }
        //    set
        //    {
        //        if (ValuePackDetail.Split(Config.SplitChar)[6] != null)
        //            ValuePackDetail.Split(Config.SplitChar)[6] = value;
        //    }
        //}
        ///// <summary>
        ///// <7> - maping value from csv files to script ZPL
        ///// </summary>
        //public static string _7_
        //{
        //    get
        //    {
        //        return ValuePackDetail.Split(Config.SplitChar)[7];
        //    }
        //    set
        //    {
        //        if (ValuePackDetail.Split(Config.SplitChar)[7] != null)
        //            ValuePackDetail.Split(Config.SplitChar)[7] = value;
        //    }
        //}
        ///// <summary>
        ///// <8> - maping value from csv files to script ZPL
        ///// </summary>
        //public static string _8_
        //{
        //    get
        //    {
        //        return ValuePackDetail.Split(Config.SplitChar)[8];
        //    }
        //    set
        //    {
        //        if (ValuePackDetail.Split(Config.SplitChar)[8] != null)
        //            ValuePackDetail.Split(Config.SplitChar)[8] = value;
        //    }
        //}
        ///// <summary>
        ///// <9> - maping value from csv files to script ZPL
        ///// </summary>
        //public static string _9_
        //{
        //    get
        //    {
        //        return ValuePackDetail.Split(Config.SplitChar)[9];
        //    }
        //    set
        //    {
        //        if (ValuePackDetail.Split(Config.SplitChar)[9] != null)
        //            ValuePackDetail.Split(Config.SplitChar)[9] = value;
        //    }
        //}
        ///// <summary>
        ///// <10> - maping value from csv files to script ZPL
        ///// </summary>
        //public static string _10_
        //{
        //    get
        //    {
        //        return ValuePackDetail.Split(Config.SplitChar)[10];
        //    }
        //    set
        //    {
        //        if (ValuePackDetail.Split(Config.SplitChar)[10] != null)
        //            ValuePackDetail.Split(Config.SplitChar)[10] = value;
        //    }
        //}
        ///// <summary>
        ///// <11> - maping value from csv files to script ZPL
        ///// </summary>
        //public static string _11_
        //{
        //    get
        //    {
        //        return ValuePackDetail.Split(Config.SplitChar)[11];
        //    }
        //    set
        //    {
        //        if (ValuePackDetail.Split(Config.SplitChar)[11] != null)
        //            ValuePackDetail.Split(Config.SplitChar)[11] = value;
        //    }
        //}
        ///// <summary>
        ///// <12> - maping value from csv files to script ZPL
        ///// </summary>
        //public static string _12_
        //{
        //    get
        //    {
        //        return ValuePackDetail.Split(Config.SplitChar)[12];
        //    }
        //    set
        //    {
        //        if (ValuePackDetail.Split(Config.SplitChar)[12] != null)
        //            ValuePackDetail.Split(Config.SplitChar)[12] = value;
        //    }
        //}
        ///// <summary>
        ///// <13> - maping value from csv files to script ZPL
        ///// </summary>
        //public static string _13_
        //{
        //    get
        //    {
        //        return ValuePackDetail.Split(Config.SplitChar)[13];
        //    }
        //    set
        //    {
        //        if (ValuePackDetail.Split(Config.SplitChar)[13] != null)
        //            ValuePackDetail.Split(Config.SplitChar)[13] = value;
        //    }
        //}
        ///// <summary>
        ///// <14> - maping value from csv files to script ZPL
        ///// </summary>
        //public static string _14_
        //{
        //    get
        //    {
        //        return ValuePackDetail.Split(Config.SplitChar)[14];
        //    }
        //    set
        //    {
        //        if (ValuePackDetail.Split(Config.SplitChar)[14] != null)
        //            ValuePackDetail.Split(Config.SplitChar)[14] = value;
        //    }
        //}
        ///// <summary>
        ///// <15> - maping value from csv files to script ZPL
        ///// </summary>
        //public static string _15_
        //{
        //    get
        //    {
        //        return ValuePackDetail.Split(Config.SplitChar)[15];
        //    }
        //    set
        //    {
        //        if (ValuePackDetail.Split(Config.SplitChar)[15] != null)
        //            ValuePackDetail.Split(Config.SplitChar)[15] = value;
        //    }
        //}
        ///// <summary>
        ///// <16> - maping value from csv files to script ZPL
        ///// </summary>
        //public static string _16_
        //{
        //    get
        //    {
        //        return ValuePackDetail.Split(Config.SplitChar)[16];
        //    }
        //    set
        //    {
        //        if (ValuePackDetail.Split(Config.SplitChar)[16] != null)
        //            ValuePackDetail.Split(Config.SplitChar)[16] = value;
        //    }
        //}
        ///// <summary>
        ///// <17> - maping value from csv files to script ZPL
        ///// </summary>
        //public static string _17_
        //{
        //    get
        //    {
        //        return ValuePackDetail.Split(Config.SplitChar)[17];
        //    }
        //    set
        //    {
        //        if (ValuePackDetail.Split(Config.SplitChar)[17] != null)
        //            ValuePackDetail.Split(Config.SplitChar)[17] = value;
        //    }
        //}
        ///// <summary>
        ///// <18> - maping value from csv files to script ZPL
        ///// </summary>
        //public static string _18_
        //{
        //    get
        //    {
        //        return ValuePackDetail.Split(Config.SplitChar)[18];
        //    }
        //    set
        //    {
        //        if (ValuePackDetail.Split(Config.SplitChar)[18] != null)
        //            ValuePackDetail.Split(Config.SplitChar)[18] = value;
        //    }
        //}
        ///// <summary>
        ///// <19> - maping value from csv files to script ZPL
        ///// </summary>
        //public static string _19_
        //{
        //    get
        //    {
        //        return ValuePackDetail.Split(Config.SplitChar)[19];
        //    }
        //    set
        //    {
        //        if (ValuePackDetail.Split(Config.SplitChar)[19] != null)
        //            ValuePackDetail.Split(Config.SplitChar)[19] = value;
        //    }
        //}
        ////// <summary>
        ///// <20> - maping value from csv files to script ZPL
        ///// </summary>
        //public static string _20_
        //{
        //    get
        //    {
        //        return ValuePackDetail.Split(Config.SplitChar)[20];
        //    }
        //    set
        //    {
        //        if (ValuePackDetail.Split(Config.SplitChar)[20] != null)
        //            ValuePackDetail.Split(Config.SplitChar)[20] = value;
        //    }
        //}
    }
}

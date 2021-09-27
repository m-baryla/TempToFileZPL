using System.Reflection;

namespace DataToZPL
{
    public static class LabelTempValuesHeader
    {
        public static string ValuePackHeader { get; set; }


        /// <summary>
        /// <0> - maping value from csv files to script ZPL
        /// </summary>
        public static string _0_
        {
            get { return ValuePackHeader.Split(Config.SplitChar)[0]; }
            set { ValuePackHeader.Split(Config.SplitChar)[0] = value; }
        }
        /// <summary>
        /// <1> - maping value from csv files to script ZPL
        /// </summary>
        public static string _1_
        {
            get { return ValuePackHeader.Split(Config.SplitChar)[1]; }
            set { ValuePackHeader.Split(Config.SplitChar)[1] = value; }
        }
        /// <summary>
        /// <2> - maping value from csv files to script ZPL
        /// </summary>
        public static string _2_
        {
            get { return ValuePackHeader.Split(Config.SplitChar)[2]; }
            set { ValuePackHeader.Split(Config.SplitChar)[2] = value; }
        }
        /// <summary>
        /// <3> - maping value from csv files to script ZPL
        /// </summary>
        public static string _3_
        {
            get { return ValuePackHeader.Split(Config.SplitChar)[3]; }
            set { ValuePackHeader.Split(Config.SplitChar)[3] = value; }
        }
        /// <summary>
        /// <4> - maping value from csv files to script ZPL
        /// </summary>
        public static string _4_
        {
            get { return ValuePackHeader.Split(Config.SplitChar)[4]; }
            set { ValuePackHeader.Split(Config.SplitChar)[4] = value; }
        }
        /// <summary>
        /// <5> - maping value from csv files to script ZPL
        /// </summary>
        public static string _5_
        {
            get { return ValuePackHeader.Split(Config.SplitChar)[5]; }
            set { ValuePackHeader.Split(Config.SplitChar)[5] = value; }
        }
        /// <summary>
        /// <6> - maping value from csv files to script ZPL
        /// </summary>
        public static string _6_
        {
            get { return ValuePackHeader.Split(Config.SplitChar)[6]; }
            set { ValuePackHeader.Split(Config.SplitChar)[6] = value; }
        }
        /// <summary>
        /// <7> - maping value from csv files to script ZPL
        /// </summary>
        public static string _7_
        {
            get { return ValuePackHeader.Split(Config.SplitChar)[7]; }
            set { ValuePackHeader.Split(Config.SplitChar)[7] = value; }
        }
        /// <summary>
        /// <8> - maping value from csv files to script ZPL
        /// </summary>
        public static string _8_
        {
            get { return ValuePackHeader.Split(Config.SplitChar)[8]; }
            set { ValuePackHeader.Split(Config.SplitChar)[8] = value; }
        }
    }
}

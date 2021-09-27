namespace DataToZPL
{
    public static class LabelTempValuesDetail
    {
        public static string ValuePackDetail { get; set; }

        /// <summary>
        /// <0> - maping value from csv files to script ZPL
        /// </summary>
        public static string _0_
        {
            get { return ValuePackDetail.Split(Config.SplitChar)[0]; }  
            set { ValuePackDetail.Split(Config.SplitChar)[0] = value; }  
        }
        /// <summary>
        /// <1> - maping value from csv files to script ZPL
        /// </summary>
        public static string _1_
        {
            get { return ValuePackDetail.Split(Config.SplitChar)[1]; }
            set { ValuePackDetail.Split(Config.SplitChar)[1] = value; }
        }
        /// <summary>
        /// <2> - maping value from csv files to script ZPL
        /// </summary>
        public static string _2_
        {
            get { return ValuePackDetail.Split(Config.SplitChar)[2]; }
            set { ValuePackDetail.Split(Config.SplitChar)[2] = value; }
        }
        /// <summary>
        /// <3> - maping value from csv files to script ZPL
        /// </summary>
        public static string _3_
        {
            get { return ValuePackDetail.Split(Config.SplitChar)[3]; }
            set { ValuePackDetail.Split(Config.SplitChar)[3] = value; }
        }
        /// <summary>
        /// <4> - maping value from csv files to script ZPL
        /// </summary>
        public static string _4_
        {
            get { return ValuePackDetail.Split(Config.SplitChar)[4]; }
            set { ValuePackDetail.Split(Config.SplitChar)[4] = value; }
        }
        /// <summary>
        /// <5> - maping value from csv files to script ZPL
        /// </summary>
        public static string _5_
        {
            get { return ValuePackDetail.Split(Config.SplitChar)[5]; }
            set { ValuePackDetail.Split(Config.SplitChar)[5] = value; }
        }
        /// <summary>
        /// <6> - maping value from csv files to script ZPL
        /// </summary>
        public static string _6_
        {
            get { return ValuePackDetail.Split(Config.SplitChar)[6]; }
            set { ValuePackDetail.Split(Config.SplitChar)[6] = value; }
        }
        /// <summary>
        /// <7> - maping value from csv files to script ZPL
        /// </summary>
        public static string _7_
        {
            get { return ValuePackDetail.Split(Config.SplitChar)[7]; }
            set { ValuePackDetail.Split(Config.SplitChar)[7] = value; }
        }
        /// <summary>
        /// <8> - maping value from csv files to script ZPL
        /// </summary>
        public static string _8_
        {
            get { return ValuePackDetail.Split(Config.SplitChar)[8]; }
            set { ValuePackDetail.Split(Config.SplitChar)[8] = value; }
        }
    }
}

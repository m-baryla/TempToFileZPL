namespace DataToZPL
{
    public static class LabelTemp
    {
        public static string ValuePack { get; set; }

        /// <summary>
        /// <0> - maping value from csv files to script ZPL
        /// </summary>
        public static string ItemNumberCetes
        {
            get { return ValuePack.Split(';')[0]; }  
            set { ValuePack.Split(';')[0] = value; }  
        }
        /// <summary>
        /// <1> - maping value from csv files to script ZPL
        /// </summary>
        public static string ItemNumberCustomer
        {
            get { return ValuePack.Split(';')[1]; }
            set { ValuePack.Split(';')[1] = value; }
        }
        /// <summary>
        /// <2> - maping value from csv files to script ZPL
        /// </summary>
        public static string ItemDescription
        {
            get { return ValuePack.Split(';')[2]; }
            set { ValuePack.Split(';')[2] = value; }
        }
        /// <summary>
        /// <3> - maping value from csv files to script ZPL
        /// </summary>
        public static string Pieces
        {
            get { return ValuePack.Split(';')[3]; }
            set { ValuePack.Split(';')[3] = value; }
        }
        /// <summary>
        /// <4> - maping value from csv files to script ZPL
        /// </summary>
        public static string PiecesPerPackage
        {
            get { return ValuePack.Split(';')[4]; }
            set { ValuePack.Split(';')[4] = value; }
        }
        /// <summary>
        /// <5> - maping value from csv files to script ZPL
        /// </summary>
        public static string Batch
        {
            get { return ValuePack.Split(';')[5]; }
            set { ValuePack.Split(';')[5] = value; }
        }
        /// <summary>
        /// <6> - maping value from csv files to script ZPL
        /// </summary>
        public static string GTINCase
        {
            get { return ValuePack.Split(';')[6]; }
            set { ValuePack.Split(';')[6] = value; }
        }
        /// <summary>
        /// <7> - maping value from csv files to script ZPL
        /// </summary>
        public static string SSCC
        {
            get { return ValuePack.Split(';')[7]; }
            set { ValuePack.Split(';')[7] = value; }
        }
        /// <summary>
        /// <8> - maping value from csv files to script ZPL
        /// </summary>
        public static string Lot
        {
            get { return ValuePack.Split(';')[8]; }
            set { ValuePack.Split(';')[8] = value; }
        }
    }
}

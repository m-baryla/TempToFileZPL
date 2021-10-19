using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataToZPL
{
    public class BaseEngineZPL
    {
        public string GetFilesScriptName(EnumLabelType type, int i)
        {
            if (type == EnumLabelType.BOX)
            {
                return Config.FileNameScripTxt = "BOX_" + i + ".txt";
            }
            if (type == EnumLabelType.PALLET)
            {
                return Config.FileNameScripTxt = "PALLET_" + i + ".txt";
            }
            if (type == EnumLabelType.TEST)
            {
                return Config.FileNameScripTxt = "TEST_" + i + ".txt";
            }

            return "";
        }
        public string GetFilesZPLTemScript(EnumLabelType type)
        {
            if (type == EnumLabelType.BOX)
            {
                return Config.BOX_FileNameTempTxtData;
            }
            if (type == EnumLabelType.PALLET)
            {
                return Config.PALLET_FileNameTempTxtData;
            }
            if (type == EnumLabelType.TEST)
            {
                return Config.TEST_FileNameTempTxtData;
            }
            return "";
        }
    }
}

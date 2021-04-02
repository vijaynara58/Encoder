using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Encoder
{
    public class cConnect
    {
        private static string helpFilePath = @"G:\CDE Projects\c#Projects\Encoder\Properties\help.txt";

        public string readHelpFile()
        {
            string theText = "";

            try
            {
                theText = File.ReadAllText(helpFilePath, Encoding.Default);
            }
            catch(Exception ex)
            {
                theText = ex.Message.ToString();
                return theText;
            }
            return theText;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder
{
    public class cHelp : cConnect
    {

        //Method to read all text in help file
        public string readHelp()
        {
            string theText = "";

            try
            {
                theText = readHelpFile();
            }
            catch
            {
                theText = "Error occured while reading from the help file";
            }

            return theText;
        }
    }
}

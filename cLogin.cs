using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder
{
    class cLogin
    {
        //Define static to keep same class instance for a more effecient random
        public static Random rdn = new Random();

        //method that returns a string of 4 randomly generated numbers
        public string accessCode()
        {
            string theCode = "";

            //generate the 4 numbers and cast them as a string
            theCode += (rdn.Next(0, 9)).ToString();
            theCode += (rdn.Next(0, 9)).ToString();
            theCode += (rdn.Next(0, 9)).ToString();
            theCode += (rdn.Next(0, 9)).ToString();

            return theCode;


        }

    }
}

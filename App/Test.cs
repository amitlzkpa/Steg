using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace App
{
    class Test
    {

        static void Main(string[] args)
        {

            string srcImgPath = @"G:/00    CURRENT/Rhino/Steg/App/images/data (0).jpg";
            string embedFilePath = @"G:/00    CURRENT/Rhino/Steg/App/embeddata/data.txt";
            string outPath = @"G:/00    CURRENT/Rhino/Steg/App/out/";
            string encodedImgPath = @"G:/00    CURRENT/Rhino/Steg/App/out/15.png";
            string pwd = "misfits";

            //App.Encode("mera naam joker", srcImgPath, outPath, pwd);

            string s = Encoding.UTF8.GetString(App.Decode(encodedImgPath, pwd));
            bool q = s == "mera naam joker";



        }


    }
}

﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Web_Page_Spying
{
    class Program
    {
        static void Main(string[] args)
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var path1 = Path.Combine(desktop, "URLs.txt");
            var path2 = Path.Combine(desktop, "WebContent.txt");
            Console.WriteLine("Enter the url");
            string url = Console.ReadLine();
            //string url = "http://www.micarmenia.am/";

            WebSpy WebSpyer = new WebSpy(url);

            List<string> URLs = WebSpyer.FindeURLs();
            WebSpyer.SaveURLsToDoc(url, path1);
            WebSpyer.SaveWebContentToDoc(url, path2);

        }


        


    }
}

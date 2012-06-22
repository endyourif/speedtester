using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using SpeedTester;

namespace SpeedTester
{
    class CheckLink
    {
        public static List<int> Speeds = new List<int>();

        public static void Run(string url)
        {
            Speeds.Add(ReadUrl(url));
        }

        public static int ReadUrl(string url)
        {
            Uri uri = new Uri(url);
            return ReadUrl(uri);
        }

        public static int ReadUrl(Uri uri)
        {
            //Create the request object
            WebRequest req = WebRequest.Create(uri);

            int starttime = Environment.TickCount;
            WebResponse resp = req.GetResponse();
            int executionTime = Environment.TickCount - starttime;

            return executionTime;
        }
    }
}
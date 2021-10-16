using System;
using System.IO;
using System.Net;

class Scraper{
        static void Main(string[] args){
            string getChannels = String.Format("https://app.slack.com/client/T02JN670FLY");

            WebRequest reqObj = WebRequest.Create(getChannels);
            reqObj.Method = "GET";
            HttpWebResponse respObj = null;
            respObj = (HttpWebResponse)reqObj.GetResponse();
            string res = null;
            using(Stream stream = respObj.GetResponseStream()){
                StreamReader sr = new StreamReader(stream);
                res = sr.ReadToEnd();
                sr.Close();
                Console.WriteLine(res);
            }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace homework9
{
    class Program
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        public static int n = 0;
        string html;

        private void Crawl()
        {
            Console.WriteLine("开始爬行了……");
            while (true)
            {
                string[] now = new string[urls.Count - n];
                int j = 0;

                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    //current = url;
                    now[j] = url;
                    j++;
                    if (j > 8) break;
                }
                n += j;
                if (n > 10) break;
                
                Parallel.For(0, j, i =>
                {
                    Console.WriteLine("爬行" + now[i] + "页面");
                    string d = DownLoad(now[i]);
                    Parse(d);

                });

                for (int i = 0; i < j; i++)
                {
                    urls[now[i]] = true;

                }
                if (n > 10) break;

            }

            Console.WriteLine("爬行结束！");
        
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                html = webClient.DownloadString(url);
                count++;
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);

                return html;

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        public void Parse(string html)
        {
            string strRef = @"http://([\w-]+\.)+[\w-]+(/[\w- ./?％&=]*)?";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value;
                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }

        static void Main(string[] args)
        {
            //记录时间
            //Stopwatch watch = new Stopwatch();
            //watch.Start();

            Program myCrawler = new Program();

            string startUrl = "https://www.baidu.com/";
            if (args.Length >= 1) startUrl = args[0];

            //加入初始页面
            myCrawler.urls.Add(startUrl, false);

            //开始爬行
            new Thread(myCrawler.Crawl).Start();
            
        }
    }
}

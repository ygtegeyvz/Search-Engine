using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace SearchEngine
{
    public class Htmlİslemleri 
    {

        public string GetVeri(string url)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var client = new WebClient { Encoding = System.Text.Encoding.UTF8 };

            String htmlz = client.DownloadString(url);

            String html = HttpUtility.HtmlDecode(htmlz).ToString();

            return html;
           
        }


        public List<string> GetVeri(List<string> url)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            List<string> html_List = new List<string>();
            var client = new WebClient { Encoding = System.Text.Encoding.UTF8 };
            for (int i = 0; i < url.Count; i++)
            {
                String htmlz = client.DownloadString(url[i]);
              string  html= HttpUtility.HtmlDecode(htmlz).ToString();
                html_List.Add(html);

            }
            return html_List;
        }



        public int FindWord(string metin,string kelime)
        {
            int sayac = 0;
            UrlPuan turkcelestirNesnesi = new UrlPuan();    
            string yeniMetin = metin.ToLower();
            yeniMetin = turkcelestirNesnesi.turkcelestir(yeniMetin);

            int konum = yeniMetin.IndexOf(kelime+" ");

            while (konum != -1)
            {
                konum = yeniMetin.IndexOf(kelime+" ", konum + 1);

                sayac++;

            }
            return sayac;

        }
    }
}
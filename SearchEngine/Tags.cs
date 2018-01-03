using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace SearchEngine
{
    public class Tags : Search
    {

        public int TagsKelimeSayisi(string html, string aranankelime, Htmlİslemleri Cek_veri,string etiket)
        {

            HtmlAgilityPack.HtmlDocument htmldoc = new HtmlAgilityPack.HtmlDocument();
            htmldoc.LoadHtml(html);
            aranankelime.ToLower();
            HtmlNodeCollection basliklar = htmldoc.DocumentNode.SelectNodes(etiket);
            List<string> liste = new List<string>();
            foreach (var baslik in basliklar)
            {
                liste.Add(baslik.InnerText);
            }
            int y;
            string[] stringDizi = new string[liste.Count];

            for (int i = 0; i < liste.Count; i++)
            {
                stringDizi[i] = liste[i].ToString();
            }

            string tekstring;
            tekstring = ConvertStringArrayToString(stringDizi);
            tekstring = tekstring.ToLower();

            y = Cek_veri.FindWord(tekstring, aranankelime);

            return y;

        }
        public string ConvertStringArrayToString(string[] array)
        {
            //
            // Bu metod ile string builder nesne'mizi oluşturup
            // foreach döngüsü ve StringBuilder'in Append metodu
            // ilede stringimizi oluşturuyoruz
            //
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
                builder.Append(' ');
            }
            return builder.ToString();
        }

    }
}
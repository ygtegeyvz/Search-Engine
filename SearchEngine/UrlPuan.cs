using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SearchEngine.TagsFolder;
using HtmlAgilityPack;
using System.Text;
namespace SearchEngine
{
    public class UrlPuan : UrlSıralama
    {




        public int kelimeSayisi(string html, string aranankelime, Htmlİslemleri Cek_veri, string etiket)
        {

            HtmlAgilityPack.HtmlDocument htmldoc = new HtmlAgilityPack.HtmlDocument();
            htmldoc.LoadHtml(html);
            aranankelime.ToLower();
            aranankelime = turkcelestir(aranankelime);
            HtmlNodeCollection basliklar = htmldoc.DocumentNode.SelectNodes(etiket);
            List<string> liste = new List<string>();
            if (basliklar != null)
            {
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
                turkcelestir(tekstring);
                y = Cek_veri.FindWord(tekstring, aranankelime);
                return y;
            }
            return 0;
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

        public List<double> sıralamaPuan(List<string> url, List<string> aranankelime, Htmlİslemleri Cek_veri, string etiket, double puan, HtmlAgilityPack.HtmlDocument htmldoc)
        {

            List<double> etiketPuan = new List<double>();
            double anlikPuan = 0;

            HtmlNodeCollection basliklar = htmldoc.DocumentNode.SelectNodes(etiket);
            for (int j = 0; j < aranankelime.Count; j++)
            {

                aranankelime[j].ToLower();
                aranankelime[j] = turkcelestir(aranankelime[j]);
                List<string> liste = new List<string>();
                if (basliklar != null)
                {
                    foreach (var baslik in basliklar)
                    {
                        liste.Add(baslik.InnerText);
                    }
                    double kelimeSayisi;
                    string[] stringDizi = new string[liste.Count];

                    for (int k = 0; k < liste.Count; k++)
                    {
                        stringDizi[k] = liste[k].ToString();
                    }

                    string tekstring;
                    tekstring = ConvertStringArrayToString(stringDizi);
                    tekstring = tekstring.ToLower();
                    tekstring = turkcelestir(tekstring);
                    kelimeSayisi = Cek_veri.FindWord(tekstring, aranankelime[j]);
                    /*
                    if (kelimeSayisi>50)
                    {
                        kelimeSayisi = kelimeSayisi / 5;
                    }
                    else if (kelimeSayisi > 40)
                    {
                        kelimeSayisi = kelimeSayisi / 4;
                    }
                    else if (kelimeSayisi > 30)
                    {
                        kelimeSayisi = kelimeSayisi / 3;
                    }
                    else if (kelimeSayisi > 20)
                    {
                        kelimeSayisi = kelimeSayisi / 2;
                    }
                    */
                    anlikPuan = kelimeSayisi * puan;
              
                    etiketPuan.Add(anlikPuan);
                }
                else
                    continue;
            }
            return etiketPuan;

        }
        public string turkcelestir(string metin)
        {
            string yeniMetin;
            yeniMetin=metin.Replace('ü', 'u');
            yeniMetin = yeniMetin.Replace('ç', 'ç');
            yeniMetin = yeniMetin.Replace('ı', 'i');
            yeniMetin = yeniMetin.Replace('ö', 'o');
            yeniMetin = yeniMetin.Replace('ğ', 'g');
            yeniMetin = yeniMetin.Replace('ş', 's');
            return yeniMetin;
        }
    }
}
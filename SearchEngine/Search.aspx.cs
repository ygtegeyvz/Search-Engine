using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Globalization;
using System.IO;
using System.Text;
using HtmlAgilityPack;
using SearchEngine.TagsFolder;

namespace SearchEngine
{
    public partial class Search : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            text_goruntule.Text = " ";
            string url = UrlText.Text;
            string arananKelime = KeyText.Text;
            Htmlİslemleri Cek_veri = new Htmlİslemleri();
            //Htmli çekiyoruz
            string html = Cek_veri.GetVeri(url);
            //html ve aranan kelimedeki harfleri küçültüp,Türkçe karakter yapıyoruz.
            html = html.ToLower();
            arananKelime = arananKelime.ToLower();
            html = turkcelestir(html);
            arananKelime = turkcelestir(arananKelime);
            //Tag nesnelerimizi yaratıyoruz
#region Nesne yaratılan
            UrlPuan urlpuan = new UrlPuan();
            Title title = new Title();
            h2 h2 = new h2();
            h3 h3 = new h3();
            h1 h1 = new h1();
            Head head = new Head();
            Th th = new Th();

            LabelHtml label = new LabelHtml();
            ahref a = new ahref();
            Span span = new Span();

            int toplamKelimeSayisi;
            #endregion

#region etiketlere göre sayıları aldığımız kısım
            int title_sayi = title.kelimeSayisi(html, arananKelime, Cek_veri, title.etiket);
            int a_sayi = a.kelimeSayisi(html, arananKelime, Cek_veri, a.etiket);
            int h1_sayi = h1.kelimeSayisi(html, arananKelime, Cek_veri, h1.etiket);
            int h2_sayi = h2.kelimeSayisi(html, arananKelime, Cek_veri, h2.etiket);
            int h3_sayi = h3.kelimeSayisi(html, arananKelime, Cek_veri, h3.etiket);
            int th_sayi = th.kelimeSayisi(html, arananKelime, Cek_veri, th.etiket);
            int label_sayi = label.kelimeSayisi(html, arananKelime, Cek_veri, label.etiket);
            int span_sayi = span.kelimeSayisi(html, arananKelime, Cek_veri, span.etiket);
            int head_Sayi = head.kelimeSayisi(html, arananKelime, Cek_veri, head.etiket);
#endregion

            toplamKelimeSayisi = th_sayi + h1_sayi + title_sayi + a_sayi + title_sayi + h2_sayi + h3_sayi + span_sayi + head_Sayi+label_sayi;

            text_goruntule.Text = "Toplam Kelime Sayısı : " + toplamKelimeSayisi.ToString();
        }

        protected void SearchButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AnaSayfa.aspx");
        }

        public string turkcelestir(string metin)
        {
            string yeniMetin;
            yeniMetin = metin.Replace('ü', 'u');
            yeniMetin = yeniMetin.Replace('ç', 'ç');
            yeniMetin = yeniMetin.Replace('ı', 'i');
            yeniMetin = yeniMetin.Replace('ö', 'o');
            yeniMetin = yeniMetin.Replace('ğ', 'g');
            yeniMetin = yeniMetin.Replace('ş', 's');
            yeniMetin = yeniMetin.Replace('Ü', 'U');
            return yeniMetin;
        }

    }
}

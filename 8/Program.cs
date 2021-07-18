using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Data;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("I valute: ");
            string firstValute = Console.ReadLine();
            Console.Write("II valute: ");
            string secondValute = Console.ReadLine();

            string firstValuteName = "";
            string secondValuteName = "";

            float firstValuteInLari = 0;
            float secondValuteInLari = 0;

            var htmlCode = "";

            using (var client = new WebClient())
            {
                client.Headers.Add(HttpRequestHeader.UserAgent, "AvoidError");
                htmlCode = client.DownloadString("http://www.nbg.ge/rss.php");
            }

            var doc = new HtmlDocument();

            doc.LoadHtml(htmlCode);

            var dt = new DataTable();
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Value", typeof(string));

            var rows = doc.DocumentNode.SelectNodes("//tr");

            foreach (var row in rows)
            {
                var nodes = row.SelectNodes("td");

                if (nodes == null)
                    continue;

                var code = nodes[0].InnerText;
                var name = nodes[1].InnerText;
                var value = nodes[2].InnerText;

                dt.Rows.Add(code, name, value);
            }



            foreach (DataRow dataRow in dt.Rows)
            {
                for (int i = 0; i < dataRow.ItemArray.Length; i++)
                {
                    if (firstValute == dataRow.ItemArray[i].ToString())
                    {
                        firstValuteName = dataRow.ItemArray[i + 1].ToString();
                        firstValuteInLari += float.Parse(dataRow.ItemArray[i + 2].ToString());
                    } else if (secondValute == dataRow.ItemArray[i].ToString())
                    {
                        secondValuteName = dataRow.ItemArray[i + 1].ToString();
                        secondValuteInLari += float.Parse(dataRow.ItemArray[i + 2].ToString());
                    }
                }
            }
            Console.WriteLine(firstValuteName + " is " + firstValuteInLari/secondValuteInLari + " " +  secondValuteName);
        }
    }
}

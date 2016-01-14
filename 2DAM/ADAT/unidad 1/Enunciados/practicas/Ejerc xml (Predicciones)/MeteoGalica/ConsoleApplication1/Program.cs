using System;
using System.Net.Http;

namespace MeteoGalicia
{
    class Program
    {
        static void Main()
        {
            DownloadXmlAsync();
            Console.ReadLine();
        }

        static async void DownloadXmlAsync()
        {
            string url =
                "http://www2.meteogalicia.es/galego/observacion/estacions/contidos/DatosHistoricosXML_dezminutal.asp?est=10155&param=2542,2548,2540,2541,2547,2545&data1=18/11/2015&data2=18/11/2015&idprov=2&red=102";


            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            HttpContent content = response.Content;

            string result = await content.ReadAsStringAsync();
            Console.WriteLine(result);
        }
       /* async void DownloadXmlAsync()
        {
            string url =
                "http://www2.meteogalicia.es/galego/observacion/estacions/contidos/DatosHistoricosXML_dezminutal.asp?est=10155&param=2542,2548,2540,2541,2547,2545&data1=18/11/2015&data2=18/11/2015&idprov=2&red=102";

            HttpClient client = new HttpClient();
            Stream theStream = await client.GetStreamAsync(url);
            StreamReader reader = new StreamReader(theStream, System.Text.Encoding.ASCII, false);

            //  procesarFicheroXml( reader )

        }*/
    }
}

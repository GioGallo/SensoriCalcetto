using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SensoriCalcetto
{
    class Client
    {
        public List<Player> GetPlayers()
        {
            try
            {
                HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format("http://192.168.101.57:3000/giocatore"));

                WebReq.Method = "GET";

                HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

                string jsonString;
                using (Stream stream = WebResp.GetResponseStream())   
                {
                    StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                    jsonString = reader.ReadToEnd();
                }

                List<Player> items = JsonConvert.DeserializeObject<List<Player>>(jsonString);
                return items;
            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            return null;
        }

        public void SendData(string json,string url)
        {
            try
            {
                    HttpWebRequest httpWebRequestData;
                    httpWebRequestData = (HttpWebRequest)WebRequest.Create(string.Format(url));
                    httpWebRequestData.ContentType = "application/json";
                    httpWebRequestData.Method = "POST";
                    using (var streamWriter = new StreamWriter(httpWebRequestData.GetRequestStream()))
                    {
                        try
                        {
                            streamWriter.Write(json);
                            streamWriter.Flush();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        streamWriter.Close();

                    }
                    var httpResponseData = (HttpWebResponse)httpWebRequestData.GetResponse();
                    using (var streamReader = new StreamReader(httpResponseData.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                    }

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }
    }
}

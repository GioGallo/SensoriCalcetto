using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Configuration;

namespace SensoriCalcetto
{
    class Client
    {
        string ipMqtt = new AppSettingsReader().GetValue("IPMQTT", typeof(string)).ToString();
        string urlApi = new AppSettingsReader().GetValue("URLAPI", typeof(string)).ToString();
        public List<Player> GetPlayers()
        {
            try
            {
                HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format(urlApi+"/giocatore"));

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
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            return null;
        }

        public void SendData(string json, string topic)
        {
            MqttClient client = new MqttClient(ipMqtt);
            string clientId = Guid.NewGuid().ToString();

            try
            {
                client.Connect(clientId);

                client.Publish(topic, Encoding.UTF8.GetBytes(json));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }
    }
}
/*
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
    catch (Exception e)
    {
        System.Diagnostics.Debug.WriteLine(e);
    }
    return null;
}

public void SendData(string json, string url)
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
public void ChangeData(string json, string url)
{
    try
    {
        HttpWebRequest httpWebRequestData;
        httpWebRequestData = (HttpWebRequest)WebRequest.Create(string.Format(url));
        httpWebRequestData.ContentType = "application/json";
        httpWebRequestData.Method = "PUT";
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
*/

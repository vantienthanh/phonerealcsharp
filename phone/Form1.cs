using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Formatting;
using System.Threading;

namespace phone
{
    public partial class Form1 : Form
    {
        string configPath = "Configs";
        string configFile = "Configs//api.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void initProject()
        {
            if (!Directory.Exists(configPath))
            {
                Directory.CreateDirectory(configPath);
            }
            if (!File.Exists(configFile))
            {
                File.CreateText(configFile);
            }
        }

        private void btnSaveAPIKey_Click(object sender, EventArgs e)
        {
            File.WriteAllText(configFile, tbApiKey.Text);
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            string url = "https://www.phonerealus.com/api/line/changeService";
            //string url = "https://www.phonerealus.com/api/checkService";
            var json = new
            {
                services = "EBAY"
            };
            string jsonData = JsonConvert.SerializeObject(json);
            var content = new StringContent(jsonData.ToString(), Encoding.UTF8, "application/json");
            bool status = false;
            

            //Thread thread = new Thread(() =>
            //{
            //    do
            //    {
            //        HttpClient client = new HttpClient();

            //        // Add an Accept header for JSON format.
            //        client.DefaultRequestHeaders.Accept.Add(
            //        new MediaTypeWithQualityHeaderValue("application/json"));
            //        client.DefaultRequestHeaders.Add("X-API-Key", "CD9j3UVeMG2nFUPZ3xXCWFTH");

            //        HttpResponseMessage response = client.PostAsync(url, content).Result;
            //        requestCount++;

            //        this.Invoke(new MethodInvoker(() =>
            //        {
            //            lbRequestCount.Text = requestCount.ToString();
            //        }));

            //        if (response.IsSuccessStatusCode)
            //        {
            //            string dataObjects = response.Content.ReadAsStringAsync().Result;
            //            JObject jsonResult = JObject.Parse(dataObjects);
            //            string phoneNumber = jsonResult["phoneNumber"].ToString();

            //            this.Invoke(new MethodInvoker(() =>
            //            {
            //                lbPhoneNumber.Text = phoneNumber;
            //            }));

            //            status = true;
            //        }

            //        client.Dispose();
            //    } while (!status);
            //});

            Thread thread = new Thread(async () =>
            {
                int requestCount = 0;
                do
                {
                    status = await CheckHttpPostAsync(content, url);
                    requestCount++;

                    this.Invoke(new MethodInvoker(() =>
                    {
                        lbRequestCount.Text = requestCount.ToString();
                    }));

                } while (!status);
            });

            thread.IsBackground = true;
            thread.Start();
        }

        async Task<bool> CheckHttpPostAsync(System.Net.Http.HttpContent content, string url)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-API-Key", "CD9j3UVeMG2nFUPZ3xXCWFTH");

            try
            {
                var response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    JObject jsonResult = JObject.Parse(result);
                    string phoneNumber = jsonResult["phoneNumber"].ToString();

                    return true;
                } else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}

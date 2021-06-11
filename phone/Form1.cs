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
        static HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            initProject();
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

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string content = System.IO.File.ReadAllText(configFile);
            tbApiKey.Text = content;

            setApiKeyHeader();
            getGeneralInfo();
        }

        private void setApiKeyHeader()
        {
            if (client.DefaultRequestHeaders.Contains("X-API-Key"))
            {
                client.DefaultRequestHeaders.Remove("X-API-Key");
            }

            client.DefaultRequestHeaders.Add("X-API-Key", tbApiKey.Text);
        }

        private void btnSaveAPIKey_Click(object sender, EventArgs e)
        {
            File.WriteAllText(configFile, tbApiKey.Text);

            setApiKeyHeader();
            getGeneralInfo();
        }

        private async void btnSendRequest_Click(object sender, EventArgs e)
        {
            this.setApiKeyHeader();
            lbRequestStatus.Text = "Running";
            //string url1 = "https://www.phonerealus.com/api/line/changeService";
            string url2 = "https://www.phonerealus.com/api/checkService";

            bool status = false;

            Thread thread = new Thread(async () =>
            {
                int requestCount = 0;
                do
                {
                    status = await requestNewPhone();
                    requestCount++;

                    this.Invoke(new MethodInvoker(() =>
                    {
                        lbRequestCount.Text = requestCount.ToString();
                    }));

                } while (!status);

                this.Invoke(new MethodInvoker(() =>
                {
                    lbRequestStatus.Text = "Reddy";
                }));
            });

            thread.IsBackground = true;
            thread.Start();
        }

        private async Task getGeneralInfo()
        {
            string url = "https://www.phonerealus.com/api/account";

            try
            {
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    JObject jsonResult = JObject.Parse(result);

                    lbEmail.Text = jsonResult["username"].ToString();
                    lbBlance.Text = jsonResult["balance"].ToString();

                    foreach(var item in jsonResult["transactions"])
                    {
                        List<string> dataRows = new List<string>();
                        dataRows.Add((string)item["description"]);
                        dataRows.Add((string)item["amount"]);
                        dataRows.Add((string)item["timestamp"]);
                        dataGridViewTransaction.Rows.Add(dataRows.ToArray());
                    }
                } else
                {
                    lbEmail.Text = "No data";
                    lbBlance.Text = "0";
                    dataGridViewTransaction.Rows.Clear();
                    dataGridViewTransaction.Refresh();
                }
            }
            catch (Exception e)
            {
                lbEmail.Text = "No data";
                lbBlance.Text = "0";
                dataGridViewTransaction.Rows.Clear();
                dataGridViewTransaction.Refresh();
            }
        }

        private async Task<bool> requestNewPhone()
        {
            string url = "https://www.phonerealus.com/api/line/changeService";

            string jsonData = JsonConvert.SerializeObject(new { services = "EBAY" });
            var content = new StringContent(jsonData.ToString(), Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    JObject jsonResult = JObject.Parse(result);
                    string phoneNumber = jsonResult["phoneNumber"].ToString();

                    this.Invoke(new MethodInvoker(() =>
                    {
                        lbPhoneNumber.Text = phoneNumber.ToString();
                    }));

                    return true;
                } else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        private async Task<bool> getResponseSMS(string url)
        {
            string jsonData = JsonConvert.SerializeObject(new { services = "EBAY" });
            var content = new StringContent(jsonData.ToString(), Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    JObject jsonResult = JObject.Parse(result);
                    //string phoneNumber = jsonResult["phoneNumber"].ToString();

                    return true;
                }
                else
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

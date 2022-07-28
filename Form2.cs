using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using CsvHelper;
using System.Net.Http;

namespace HealingStream
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string[] countries = { "Colombia", "Eritrea" };
        string[] ClombiaCities = { "Amazonas", "Antioquia", "Arauca", "Atlantico", "Bolivar", "Boyaca", "Caldas", "Caqueta", "Casanare", "Cauca", "Cesar", "Choco", "Cordoba", "Cundinamarca", "Guainia", "Guaviare", "Huila", "Magdalena", "Meta", "Narino", "Putumayo", "Quindio", "Risaralda", "Santander", "Sucre", "Tolima", "Vaupes", "Vichada" };
        string[] EritreaCities = { "Barka", "Denkel", "Hamasen", "Sahil", "Semhar", "Senhit", "Seraye" };
        List<Object> records = new List<object>();

        void loadData()
        {
            using (var streamReader = new StreamReader("./ConsumerLeads.csv"))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    records = csvReader.GetRecords<object>().ToList();
                }
            }

        }
        string randomText (int len)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
           

            Random rnd = new Random();
            StringBuilder b = new StringBuilder(len);
            for (int i = 0; i < len; i++)
            {
                b.Append(chars[rnd.Next(chars.Length)]);
            }
            return b.ToString();
        }

        async Task createAccount(string firstname, string lastname, string email,string country, string state)
        {
           
            string Referal = randomText(7);
            string city = randomText(5);

            var clientHandler = new HttpClientHandler
            {
                UseCookies = false,
            };
            var client = new HttpClient(clientHandler);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://healingstreams.tv/3days/online_reg.php?r=ISLEWCAZ5"),

                Content = new FormUrlEncodedContent(new Dictionary<string, string>
    {
        { "firstname", firstname},
        { "lastname", lastname },
        { "email", email },
        { "zone", "ISLT/HSLHS/EWZA5GROUP" },
        { "country1",country },
        { "state1", state},
        { "city1", city },
        { "need_healing2", "on" },
    }),
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                if (body.Contains("is invalid"))
                {
                    LogBox.AppendText($"{email} --- Invalid \n");
                }
                else
                {
                    LogBox.AppendText($"{email} --- Success \n");
                }
                LogBox.ScrollToCaret();

            }
        }
        int selectedCountry = 0;
        string getCountry()
        {
            Random rand = new Random();
            int number = rand.Next(0, 1);
            selectedCountry = number;
            return countries[number];
        }


        string getCities()
        {
            if (selectedCountry == 0)
            {
                Random rand = new Random();
                int number = rand.Next(0, ClombiaCities.Length - 1);
                return ClombiaCities[number];
            }
            else
            {
                Random rand = new Random();
                int number = rand.Next(0, EritreaCities.Length - 1);
                return EritreaCities[number];
            }
        }
        int currentRow = 0;
        private async void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            isRunning = true;
            StopAndSave.Enabled = true;
            Stop.Enabled = true;
        }

        private void StopAndSave_Click(object sender, EventArgs e)
        {
            isRunning = false;
            Properties.Settings.Default.currentrow = currentRow;
            Properties.Settings.Default.Save();
            backgroundWorker1.CancelAsync();
            StartBTN.Enabled = true;
            StopAndSave.Enabled = false;
            Stop.Enabled = false;
        }
        bool isRunning = false;

        private async void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            StartBTN.Enabled = false;
            
            loadData();
            TotalLBL.Text = $"0/{records.Count()}";

            for (int i = Properties.Settings.Default.currentrow; i < records.Count(); i++)
            {
                if (isRunning == false) return;
                currentRow = i;
                dynamic item = records[i];
                await createAccount(item.FirstName, item.LastName, item.Email, getCountry(), getCities());
                TotalLBL.Text = $"{i}/{records.Count()}";
            }
            StartBTN.Enabled = true;
        }

        private void ResetBTN_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.currentrow = 0;
            Properties.Settings.Default.Save();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            isRunning = false;
            backgroundWorker1.CancelAsync();
            StartBTN.Enabled = true;
            StopAndSave.Enabled = false;
            Stop.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LogBox.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Currency
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            LoadCurrencies();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadCurrencies()
        {
            string url = "https://open.er-api.com/v6/latest/USD";
            string json;

            using (var client = new WebClient())
            {
                json = client.DownloadString(url);
            }

            var data = JObject.Parse(json);
            var currencies = data["rates"].ToObject<Dictionary<string, double>>().Keys;

            fromBox.Items.AddRange(currencies.ToArray());
            toBox.Items.AddRange(currencies.ToArray());

            fromBox.SelectedIndex = 0;
            toBox.SelectedIndex = 1;
        }

        private double getExchangeRate(string fromCurrency, string toCurrency)
        {
            string json;
            string url = $"https://open.er-api.com/v6/latest/{fromCurrency}";
            using (var client = new WebClient())
            {
                json = client.DownloadString(url);
            }
            var data = JObject.Parse(json);
            var rate = (double)data["rates"][toCurrency];

            return rate;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void convert(object sender, MouseEventArgs e)
        {
            string fromCurrency = fromBox.SelectedItem.ToString();
            string toCurrency = toBox.SelectedItem.ToString();

            if (fromBox.SelectedIndex == toBox.SelectedIndex)
            {

            }

            double amount;
            if (!double.TryParse(amountInput.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount to convert", "Error", MessageBoxButtons.OK);
                return;
            }

            double exchangeRate;
            try
            {
                exchangeRate = getExchangeRate(fromCurrency, toCurrency);
            }
            catch
            {
                MessageBox.Show("There is an error in retrieving the exchange rate.", "Error - API error", MessageBoxButtons.OK);
                return;
            }

            double convertedAmount = amount * exchangeRate;

            resultOutput.Text = convertedAmount.ToString("F3");
            fromRate.Text = $"1 {fromCurrency}";
            toRate.Text = $"{1 * exchangeRate} {toCurrency}";
        }

        private void swap(object sender, MouseEventArgs e)
        {
            int fromIndex = fromBox.SelectedIndex;
            int toIndex = toBox.SelectedIndex;

            fromBox.SelectedIndex = toIndex;
            toBox.SelectedIndex = fromIndex;
        }

        private void reset(object sender, MouseEventArgs e)
        {
            amountInput.Text = string.Empty;
            resultOutput.Text = "0.00";
            fromRate.Text = "0.00";
            toRate.Text = "0.00";
            fromBox.SelectedIndex = 0;
            toBox.SelectedIndex = 1;
        }
    }
}

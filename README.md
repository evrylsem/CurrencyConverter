# Currency Converter
A simple Windows Forms application to convert currencies using live exchange rates. The application fetches exchange rates from an online API and displays the conversion result.

## Features
- Convert between multiple currencies.
- Validate user input for amount and selected currencies.
- Swap source and target currencies.
- Reset input fields and results.

## Prerequisites
- .NET Framework (4.7.2 or later)
- Visual Studio (2019 or later)
- Newtonsoft.Json (can be installed via NuGet)

## Usage
#### 1. Clone repository using command-line:
<pre>
  git clone https://github.com/evrylsem/CurrencyConverter.git
</pre>
#### 2. Open CurrencyConverter > Debug > net8.0-windows folder
#### 3. Open the application named Currency.exe
![image](https://github.com/user-attachments/assets/9473bec9-d8de-47ff-81b6-ddb52cfef79b)

## Code Review
### Loading Currencies
- The `LoadCurrencies()` method fetches the exchange rates from the API and loads the available currencies into the combo boxes:
``` C#
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
```

### Getting Exchange Rate
The `getExchangeRate()` method fetches the exchange rate between two currencies:
``` C#
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
```

### Converting Currency
The `convert()` method performs the currency conversion and displays the result:
``` C#
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
```





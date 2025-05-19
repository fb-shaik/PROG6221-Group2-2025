using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace TipCalculator
{
    public partial class MainWindow : Window
    {
        //Exchange Rates set in a Dicitionary
        private readonly Dictionary<string, double> exchangeRates = new Dictionary<string, double>
        {
            { "USD", 1.0 },
            { "EUR", 0.89 },
            { "GBP", 0.75 },
            { "JPY", 146.0 }
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateTip_Click(object sender, RoutedEventArgs e)
        {
            /*try-catch that will do:
                - validate the input (bill amount and tip percentage and number of persons)
                - check if the selected currency is valid
                - calculate the tip
                - display the result >> textblock
            */

            try { 
                tipAmountTextBlock.Text = string.Empty; //checks that there is user input
                totalAmountTextBlock.Text = string.Empty;
                amountPerPersonTextBlock.Text = string.Empty;

                if(!double.TryParse(totalBillTextBox.Text, out double billAmount) || billAmount <= 0)
                {
                    tipAmountTextBlock.Text = "Please enter a valid bill amount.";
                    return;
                }

                if (!double.TryParse(tipPercentageTextBox.Text, out double tipPercentage) || tipPercentage < 0)
                {
                    tipAmountTextBlock.Text = "Please enter a valid tip percentage.";
                    return;
                }
                if (!int.TryParse(numberOfPersonsTextBox.Text, out int numberOfPersons) || numberOfPersons <= 0)
                {
                    tipAmountTextBlock.Text = "Number of persons must be a postivie value.";
                    return;
                }

                string selectedCurrency = ((ComboBoxItem)currencyComboBox.SelectedItem)?.Content.ToString() ?? "USD";

                if (!exchangeRates.ContainsKey(selectedCurrency))
                {
                    tipAmountTextBlock.Text = "Please select a valid currency.";
                    return;
                }

                double tipUSD = (billAmount * tipPercentage / 100);
                double totalAmountUSD = billAmount + tipUSD;
                double numberOfPersonsUSD = totalAmountUSD / numberOfPersons;

                tipAmountTextBlock.Text = $"Tip Amount: {tipUSD * exchangeRates[selectedCurrency]:C} {selectedCurrency}";
                totalAmountTextBlock.Text = $"Total Amount: {totalAmountUSD * exchangeRates[selectedCurrency]:C} {selectedCurrency}";
                amountPerPersonTextBlock.Text = $"Amount per Person: {numberOfPersonsUSD * exchangeRates[selectedCurrency]:C} {selectedCurrency}";

            }
            catch (Exception)
            {
                tipAmountTextBlock.Text = "An unexpected error occurred.";
            }
        }
    }
}

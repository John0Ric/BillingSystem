using Microsoft.Maui.Controls;

namespace BillingSystemMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnReadingChanged(object sender, TextChangedEventArgs e)
        {
            ComputeTotal();
        }

        private void ComputeTotal()
        {
            // Try to parse Previous Reading
            if (!int.TryParse(entryPreviousReading.Text, out int previous))
            {
                entryTotalAmount.Text = string.Empty;
                return;
            }

            // Try to parse Present Reading
            if (!int.TryParse(entryPresentReading.Text, out int present))
            {
                entryTotalAmount.Text = string.Empty;
                return;
            }

            // Try to parse Rate Per Cubic
            if (!decimal.TryParse(entryRate.Text, out decimal rate))
            {
                entryTotalAmount.Text = string.Empty;
                return;
            }

            // Comput consumption and total
            int consumption = present - previous;

            // Prevent negative consumption
            if (consumption < 0)
            {
                entryTotalAmount.Text = "Invalid readings";
                return;
            }

            decimal total = consumption * rate;
            entryTotalAmount.Text = total.ToString("N2");
        }

        // Save button stub
        private async void OnSaveBillClicked(object sender, EventArgs e)
        {
            await DisplayAlertAsync("Info",
                "Save functionality will be connected to the database in Activity 9.",
                "OK");
        }
    }
}

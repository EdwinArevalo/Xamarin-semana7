using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace Semana7Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QRreader : ContentPage
    {
        public QRreader()
        {
            InitializeComponent();
        }

        private void Clicked(object sender, EventArgs e)
        {
            Scan();
        }

        private async void Scan()
        {
            var scannerPage = new ZXingScannerPage();

            scannerPage.Title = "Lector de QR";
            scannerPage.OnScanResult += (result) =>
            {
                scannerPage.IsScanning = false;

                Device.BeginInvokeOnMainThread(() =>
                {
                    Navigation.PopAsync();
                    DisplayAlert("Valor de obtención ", result.Text, "OK");
                });
            };

            await Navigation.PushAsync(scannerPage);
        }
    }
}
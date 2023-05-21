using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ZXing.Mobile;
using Xamarin.Forms;
using ReaderQrApp.Services;

[assembly: Dependency(typeof(ReaderQrApp.Droid.Services.QrScanningService))]
namespace ReaderQrApp.Droid.Services
{
    public class QrScanningService : IQrScanningService
    {
        public async Task<string> ScanAsync()
        {
            var options = new MobileBarcodeScanningOptions();
            var scanner = new MobileBarcodeScanner();

            var context = Xamarin.Essentials.Platform.CurrentActivity; // Obtener el contexto actual

            var scanResult = await scanner.Scan(context, options);
            return scanResult.Text;
        }
    }
}
using System.Diagnostics;
using System.Threading.Tasks;
using AppBoundTest.iOS;
using Foundation;
using WebKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(WebView), typeof(CustomViewRenderer))]
namespace AppBoundTest.iOS
{

    public class CustomViewRenderer : WkWebViewRenderer
    {

        public CustomViewRenderer() : this(new WKWebViewConfiguration())
        {

        }

        public CustomViewRenderer(WKWebViewConfiguration cfg) : base(cfg)
        {
            cfg.LimitsNavigationsToAppBoundDomains = true;
            Debug.WriteLine("Set LimitsNavigationsToAppBoundDomains=true successfully");
        }
    }      
}

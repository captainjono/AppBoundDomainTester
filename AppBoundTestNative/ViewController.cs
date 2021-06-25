using CoreGraphics;
using Foundation;
using GCDWebServerBinding;
using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using UIKit;
using WebKit;

namespace AppBoundTest
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            
            var configuration = new WKWebViewConfiguration();
            configuration.LimitsNavigationsToAppBoundDomains = true;

            var webView = new WKWebView(viewWeb.Frame, configuration);
            webView.Frame = new CGRect(0, 0, viewWeb.Frame.Width, viewWeb.Frame.Height);
            
            webView.LoadRequest(new NSUrlRequest(new NSUrl("https://html5test.com/")));
            viewWeb.Add(webView);
        }
    }
}
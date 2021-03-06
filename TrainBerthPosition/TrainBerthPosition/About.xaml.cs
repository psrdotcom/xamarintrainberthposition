﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainBerthPosition
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class About : ContentPage
    {
        public About()
        {
            var titleView = new Label{ Text="Home", HeightRequest=30, WidthRequest=50, TextColor=Color.WhiteSmoke, FontSize=20.0 };
            NavigationPage.SetTitleView(this, titleView);

            WebView webView = new WebView();
            webView.MinimumHeightRequest = 50;
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"
                                <html><body>
                                <h1 align='center'>About App</h1>
				<p><b>Know your Indian train berth/seat position of AC 2 Tier (2A), AC 3 Tier (3A), Executive Chair Car (EC), Garid Rath (3A), Second Seating (2S), 
                        Second Seating - JanShatabdi (2S), Shatabdi Executive (1A) and Sleeper Class (SL) for most of the Indian trains.</b></p>
				<p>Its completly an <b><u>off-line</u></b> application, which means, no active Internet connection to use this application.</p>
				<p>Simply download, install and use the app.</p>
				<p>Just enter your berth/seat number and check it's exact berth position.</p>
                <p><i>Note: It doesn't tell your berth/seat PNR confirmation. It shows where exactly the confirmed seat located in the train coach.</i></p>

                <h3>Author</h3><p>Suresh Raju Pilli</p>
                
                                </body>
                                </html>";
            webView.Source = htmlSource;
            Content = webView;
        }
    }
}
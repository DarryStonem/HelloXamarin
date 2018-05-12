using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();         
			btnCrash.Clicked += (s, e) => 
			{ 
				Analytics.TrackEvent("Welcome Screen");
				throw new NotImplementedException(); 
			};
        }
    }
}

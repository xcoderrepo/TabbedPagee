using System;
using Naxam.Controls.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TabeedDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var tabs = new TopTabbedPage
            {
                Title = "TopTabs",
                BarBackgroundColor = Color.FromHex("9C27B0"),
                BarTextColor = Color.Black
               // SwipeEnabled = false,
                //BarIndicatorColor = Color.DeepPink,
                //BarTextColor = Color.DeepPink
            };

            tabs.CurrentPageChanged += Tabs_CurrentPageChanged;
            tabs.Children.Add(new Page1
            {
                Title = "My Page",
                
                BackgroundColor = Color.Aquamarine
            });
            tabs.Children.Add(new Page2
            {
                Title = "Tab 1",
                BackgroundColor = Color.Aqua
            });

            var m = new NavigationPage(tabs)
            {
                BarBackgroundColor = Color.FromHex("9C27B0"),
                BarTextColor = Color.White
            };
            m.PropertyChanged += (sender, e) =>
            {
                System.Diagnostics.Debug.WriteLine(e.PropertyName);
            };

            MainPage = m;
        }

        void Tabs_CurrentPageChanged(object sender, EventArgs e)
        {

        }


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

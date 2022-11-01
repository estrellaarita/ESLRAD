using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESLRAD
{
    public partial class App : Application
    {

        static Controllers.DBContactos dBEmple;

        public static Controllers.DBContactos dbemple
        {
            get
            {
                if (dBEmple == null)
                {
                    String DBName = "emple.db3";
                    String PathDB = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DBName);
                    dBEmple = new Controllers.DBContactos(PathDB);
                }

                return dBEmple;
            }

        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.PagePrincipal());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

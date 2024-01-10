namespace Airbox
{
    public partial class App : Application
    {
        public static NavigationPage Root { get; private set; }

        public App(MainPage mainPage)
        {
            InitializeComponent();

            MainPage = Root = new NavigationPage(mainPage);
        }
    }
}
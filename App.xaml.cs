using Microsoft.Maui.Controls;

namespace LoginSystemMaui
{
    public partial class App : Application
    {
        private string? user_logado;

        public App()
        {
            InitializeComponent();
            MainPage = new Login();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Title = "Login System Maui";
            window.Width = 400;
            window.Height = 600;
            return window;
        }

    }

}

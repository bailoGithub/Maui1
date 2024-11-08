using Microsoft.Extensions.Logging.Abstractions;

namespace MauiAppWelcom
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            string nomUtilisateur = nomEntry.Text;
            if (!string.IsNullOrEmpty(nomUtilisateur))
            {
                await DisplayAlert("Bienvenue", $"Bienvenue {nomUtilisateur} !", "OK");
            }
            else
            {
                await DisplayAlert("Bienvenue", "Veuillez taper votre nom !", "OK");
            }
        }

    }

}

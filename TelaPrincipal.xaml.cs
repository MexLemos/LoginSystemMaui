

namespace LoginSystemMaui;

public partial class TelaPrincipal : ContentPage
{
	public TelaPrincipal()
	{
		InitializeComponent();
        CarregarUsuarioLogadoAsync();
    }
    private async void CarregarUsuarioLogadoAsync()
    {
        var usuario_logado = await SecureStorage.Default.GetAsync("user_logado");
        lbl_boasvindas.Text = $"Bem-vindo(a) {usuario_logado}";
    }
    private async void Button_Logout_Clicked(object sender, EventArgs e)
    {
        bool confirmacao =await DisplayAlert("Confirmação", "Deseja realmente sair?", "Sim", "Não");
		if (confirmacao)
		{
			SecureStorage.Default.Remove("usuario_logado");
			App.Current.MainPage = new Login();
        }
        }
}
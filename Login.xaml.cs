
namespace LoginSystemMaui;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

/* Alteração não mesclada do projeto 'LoginSystemMaui (net8.0-android)'
Antes:
    private void OnLoginClicked()
	{
Após:
    private void OnLoginClickedAsync()
	{
*/
    private async void Button_Clicked(object sender, EventArgs e)
	{
		try
		{
            List<DadosUser> ListaUsuarios = new List<DadosUser>()
            {
               new DadosUser()
               {
                   Nome= "user1",
                Senha = "pass1"
               },
                new DadosUser()
               {
                   Nome= "user2",
                Senha = "pass2"
               },
                 new DadosUser()
               {
                   Nome= "user3",
                Senha = "pass3"
               }

            };
            DadosUser dados = new DadosUser()
            {
                Nome = entryUser.Text,
                Senha = entryPassword.Text
            };

            if (ListaUsuarios.Any(i=>dados.Nome==i.Nome && dados.Senha==i.Senha)) 
            
            {
                await SecureStorage.Default.SetAsync("user_logado", dados.Nome);
                await DisplayAlert("Sucesso!", $"Bemvindo {dados.Nome}","Ok");

                App.Current.MainPage = new TelaPrincipal();
            }
            else
            {
                throw new Exception("Usuário ou senha inválidos.");
            }
           
        }
		catch (Exception ex)
        {
            await DisplayAlert("Erro", "Falha no login: " + ex.Message, "OK");
        }

	}

    
}
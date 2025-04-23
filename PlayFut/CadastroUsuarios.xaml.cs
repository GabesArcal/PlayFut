using System.Diagnostics;

namespace PlayFut;

public partial class CadastroUsuarios : ContentPage
{
	public CadastroUsuarios()
	{
		InitializeComponent();
	}

    private void Salvar_Clicked(object sender, EventArgs e)
    {

		Usuario u = new Usuario();
		u.nome = EntryNome.Text;
		u.cpf = EntryCpf.Text;
		u.email = EntryEmail.Text;
		u.senha = EntrySenha.Text;
		u.nascimento = EntryNascimento.Date;
		
		u.Insere();

	}
}
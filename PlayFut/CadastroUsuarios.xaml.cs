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
		u.telefone = EntryTelefone.Text;
        u.email = EntryEmail.Text;
        u.cpf = EntryCpf.Text;
		u.senha = EntrySenha.Text;
		u.nascimento = EntryNascimento.Date;
		
		u.Insere();

	}
}
namespace PlayFut;

public partial class CadastroQuadras : ContentPage
{
	public CadastroQuadras()
	{
		InitializeComponent();

        PickerTipoQuadra.ItemsSource = new List<string>
    {
        "Futsal",
        "Society",
        "Basquete",
        "Vôlei"
    };
    }

    private Picker GetPickerTipoQuadra()
    {
        return PickerTipoQuadra;
    }

    private void Salvar_Clicked(object sender, EventArgs e)
    {
        if (PickerTipoQuadra.SelectedIndex == -1)
        {
            DisplayAlert("Erro", "Você precisa escolher um tipo de quadra.", "OK");
            return; // Interrompe o método aqui
        }

        Quadra u = new Quadra();

        u.nome_local = EntryNome.Text;
        u.imagem_principal = EntryImagem.Text;
        u.imagem_1 = EntryPri.Text;
        u.imagem_2 = EntrySeg.Text;
        u.imagem_3 = EntryTer.Text;
        u.preco = Decimal.Parse(EntryPreco.Text);
        u.dimensoes = EntryDimensoes.Text;
        u.iluminacao = EntryIluminacao.IsToggled;
        u.vestiario = EntryVestiario.IsToggled;
        u.bebedouro = EntryBebedouro.IsToggled;
        u.estacionamento = EntryEstacionamento.IsToggled;
        u.localizacao = EntryLocalizacao.Text;
        u.arquibancada = EntryArquibancada.IsToggled;
        u.coberta = EntryCoberta.IsToggled;
        u.acessibilidade = SwitchAcessibilidade.IsToggled;
        u.wifi = SwitchWifi.IsToggled;
        u.tipo_quadra = PickerTipoQuadra.SelectedItem.ToString();

        u.Insere();

    }
}
        
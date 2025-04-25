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
        u.nome = EntryNome.Text;
        u.imagem = EntryImagem.Text;
        u.imagem_secundaria = EntrySegunda.Text;
        u.imagem_terceira = EntryTerceira.Text;
        u.imagem_quarta = EntryQuarta.Text;
        u.tipo_quadra = PickerTipoQuadra.SelectedItem.ToString();
        //u.preco = EntryPreco.Text


        u.Insere();

    }
}
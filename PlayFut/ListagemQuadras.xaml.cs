namespace PlayFut;

public partial class ListagemQuadras : ContentPage
{
	public ListagemQuadras()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        Quadra quadra = new Quadra();
        Lista.ItemsSource = null;
        Lista.ItemsSource = quadra.BuscaTodos();
    }


}
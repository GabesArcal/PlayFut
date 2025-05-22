using System.Collections.ObjectModel;

namespace PlayFut;

public partial class ListaLocacoes : ContentPage
{
    public ObservableCollection<Locacao> locacoes { get; set; }

    public ListaLocacoes()
    {
        InitializeComponent();

        locacoes = new ObservableCollection<Locacao>
        {
            new Locacao { id = 1, id_usuario = 101, id_quadra = 201, data = "2025-05-20", hora = "18:00" },
            new Locacao { id = 2, id_usuario = 102, id_quadra = 202, data = "2025-05-21", hora = "19:00" },
            new Locacao { id = 3, id_usuario = 103, id_quadra = 203, data = "2025-05-22", hora = "20:00" }
        };

        ListaDeLocacoes.ItemsSource = locacoes; 
    }
}

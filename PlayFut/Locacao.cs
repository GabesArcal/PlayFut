namespace PlayFut;

public class Locacao
{
    public int id { get; set; }
    public int id_usuario { get; set; }
    public int id_quadra { get; set; }
    public string data { get; set; }
    public string hora { get; set; }

    public string DataHora => $"{data} {hora}";
}


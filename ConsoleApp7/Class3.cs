using System;

public class TelefonoBasico : Telefono
{
    public bool TieneRadioFM { get; set; }
    public bool TieneLinterna { get; set; }

    public void MostrarInformacionBasico()
    {
        MostrarInformacion();
        Console.WriteLine($"Tiene Radio FM: {TieneRadioFM}, Tiene Linterna: {TieneLinterna}");
    }
}
using System;

public class TelefonoInteligente : Telefono
{
    public string SistemaOperativo { get; set; }
    public int MemoriaRam { get; set; } // En GB

    public void MostrarInformacionInteligente()
    {
        MostrarInformacion();
        Console.WriteLine($"Sistema Operativo: {SistemaOperativo}, Memoria RAM: {MemoriaRam} GB");
    }
}
namespace TP05_SCHNAIDER.Models;
using Newtonsoft.Json;
public class Jugador
{
    [JsonProperty]
    public string Nombre { get; private set; }
    [JsonProperty]
    public int SalaActual { get; private set; }
    [JsonProperty]
    public int IntentosFallidos { get; private set; }

    public Jugador(string nombre)
    {
        Nombre = nombre;
        SalaActual = 1;
        IntentosFallidos = 0;
    }
    public void AvanzarSala(){
        SalaActual++;
    } 
    public void IncrementarErrores(){
        IntentosFallidos++;
}
}

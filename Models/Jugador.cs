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
    [JsonProperty]
    public DateTime tiempoInicial { get; private set; }

    public TimeSpan calcularTiempo(DateTime t1, DateTime t2){return t2 - t1;}

    public Jugador(string nombre, DateTime t)
    {
        tiempoInicial= t;
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

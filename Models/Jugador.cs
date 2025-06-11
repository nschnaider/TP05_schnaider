namespace TP05_SCHNAIDER.Models;
using Newtonsoft.Json;
public class Jugador
{
    [JsonProperty]
    public string Nombre { get; private set; }
    [JsonProperty]
    public int SalaActual { get; private set; }
    [JsonProperty]
    public bool TieneLlave { get; private set; }
    [JsonProperty]
    public bool JuegoTerminado { get; private set; }
    [JsonProperty]
    public bool acertijoCorrecto {get; private set;}
    [JsonProperty]
    public int IntentosFallidos { get; private set; }

    public Jugador(string nombre)
    {
        Nombre = nombre;
        SalaActual = 1;
        TieneLlave = false;
        JuegoTerminado = false;
        IntentosFallidos = 0;
        acertijoCorrecto = false;
    }

    public void AvanzarSala(){
        SalaActual++;
    } 
    public void ObtenerLlave(){
        TieneLlave = true;
    } 
    public void TerminarJuego(){
        JuegoTerminado = true;
    } 
    public void IncrementarErrores(){
        IntentosFallidos++;
}
    public void AcertijoTerminado(){
        acertijoCorrecto = true;
    }
}

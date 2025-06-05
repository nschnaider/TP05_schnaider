namespace TP05-SCHNAIDER.Models;
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
    public int IntentosFallidos { get; private set; }

    public Jugador(string nombre)
    {
        Nombre = nombre;
        SalaActual = 1;
        TieneLlave = false;
        JuegoTerminado = false;
        IntentosFallidos = 0;
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

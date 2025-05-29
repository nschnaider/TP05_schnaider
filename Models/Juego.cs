namespace TP04_schnaider.Models;
using Newtonsoft.Json;

public  class Juego
{
    [JsonProperty]
    public  string codigo1 {get; private set;}
    [JsonProperty]
    public  string codigo2{get; private set;}
    [JsonProperty]
    public  bool vagon1{get; private set;}
    [JsonProperty]
    public  bool vagon2{get; private set;}
    [JsonProperty]
    public  bool vagon3{get; private set;}
    [JsonProperty]
    public bool TieneLlaveComedor { get; private set; }
    [JsonProperty]
    public bool TieneLlavePasajero { get; private set; }
    public Juego(){
        codigo1 = "";
        codigo2 = "";
        vagon1 = false;
        vagon2 = false;
        vagon3 = false;
        TieneLlaveComedor = false;
        TieneLlavePasajero = false;

    }

    
   public  void inicializarJuego()
{
  
}
}
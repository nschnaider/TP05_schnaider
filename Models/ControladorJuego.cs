namespace TP05_SCHNAIDER.Models;
using Newtonsoft.Json;
public class ControladorJuego
{
     [JsonProperty]
     public Jugador jugador{get; private set;}
     [JsonProperty]
    public string CodigoEquipaje { get; private set;}
     [JsonProperty]
    public string CodigoComedor { get; private set;}
     [JsonProperty]
    public string acertijo { get; private set;}
    
    public ControladorJuego(string nombre){
        jugador = new Jugador(nombre);
        CodigoEquipaje = "742";
        CodigoComedor = "358";
        acertijo = "ticket";
        }
        public string ObtenerCodigoFinal()
    {
        string resultado = acertijo + CodigoComedor + CodigoEquipaje;
        return resultado;
    }

    public bool ValidarCodigo(string codigoIngresado)
    {
        bool validado = false;
        switch (jugador.SalaActual){
            case 1:
            if(codigoIngresado == CodigoEquipaje){
                validado = true;
            }
            break;
            case 2:
            if(codigoIngresado == CodigoComedor){
                validado = true;
            }
            break;
            case 3:
            if(codigoIngresado == acertijo){
                validado = true;
            }
            break;
            case 4:
            if(codigoIngresado == ObtenerCodigoFinal()){
                validado = true;
            }
            break;
        }
        return validado;
    }
    }
    
    

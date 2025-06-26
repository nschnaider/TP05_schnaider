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
    [JsonProperty]
    public string codigoFinal { get; private set;}

    
    public ControladorJuego(string nombre, DateTime ahora){
        jugador = new Jugador(nombre, ahora);

        CodigoEquipaje = "742";
        CodigoComedor = "473";
        acertijo = "70";
        codigoFinal = "199";

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
            if(codigoIngresado == codigoFinal){
                validado = true;
            }
            break;
        }
        return validado;
    }
    }
    
    

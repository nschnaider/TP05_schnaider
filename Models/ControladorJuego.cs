namespace TP05_SCHNAIDER.Models;
using Newtonsoft.Json;
public class ControladorJuego
{
     [JsonProperty]
    public string CodigoEquipaje { get; private set;} = "742";
     [JsonProperty]
    public string CodigoComedor { get; private set;} = "358";
     [JsonProperty]
    public string acertijo { get; private set;} = "ticket";

    public static string ObtenerCodigoFinal()
    {
        return CodigoEquipaje + CodigoComedor + acertijo;
    }

    public static bool ValidarCodigo(string codigoIngresado, int sala)
    {
        if (sala == 1) return codigoIngresado == CodigoEquipaje;
        if (sala == 2) return codigoIngresado == CodigoComedor;
        if (sala == 3) return codigoIngresado == acertijo;
        if (sala == 4) return codigoIngresado == ObtenerCodigoFinal();
        return false;
    }
}
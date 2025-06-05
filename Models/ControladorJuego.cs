namespace TP05-SCHNAIDER.Models;
using Newtonsoft.Json;
public class ControladorJuego
{
     [JsonProperty]
    public static string CodigoEquipaje { get; } = "742";
     [JsonProperty]
    public static string CodigoComedor { get; } = "358";
     [JsonProperty]
    public static int PosicionManiqui { get; } = 2;

    public static string ObtenerCodigoFinal()
    {
        return CodigoEquipaje + CodigoComedor + PosicionManiqui.ToString();
    }

    public static bool ValidarCodigo(string codigoIngresado, int sala)
    {
        if (sala == 1) return codigoIngresado == CodigoEquipaje;
        if (sala == 2) return codigoIngresado == CodigoComedor;
        if (sala == 4) return codigoIngresado == ObtenerCodigoFinal();
        return false;
    }
}
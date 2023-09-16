using Microsoft.AspNetCore.Mvc;

namespace Programacion_3_Conversion.Models
{
    public class MonedaViewModel 
    {
        public double cantidad { get; set; }
        public string moneda1 { get; set; }
        public string moneda2 { get; set; }
    }
}

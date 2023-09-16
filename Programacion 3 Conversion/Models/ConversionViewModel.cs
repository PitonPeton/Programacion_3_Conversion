using Microsoft.AspNetCore.Mvc;

namespace Programacion_3_Conversion.Models
{
    public static class ConversionViewModel
    {
        public static double Convert(MonedaViewModel value)
        {
            //moneda1 = de, moneda2 = a

            double result = 0;

            if (value.moneda1.Equals(value.moneda2))
            {
                result = value.cantidad;
            }

            if (value.moneda1.Equals("Dolar") && value.moneda2.Equals("Peso"))
            {
                result = Math.Round(value.cantidad * 56.80, 2);
            }
            if (value.moneda1.Equals("Peso") && value.moneda2.Equals("Dolar"))
            {
                result = Math.Round(value.cantidad / 56.80, 2);
            }

            if (value.moneda1.Equals("Euro") && value.moneda2.Equals("Peso"))
            {
                result = Math.Round(value.cantidad * 60.46, 2);
            }
            if (value.moneda1.Equals("Peso") && value.moneda2.Equals("Euro"))
            {
                result = Math.Round(value.cantidad / 60.46, 2);
            }

            if (value.moneda1.Equals("Dolar") && value.moneda2.Equals("Euro"))
            {
                result = Math.Round(value.cantidad * 1.06, 2);
            }
            if (value.moneda1.Equals("Euro") && value.moneda2.Equals("Dolar"))
            {
                result = Math.Round(value.cantidad / 1.06, 2);
            }

            return result;
        }
    }
}

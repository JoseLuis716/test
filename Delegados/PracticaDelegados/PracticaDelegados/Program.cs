using System;

namespace PracticaDelegados
{
    //Delegado
    public delegate float CalcularTotal(float subtotal);
    public delegate void CalcularTotalRef(ref float subtotal);
    class VueloNacional
    {
        float Iva
        {
            get
            {
                if (Redondo)
                    return 0.16f;
                return 0.04f;
            }
        }
        float Tua //tua es un impuesto que aplica a vuelos
        {
            get
            {
                return 220f;
            }
        }
        public bool Redondo { get; set; }
        //metodo 
        public float CalcularMontoTotal (float monto)
        {
            return monto + (monto * Iva) + Tua;
        }
    }
    class VueloInternacional
    {
        float Iva
        {
            get
            {
                if (Redondo)
                    return 0.16f;
                return 0.04f;
            }
        }
        float Tua //tua es un impuesto que aplica a vuelos
        {
            get
            {
                return 360f;
            }
        }
        float ImpuestoFederalSeguridad
        {
            get
            {
                return 190.75f;
            }
        }
        public bool Redondo { get; set; }
        public int Destino { get; set; }
        //metodo 
        public float CalcularMontoTotal(float monto)
        {
            float total = monto + (monto * Iva) + Tua;
            if (Destino == 559)
                return total + ImpuestoFederalSeguridad;
            return total;
        }
        public void CalcularTotalConImpuestos(ref float monto)
        {
            float total = monto + (monto * Iva) + Tua;
            if (Destino == 559)
                total += ImpuestoFederalSeguridad;
            monto = total;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            VueloNacional nacional = new VueloNacional
            {
                Redondo = true
            };
            //   CalcularTotal total = new CalcularTotal(nacional.CalcularMontoTotal);
            CalcularTotal total = nacional.CalcularMontoTotal; //es la instancia de un metodo float
            float precio = 5500f;
            Console.WriteLine("Costo de vuelo nacional: {0}", total(precio));

            VueloInternacional vueloInter = new VueloInternacional
            {
                Redondo = false,
                Destino = 559
            };
            float vuelointern = 9800f;
            total = vueloInter.CalcularMontoTotal;
            Console.WriteLine("Costo del vuelo internacional {0}",total(vuelointern));

            #region parametros
            float totalAdultoMayor = CalcularConDescuentoAdultoMayor(vuelointern, total);
            Console.WriteLine("Costo vuelo inter sencillo, desc adulto mayor {0}", totalAdultoMayor);
            #endregion

            #region multicast
            CalcularTotal totalB = vueloInter.CalcularMontoTotal;
            totalB += CalcularTotalSeguro;
            Console.WriteLine("Costo del seguro {0}", totalB(vuelointern));

            CalcularTotalRef tr = vueloInter.CalcularTotalConImpuestos;
            tr += CalcularTotalConSeguroRef;
            tr(ref vuelointern);
            Console.WriteLine("Costo del vuelo internacional con seguro {0}", vuelointern);
            #endregion

            #region consola
            Console.ReadKey();
            #endregion
        }
        static float CalcularConDescuentoAdultoMayor(float monto, CalcularTotal total)
        {
            float subtotal = total(monto);
            return subtotal - (0.35f * subtotal);
        }
        static float CalcularTotalSeguro(float total) //para relacionar con el delegado se necesita ser del mismo tipo de funcion y parametro
        {
            float porcentajeSeguro = 0.1f;
            return total * porcentajeSeguro;
        }
        static void CalcularTotalConSeguroRef (ref float total)
        {
            float porcentajeSeguro = 0.1f;
            total += total * porcentajeSeguro;
        }
    }
}

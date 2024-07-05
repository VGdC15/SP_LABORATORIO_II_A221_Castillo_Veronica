using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.WindowsForm
{
    public class Pirata : Barco
    {
        private int tripulacion;
        private float costo;

        public override int Tripulacion
        {
            get
            {
                if (tripulacion == 0)
                {
                    Random random = new Random();
                    tripulacion = random.Next(10, 31); 
                }
                return tripulacion;
            }
            set
            {
                tripulacion = value;
            }
        }

        public override void CalcularCosto()
        {
            Random random = new Random();
            costo = random.Next(2000, 12001); 
            Costo = costo; // Asigna el costo generado a la propiedad Costo de la clase base
        }

        public Pirata() : base()
        {
            // Constructor sin parámetros que no hace nada
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Costo: {Costo}");
            sb.AppendLine($"Estado Reparado: {EstadoReparado}");
            sb.AppendLine($"Operación: {Operacion}");
            sb.AppendLine($"Tripulación: {Tripulacion}");
            return sb.ToString();
        }
    }

}

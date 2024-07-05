using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.WindowsForm
{
    public class Marina : Barco
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
                    tripulacion = random.Next(30, 61); 
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
            costo = random.Next(5000, 25001); 
            Costo = costo; 
        }

        public Marina() : base()
        {
            
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

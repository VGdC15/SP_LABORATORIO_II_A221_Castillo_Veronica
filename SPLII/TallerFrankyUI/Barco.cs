using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.WindowsForm
{
    abstract class Barco
    {
        float costo;
        bool estadoReparado;
        string nombre;
        EOperacion eOperacion;
        int tripulacion;

        public float Costo { get; set; }
        public bool EstadoReparado { get; set; }
        public string Nombre { get; set; }
        public EOperacion Operacion { get; set; }
        public abstract int Tripulacion { get; set; }

        public Barco()
        {

        }

        public abstract void CalcularCosto();

        public bool CompararBarcos(Barco otroBarco)
        {
            if (otroBarco == null)
            {
                return false;
            }

            return this.Nombre == otroBarco.Nombre;
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

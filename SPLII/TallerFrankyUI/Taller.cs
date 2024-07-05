using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.WindowsForm
{
    public class Taller
    {
        private List<(string nombre, ETipoBarco tipo)> barcoNombres;

        public List<(string nombre, ETipoBarco tipo)> Barcos
        {
            get { return barcoNombres; }
        }

        public Taller()
        {
            barcoNombres = new List<(string nombre, ETipoBarco tipo)>();
        }

        public bool EncontrarBarco(string nombre, ETipoBarco tipo)
        {
            return barcoNombres.Contains((nombre, tipo));
        }

        public bool IngresarBarco(string nombre, ETipoBarco tipo)
        {
            if (!EncontrarBarco(nombre, tipo))
            {
                barcoNombres.Add((nombre, tipo));
                return true;
            }
            return false;
        }

        public bool Reparar(Taller taller)
        {
            if (taller == null)
            {
                return false;
            }

            try
            {
                foreach (var barco in barcoNombres)
                {
                    if (!Barco.EstadoReparado)
                    {
                        Barco.Nombre = barco.nombre;
                        Barco.Tipo = barco.tipo;
                        Barco.CalcularCosto();

                        // agregar la lógica para guardar en la BD
                        Console.WriteLine($"Reparación guardada para el barco: {barco.nombre} de tipo: {barco.tipo}");
                        Barco.EstadoReparado = true;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

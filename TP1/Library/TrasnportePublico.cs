using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class TrasnportePublico
    {
        int pasajeros;
        string nombreTransporte;

        public int Pasajeros { get => pasajeros; set => pasajeros = value; }
        public string NombreTransporte { get => nombreTransporte; set => nombreTransporte = value; }

        public TrasnportePublico(string nombre, int cantidadPasajeros)
        {
            this.NombreTransporte = nombre;
            this.Pasajeros = cantidadPasajeros;
        }

        public abstract void Avanzar();
        public abstract void Detenerse();

        /// <summary>
        /// Sobrecarga del ToString para mostrar los datos del transporte.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($" > {this.NombreTransporte} - {this.Pasajeros} Pasajeros");
            return sb.ToString();
        }

    }
}

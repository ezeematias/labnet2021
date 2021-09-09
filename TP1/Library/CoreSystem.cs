using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class CoreSystem
    {
        static List<Omnibus> omnibus;
        static List<Taxi> taxis;

        public static List<Omnibus> Omnibus { get => omnibus; set => omnibus = value; }
        public static List<Taxi> Taxis { get => taxis; set => taxis = value; }

        static CoreSystem()
        {
            Omnibus = new List<Omnibus>();
            Taxis = new List<Taxi>();
        }

        /// <summary>
        /// Muestra toda la información de la lista de Taxis.
        /// </summary>
        /// <returns>Un string con todos los datos.</returns>
        public static string MostrarTaxis()
        {
            StringBuilder sb = new StringBuilder();
            if (Taxis.Count > 0)
            {
                sb.AppendLine("\n*** TAXIS\n ***********\n");
                foreach (Taxi taxi in Taxis)
                {
                    sb.AppendLine(taxi.ToString());
                }
                sb.AppendLine("\n*******************************************************************\n");
            }
            else
            {
                sb.AppendLine("\n*******************************************************************\n");
                sb.AppendLine("*********************** NO HAY TAXIS ***********************");
                sb.AppendLine("\n*******************************************************************\n"); 
            }
            return sb.ToString();
        }

        /// <summary>
        /// Muestra toda la información de la lista de Omnibus.
        /// </summary>
        /// <returns>Un string con todos los datos.</returns>
        public static string MostrarOmnibus()
        {
            StringBuilder sb = new StringBuilder();
            if (Omnibus.Count > 0)
            {
                sb.AppendLine("\n*** OMNIBUS\n ****************\n");
                foreach (Omnibus omnibus in Omnibus)
                {
                    sb.AppendLine(omnibus.ToString());
                }
                sb.AppendLine("\n*******************************************************************\n");
            }
            else
            {
                sb.AppendLine("\n*******************************************************************\n");
                sb.AppendLine("********************** NO HAY OMNIBUS ********************");
                sb.AppendLine("\n*******************************************************************\n");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Comprueba la disponibilidad de transportes.
        /// </summary>
        /// <returns></returns>
        public static bool DisponibilidadTransporte()
        {
            bool output = true;
            if (Omnibus.Count == 5 && Taxis.Count == 5)
            {
                output = false;
            }
            return output;
        }
    }
}

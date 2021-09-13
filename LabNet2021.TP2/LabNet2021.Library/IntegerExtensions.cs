using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Library
{
    public static class IntegerExtensions
    {
        /// <summary>
        /// Receive a number to be divided by zero.
        /// </summary>
        /// <param name="number">Number to divide</param>
        /// <returns>Operation result.</returns>
        public static string DivideForZero(this int number)
        {
            try
            {
                number /= 0;
                return "La operación fue exitosa.";
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

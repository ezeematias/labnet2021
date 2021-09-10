using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Library
{
    public static class Logic
    {
        /// <summary>
        /// Receive a number to be divided by zero.
        /// </summary>
        /// <param name="number">Number to divide</param>
        /// <returns>Operation result.</returns>
        public static string DivideForZero(int number)
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

        /// <summary>
        /// Perform division between two numbers
        /// </summary>
        /// <param name="num1">Number to divide</param>
        /// <param name="num2">Divisor number</param>
        /// <returns>Operation result.</returns>
        public static float DivisionOfTwoNumber(int num1, int num2)
        {
            try
            {
                if (num2 == 0)
                {
                    throw new DivideByZeroException();
                }
                return (float)num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                throw new DivideByZeroException("¡Solo Chuck Norris divide por cero!", ex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Validate that the string entered is an int number.
        /// </summary>
        /// <param name="number">String to validate</param>
        /// <returns>The number converted to int or exception of the data entered incorrectly.</returns>
        public static int ValidationInteger(string number)
        {
            if (int.TryParse(number, out int result))
            {
                return result;
            }
            else
            {
                throw new InvalidInputException("Seguro Ingreso una letra o no ingreso nada!");
            }
        }

        /// <summary>
        /// Protected access.
        /// </summary>
        public static void FieldAccess()
        {
            throw new FieldAccessException("No podes acceder acá, ¡Solo acceso VIP");
        }

        /// <summary>
        /// Fills everything with smoke.
        /// </summary>
        public static void SmokeBomb()
        {            
            throw new SmokeBombException("Se llena de humo todo, ¡Corran!");
        }
    }
}

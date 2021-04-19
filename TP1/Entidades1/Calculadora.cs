using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Valida que el caracter ingresado sea un operador aritmetico
        /// </summary>
        /// <param name="operador">caracter a validar</param>
        /// <returns>el operador validado o el operador suma en caso de no pertenecer</returns>
        private static string ValidarOperador(char operador)
        {
            string salida = "+";

            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                salida = operador.ToString();
            }

            return salida;
        }

        /// <summary>
        /// realiza la operacion de dos numeros segun el operador
        /// </summary>
        /// <param name="num1">numero 1</param>
        /// <param name="num2">numero 2</param>
        /// <param name="operador">operador aritmetico</param>
        /// <returns>resultado de la operacion</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;
            operador = ValidarOperador(char.Parse(operador));

            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;

                default:
                    resultado = 0;
                    break;
            }


            return resultado;
        }
    }
}

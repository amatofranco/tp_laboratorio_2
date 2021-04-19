using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        /// atributos
        private double numero;

        // propiedades
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);

            }
        }

        //metodos

        /// <summary>
        /// Convierte la cadena de binario recibida en cadena de numero decimal
        /// </summary>
        /// <param name="binario">Cadena a convertir</param>
        /// <returns>cadena de decimal o "valor invalido" si no fue posible</returns>
        public string BinarioDecimal(string binario)
        {
            int numeroDecimal = 0;
            string resultado;
            int cantidadCaracteres = binario.Length;

            if (EsBinario(binario))
            {
                foreach (char caracter in binario)
                {
                    cantidadCaracteres--;

                    if (caracter == '1')
                    {
                        numeroDecimal += (int)Math.Pow(2, cantidadCaracteres);
                    }

                }

                resultado = numeroDecimal.ToString();

            }
            else
            {
                resultado = "Valor Invalido";
            }
            return resultado;
        }

        /// <summary>
        /// Convierte el numero decimal recibido en cadena de numero binario
        /// </summary>
        /// <param name="numero">numero decimal recibido</param>
        /// <returns> cadena de numero binario o "valor invalido" si no fue posible</returns>
        public string DecimalBinario(double numero)
        {
            string resultado = "";
            int restoDivision;
            if (numero > 0)
            {
                do
                {
                    restoDivision = (int)numero % 2;
                    numero = (int)numero / 2;
                    resultado = restoDivision.ToString() + resultado;

                }
                while (numero > 0);
            }
            else
            {
                resultado = "Valor invalido";

            }
            return resultado;
        }

        /// <summary>
        /// Convierte la cadena de decimal recibida en cadena de numero binario
        /// </summary>
        /// <param name="numero">cadena de decimal</param>
        /// <returns> cadena de numero binario o "valor invalido" si no fue posible</returns>
        public string DecimalBinario(string numero)
        {
            double numeroDecimal;

            string resultado;

            if (double.TryParse(numero, out numeroDecimal))
            {

                resultado = DecimalBinario(numeroDecimal);
            }

            else
            {
                resultado = "Valor invalido";
            }

            return resultado;

        }

        /// <summary>
        /// valida si la cadena recibida es un numero binario
        /// </summary>
        /// <param name="binario">cadena a validar</param>
        /// <returns>true si pertenece false si no pertenece</returns>
        private bool EsBinario(string binario)
        {

            foreach (char caracter in binario)
            {
                if (caracter!='0' && caracter != '1')
                {
                    return false;
                }
            }

            return true;
        }


        // constructores


        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        /// <summary>
        /// Permite realizar la suma de los valores de dos objetos Numero
        /// </summary>
        /// <param name="n1">objeto Numero 1</param>
        /// <param name="n2">objeto Numero 2</param>
        /// <returns>suma obtenida</returns>
        /// 
        public static double operator + (Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;

        }

        /// <summary>
        /// Permite realizar la resta de los valores de dos objetos Numero
        /// </summary>
        /// <param name="n1">objeto Numero 1</param>
        /// <param name="n2">objeto Numero 2</param>
        /// <returns>resta obtenida</returns>

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;

        }

        /// <summary>
        /// Permite realizar la division de los valores de dos objetos Numero
        /// </summary>
        /// <param name="n1">objeto Numero 1</param>
        /// <param name="n2">objeto Numero 2</param>
        /// <returns>division obtenida</returns>

        public static double operator /(Numero n1, Numero n2)
        {
            double division;

            if (n2.numero == 0)
            {
                division = double.MinValue;
            }

            else
            {
                division = n1.numero / n2.numero;
            }
            return division;
        }

        /// <summary>
        /// Permite realizar la multiplicacion de los valores de dos objetos Numero
        /// </summary>
        /// <param name="n1">objeto Numero 1</param>
        /// <param name="n2">objeto Numero 2</param>
        /// <returns>multiplicacion obtenida</returns>

        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;

        }

        /// <summary>
        /// Valida si la cadena recibida es un numero
        /// </summary>
        /// <param name="strNumero">cadena a validar</param>
        /// <returns>numero validado o 0 si no pudo validarse</returns>

        private double ValidarNumero(string strNumero)
        {
            double numeroSalida = 0;
            double numeroParseado;

            if (double.TryParse(strNumero, out numeroParseado))
            {
                numeroSalida = numeroParseado;
            }

            return numeroSalida;

        }


    }
}

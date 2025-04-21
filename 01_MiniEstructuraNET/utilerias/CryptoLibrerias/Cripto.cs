///////////////////////////////////////////////////////////////////////////////
// Encryption and decryption using DPAPI functions.
//
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
// PURPOSE.
//
using System;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;

/// <summary>
/// Encrypts and decrypts data using DPAPI functions.
/// </summary>
namespace utilerias.CryptoLibrerias
{
    public class Cripto
    {
        private static string patron_busqueda = "1234567890";
        private static string Patron_encripta = "7RYEAZ98HK";

        public static String EncriptarCadena(String cadena)
        {

            int idx;
            String result = "";

            for (idx = 0; idx <= cadena.Length - 1; idx++)
            {
                result = result + EncriptarCaracter(cadena.Substring(idx, 1), cadena.Length, idx);
            }

            return result;

        }


        public static String EncriptarCaracter(String caracter, int variable, int a_indice)
        {

            int indice;

            if (patron_busqueda.IndexOf(caracter) != -1)
            {

                indice = (patron_busqueda.IndexOf(caracter) + variable + a_indice) % patron_busqueda.Length;

                return Patron_encripta.Substring(indice, 1);
            }
            return caracter;
        }

        public static String DesEncriptarCadena(String cadena)
        {

            int idx;
            String result = "";

            for (idx = 0; idx <= cadena.Length - 1; idx++)
            {
                result = result + DesEncriptarCaracter(cadena.Substring(idx, 1), cadena.Length, idx);
            }
            return result;
        }

        private static String DesEncriptarCaracter(String caracter, int variable, int a_indice)
        {

            int indice;


            if (Patron_encripta.IndexOf(caracter) != -1)
            {

                if ((Patron_encripta.IndexOf(caracter) - variable - a_indice) > 0)
                {

                    indice = (Patron_encripta.IndexOf(caracter) - variable - a_indice) % Patron_encripta.Length;
                    
                }
                else
                {

                    indice = (patron_busqueda.Length) + ((Patron_encripta.IndexOf(caracter) - variable - a_indice) % Patron_encripta.Length);

                }

                indice = indice % Patron_encripta.Length;

                return patron_busqueda.Substring(indice, 1);

            }
            else
            {

                return caracter;

            }

        }

    }
}
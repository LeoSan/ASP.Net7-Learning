using System;
using System.Collections.Generic;
using System.Text;

namespace utilerias.Usuario
{
    public class Password
    {

        /// <summario>
        /// Método estático tipo string que genera una cadena alfanumerica aleatoria
        /// </summario>
        /// <parametro nombre="LongitudDeLaCadena">
        /// Variable tipo entero que recibe el tamaño de la cadena a generar
        /// </parametro>
        public static string Generar(int LongitudDeLaCadena) { 
            Random rand = new Random();
            char[] cc = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','ñ','o','p','q','r','s','t','u','v','w','x','y','z',
                         'A','B','C','D','E','F','G','H','I','J','K','L','M','N','Ñ','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                         '1','2','3','4','5','6','7','8','9','0'};

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < LongitudDeLaCadena; i++) 
                sb.Append(cc[rand.Next(cc.Length-1)]);
            return sb.ToString();
        }


        /// <summario>
        /// Método estático tipo string que encripta una cadena alfanumérica
        /// </summario>
        /// <parametro nombre="miStr">
        /// Variable String  que recibe la cadena a encriptar
        /// </parametro>
        public static string EncriptaCadena(String miStr){
            String miStrEncriptada = "";
            char[]  miStrChars = miStr.ToCharArray();

            for (int i = 0; i < miStr.Length; i++) {
                miStrEncriptada += (char) (((int)miStrChars[i]) + 3) ;
            }
            return miStrEncriptada;
        }

        /// <summario>
        /// Método estático tipo string que desencripta una cadena alfanumérica
        /// </summario>
        /// <parametro nombre="miStr">
        /// Variable String  que recibe la cadena a desencriptar
        /// </parametro>
        public static string DesencriptaCadena(String miStr)
        {
            String miStrDesencriptada = "";
            char[] miStrChars = miStr.ToCharArray();

            for (int i = 0; i < miStr.Length; i++)
            {
                miStrDesencriptada += (char)(((int)miStrChars[i]) - 3);
            }
            return miStrDesencriptada;
        }
    }
}

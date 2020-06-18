using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVectores.clases
{
    public class NumLetras
    {
        private static string[] unidades = new string[] {"", "un", "dos", "tres",
        "cuatro", "cinco", "seis", "siete", "ocho","nueve","diez","once","doce",
        "trece","catorce", "quince","dieciseis","diecisiete","dieciocho","diecinueve"};

        private static string[] decenas = new string[] {"","diez","veinte","treinta","cuarenta",
        "cincuenta","sesenta","setenta","ochenta","noventa"};

        private static string[] centenas = new string[] {"","cien","doscientos","trescientos",
        "cuatrocientos","quinientos","seiscientos","setecientos","ochocientos",
        "novecientos"};

        public static string getUnidades(int num)
        {
            string aux="";
            if (num < 20)
                aux = unidades[num];
            else if (num == 0)
                aux = "cero";
            return aux;
        }
        public static string getDecenas(int num)
        {
            string aux = "";
            if (num >= 20 && num < 100)
            {
                aux = decenas[num / 10];
                if (num % 10 != 0)
                {
                    aux = aux + " y " + unidades[num % 10];
                }
            }
            return aux;
        }

        public static string getLetras(int num)
        {
            string aux = "";
            if (num<20)
                aux = getUnidades(num);
            else if (num < 100)
                aux = getDecenas(num);
            else if (num < 1000)
            {
                aux = centenas[num / 100];
                if (num % 100 < 20)
                {
                    aux = aux + " " + getUnidades(num % 100);
                }
                else 
                    aux = aux + " " + getDecenas(num % 100);
            }
            return aux;
        }
  
    
        public static string NumeroaLetras(Int32 num)
        {
            int grupo = 0; string cad = "";
            Int32 x = 1;
            while (x <= num)
            {

                Int32 valor = (num % (x * 1000)) / x;

                Console.WriteLine();
                Console.WriteLine("residuo: {0}", valor);
                if (valor>0)
                cad = getLetras(valor) + "{" + grupo +"} " + cad;

                x *= 1000;
                grupo++;
            }
            StringBuilder res = new StringBuilder(cad);
            res.Replace("{0}", "");
            res.Replace("{1}", " mil");
            res.Replace("{2}", " millones");
            return res.ToString();
        }
    }
}

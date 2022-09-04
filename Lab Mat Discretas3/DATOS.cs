using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Mat_Discretas3
{
    static internal class DATOS
    {
        static public int num1;
        static public int num2;

        static public bool testNums()
        {
            if (num1 > 0 && num2 > 0) {
                if(num1%2 != 0 || num2%2 != 0)
                {
                    MessageBox.Show("Ingrese dos numeros pares");
                    return false;
                }
                else { return true; }

            }
            return false;
        }
        static public string suma()
        {
            int suma = num1 + num2;
            if(suma%2 == 0)
            {
                return "La suma de los dos numeros es par";
            }
            else { return "La suma de los dos numeros no es par"; }
        }
        static public string numeroPrimo()
        {
            bool flag = false;
            string nums = "";
            for(int i = 1; i<=9; i++)
            {
                if (Primo(i))
                {
                    flag = true;
                    nums += " " + i;
                }
            }
            if (flag) { return "Hay numeros primos dentro de ese rango que son:" + nums; } else
            {
                return "No hay numeros pares dentro de ese rango";
            }
        }
        static bool Primo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

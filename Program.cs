using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class PROGRAMA2
{
    public static void Main()
    {
        string TEXTO = "OSCAR ABRAHAM HUERTA MADUEÑO";
        string Final = "";
        string Palabra = "";

        foreach (char Letra in TEXTO)
        {
            if (Letra != ' ')
                Palabra += Letra;
            else
            {
                Final = " " + Palabra + Final;
                Palabra = "";
            }
        }
        Final = Palabra + Final;
        Console.WriteLine(Final); 
        Console.ReadKey();
    }
}

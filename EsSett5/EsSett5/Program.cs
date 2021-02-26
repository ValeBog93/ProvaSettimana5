using System;
using System.Collections.Generic;

namespace EsSett5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creo un dizzionario per creare gli esami del corso di laure Ing Meccanica:
            var dizEsamiIngMecc = new Dictionary<string, bool>();
            dizEsamiIngMecc.Add("Analisi1", false);
            dizEsamiIngMecc.Add("Informatica", false);
            dizEsamiIngMecc.Add("Geometria", false);
            dizEsamiIngMecc.Add("Fisica", false);

            // Creazione ogetto Studente:
            Studente studente1 = new Studente("Valentyna", "Bogachova", new Immatricolazione(), new CorsoDiLaurea("Ingegneria", 5, 180, dizEsamiIngMecc, CorsoDiLaurea.Corsolaurea.Ingegneria));


        }

   
    }
}

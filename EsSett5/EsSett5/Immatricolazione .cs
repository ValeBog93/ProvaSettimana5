using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EsSett5
{
    public class Immatricolazione
    {
        private static int MatricolaSeed = 0;
        //Proprietà
        public string Matricola { get; }
        public DateTime DataInizio { get; set; }
        public bool FuoriCorso { get; set; }
        public int CFUAccumulati { get; set; }
        //Corso di laurea: dato da NomeCorso, AnniCorso e cfuCorso.

        public List<CorsoDiLaurea> TuttiCorsiDiLaurea = new List<CorsoDiLaurea>();


        //Costruttore
        public Immatricolazione()
        {
            DataInizio =DateTime.Now;
            FuoriCorso = false;
            CFUAccumulati = 0;
            Matricola = MatricolaSeed.ToString();
            MatricolaSeed++;
        }
    }
}

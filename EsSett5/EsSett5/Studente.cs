using System;
using System.Collections.Generic;
using System.Text;

namespace EsSett5
{
    public class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }
        public CorsoDiLaurea Corso { get; set; } // storico esami passati
        public bool RichiestaLaurea { get; set; }

        public Immatricolazione Immatricolazione { get; set; }


        //Costruttore:
        public Studente(string nome,string cognome, Immatricolazione immatricolazione, CorsoDiLaurea corso)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = 18;
            RichiestaLaurea = false;
            Corso = corso;
            Immatricolazione = immatricolazione;
        }
    
    }
}

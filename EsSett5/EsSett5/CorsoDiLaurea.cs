using System;
using System.Collections.Generic;
using System.Text;

namespace EsSett5
{
    public class CorsoDiLaurea
    {

        //Proprietà:
        public string NomeCorso { get; set; }
        public int AnniDiCorso { get; set; }
        public int CfuTot { get; set; }
        public Corsolaurea Corso { get; }
        public Dictionary<string,bool> listaCorsi { get; set; }

        //Costruttore:

        public CorsoDiLaurea(string nomeCorso, int anniDiCorso, int cfutot, Dictionary<string,bool> corsoiLaurea, Corsolaurea corso)
        {
            NomeCorso = nomeCorso;
            AnniDiCorso = anniDiCorso;
            CfuTot = cfutot;
            listaCorsi = corsoiLaurea;
            Corso = corso;
        }
        public enum Corsolaurea
        {
            Matematica,
            Fisica, 
            Informatica, 
            Ingegneria, 
            Lettere
        }

    }
}

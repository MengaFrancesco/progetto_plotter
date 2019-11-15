using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProgettoPlotter
{
    

    class CVettore
    {

        //ATTRIBUTI
        
        private const int MAXEL=100; //Massimo 100 linee
        private int numEl;           //Numero effettivo di elementi
        private CLinea[] v;          //Vettore di CLinea
        
        public CVettore()
        {
            numEl = 0; //Inizializza numEl
            v = new CLinea[MAXEL]; //Allocazione vettore

        } //Costruttore di default

        //Metodi inserimento / rimozione
        public void push(CLinea nuova)
        {
            if (numEl<MAXEL)
            {
                v[numEl] = nuova; //Inserisce elemento
                numEl++;          //Incrementa numEl
            }
        } //Inserisce nuova linea nel vettore
        public void pop()
        {
            if (numEl>0) //Se c'è almeno un elemento
            {
                v[numEl] = null;    //Deallocazione
                numEl--;
            }
        }              //Elimina l'ultima linea del vettore
        public void shiftSx(int indice)
        {
            for (int i = indice; i < numEl-1; i++) //Partendo dalla posizione scelta
                v[i] = v[i + 1]; //Ogni elemento uguale al successivo

            numEl--; //Decremento numEl
        }

        
        //Metodi toString
        public String toString()
        {
            String s = ""; //Stringa da restituire

            for(int i=0; i<numEl; i++)          //Per ogni elemento
                s += v[i].toString() + "\n";    //Aggiunge formattazione singola linea

            return s; //Restituisce stringa
        }

        public String toString(int indice)
        {
            String s = "";

            if (indice >= 0 && indice < numEl)
            {
                s += v[indice].toString(); //Stringa da restituire

            }

            return s;
        }

    }
}

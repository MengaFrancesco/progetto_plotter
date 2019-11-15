using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoPlotter
{
    /* La classe CLinea memorizza informazioni sulla singola linea */
    class CLinea
    {
        private int x1, y1; //Coordinate punto iniziale

        private int x2, y2; //Coordinate punto iniziale

        
        public CLinea()
        {
            //Inizializza le coordinate
            x1 = 0; 
            y1 = 0;
            x2 = 0; 
            y2 = 0;
        }  //Costruttore di default
        public CLinea(int x1, int y1, int x2, int y2)
        {
            //Imposta le variabili
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        } //Costruttore con parametri
        public CLinea(Point p1, Point p2)
        {
            //Imposta le variabili
            this.x1 = p1.X;
            this.y1 = p1.Y;
            this.x2 = p2.X;
            this.y2 = p2.Y;
        } //Costruttore con parametri

        //Metodi get
        public int getX1() { return x1; }
        public int getY1() { return y1; }
        public int getX2() { return x2; }
        public int getY2() { return y2; }
        public Point getP1() { return new Point(x1, y1); }
        public Point getP2() { return new Point(x2, y2); }

        //Metodi set
        public void setX1(int x1) 
        {this.x1 = x1; }
        public void setY1(int y1) 
        { this.y1 = y1; }
        public void setX2(int x2) 
        { this.x2 = x2; }
        public void setY2(int y2) 
        { 
            this.y2 = y2; 
        }
        public void setP1(Point p1) 
        {
            this.x1 = p1.X;
            this.y1 = p1.Y;
        }
        public void setP2(Point p2) 
        {
            this.x2 = p2.X;
            this.y2 = p2.Y;
        }

        //Metodo toString
        public String toString()
        {
            String s = ""; //Stringa da restituire

            //Aggiunge coordinate punto iniziale
            s += addCoordinata("X1", x1); 
            s += addCoordinata("Y1", y1);

            s += "    "; //Aggiunge spazi extra

            //Aggiunge coordinate punto finale
            s += addCoordinata("X2", x2);
            s += addCoordinata("Y2", y2);

            return s; //Restituisce stringa
        }

        //Crea formattazione per la singola coordinata
        private String addCoordinata(String tipo ,int valore)
        {
            String s = tipo + ": " + valore;

            if (valore < 10) //Se il valore ha una cifra
                s += "     "; //Aggiunge tre spazi
            else if (valore < 100) //Se il valore ha due cifre
                s += "   ";  //Aggiunge due spazi
            else
                s += " "; //Altrimenti aggiunge un solo spazio

            return s; //Restituisce stringa
        }
    }
}

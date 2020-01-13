using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ProgettoPlotter
{
    class CFileCSV
    {
        /* Attributes */
        private string fileName;

        /* Properties */
        public string FileName 
        {
            get { return fileName; }
            set { fileName = value; }
        }

        public CFileCSV() /* Default constructor */
        {
            FileName = "";
        }
        public CFileCSV(string FileName) /* Constructor with parameters */
        {
            this.FileName = FileName;
        }
                
        public List<Line> ReadAll() /* Read all lines in file */
        {
            try
            {
                List<Line> list = new List<Line>(); /* Returned list */
                StreamReader sr = new StreamReader(FileName); /* Initialize new stream reader to read lines */

                while (!sr.EndOfStream) /* While there are lines to read */
                {
                    string line = sr.ReadLine();                /* Read single line */
                    Line l = new Line();                        /* Initialize new question */
                    string[] details = line.Split(';');         /* Split line in array */

                    l.X1 = Int32.Parse(details[0]);
                    l.Y1 = Int32.Parse(details[1]);
                    l.X2 = Int32.Parse(details[2]);
                    l.Y2 = Int32.Parse(details[3]);
                    l.Stroke = new SolidColorBrush((Color)ColorConverter.ConvertFromString(details[4]));

                    list.Add(l);                                /* Add question to question array */
                }
                sr.Close();  /* Closes stream reader */
                return list; /* Return question array */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());  /* Show error message */
                return new List<Line>();    /* Return empty array */
            }
           
        }
        public void ClearFile() /* Remove all questions from file */
        {
            StreamWriter sw = new StreamWriter(FileName, false); /* Stream writer that delete all */
            sw.Close();                                          /* Closes stream writer */
        }
        public override string ToString()
        {
            List<Line> l = ReadAll();       /* Read all lines from CSV file */

            string s = "";                  /* Initialize returned string */

            foreach(Line qst in l)          /* For each line in array */
                s += qst.ToString()+"\n";   /* Add question to a string */

            return s;                       /* Return just created string */
        }
        public void Write(string b)
        {
            StreamWriter sr = new StreamWriter(FileName, true);
            sr.WriteLine(b);
            sr.Close();
        }
    }
}
